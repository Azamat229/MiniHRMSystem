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
      var employeeData = employees.Select(e => new
      {
        EmployeeId = e.EmployeeId, 
        FullName = $"{e.FirstName} {e.MiddleName} {e.LastName}",
        Position = e.Position.Title,
        Department = e.Position.Department.Name,
        DateOfBirth = e.DateOfBirth.ToShortDateString(),
        e.Gender
      }).ToList();

      dataGridViewEmployees.DataSource = employeeData;
      dataGridViewEmployees.Columns["EmployeeId"].Visible = false;
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
        // Получить ID выбранного сотрудника
        var employeeId = (int)dataGridViewEmployees.SelectedRows[0].Cells["EmployeeId"].Value;
        var employee = _context.Employees.Find(employeeId);
        if (employee != null)
        {
          // Показать диалоговое окно подтверждения
          var result = MessageBox.Show(
              $"Are you sure you want to delete employee {employee.FirstName} {employee.LastName}?",
              "Confirm Deletion",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Warning
          );

          // Если пользователь нажал Yes, выполнить мягкое удаление
          if (result == DialogResult.Yes)
          {
            // Мягкое удаление
            employee.IsDeleted = true;
            _context.SaveChanges();
            LoadEmployees();
          }
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
        FullName = $"{e.FirstName} {e.MiddleName} {e.LastName}",
        Position = e.Position.Title,
        Department = e.Position.Department.Name,
        DateOfBirth = e.DateOfBirth.ToShortDateString(),
        e.Gender
      }).ToList();
    }
  }
}