using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using MiniHRMSystem.Models;

namespace MiniHRMSystem
{
  public partial class MainForm : Form
  {
    private readonly HRMContext _context;

    public MainForm(HRMContext context)
    {
      InitializeComponent();
      _context = context;
      LoadEmployees();
    }

    private void LoadEmployees()
    {
      var employees = _context.Employees.Include(e => e.Position).ThenInclude(p => p.Department).ToList();
      dataGridViewEmployees.DataSource = employees.Select(e => new
      {
        e.EmployeeId,
        FullName = $"{e.FirstName} {e.MiddleName} {e.LastName}",
        Position = e.Position.Title,
        Department = e.Position.Department.Name,
        e.DateOfBirth,
        e.Gender
      }).ToList();
    }

    private void buttonAddEmployee_Click(object sender, EventArgs e)
    {
      var addEmployeeForm = new AddEmployeeForm(_context);
      if (addEmployeeForm.ShowDialog() == DialogResult.OK)
      {
        LoadEmployees();
      }
    }

    private void buttonDeleteEmployee_Click(object sender, EventArgs e)
    {
      if (dataGridViewEmployees.SelectedRows.Count > 0)
      {
        var employeeId = (int)dataGridViewEmployees.SelectedRows[0].Cells[0].Value;
        var employee = _context.Employees.Find(employeeId);
        if (employee != null)
        {
          employee.IsDeleted = true;
          _context.SaveChanges();
          LoadEmployees();
        }
      }
    }

    private void textBoxSearch_TextChanged(object sender, EventArgs e)
    {
      var searchText = textBoxSearch.Text.ToLower();
      var employees = _context.Employees.Include(e => e.Position)
          .Where(e => e.FirstName.ToLower().Contains(searchText) ||
                      e.MiddleName.ToLower().Contains(searchText) ||
                      e.LastName.ToLower().Contains(searchText))
          .ToList();

      dataGridViewEmployees.DataSource = employees.Select(e => new
      {
        e.EmployeeId,
        FullName = $"{e.FirstName} {e.MiddleName} {e.LastName}",
        Position = e.Position.Title,
        Department = e.Position.Department.Name,
        e.DateOfBirth,
        e.Gender
      }).ToList();
    }
  }
}