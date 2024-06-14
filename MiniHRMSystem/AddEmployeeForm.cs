using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MiniHRMSystem.Models;

namespace MiniHRMSystem
{
  public partial class AddEmployeeForm : Form
  {
    private HRMContext _context;

    public AddEmployeeForm(HRMContext context)
    {
      InitializeComponent();
      _context = context;
      LoadPositions();
    }

    private void LoadPositions()
    {
      var positions = _context.Positions.ToList();
      comboBoxPosition.DataSource = positions;
      comboBoxPosition.DisplayMember = "Title";
      comboBoxPosition.ValueMember = "PositionId";
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
      var employee = new Employee
      {
        FirstName = textBoxFirstName.Text,
        LastName = textBoxLastName.Text,
        MiddleName = textBoxMiddleName.Text,
        DateOfBirth = dateTimePickerDOB.Value,
        Gender = comboBoxGender.Text,
        PositionId = (int)comboBoxPosition.SelectedValue
      };

      if (pictureBoxPhoto.Image != null)
      {
        using (var ms = new MemoryStream())
        {
          pictureBoxPhoto.Image.Save(ms, pictureBoxPhoto.Image.RawFormat);
          employee.Photo = ms.ToArray();
        }
      }

      _context.Employees.Add(employee);
      _context.SaveChanges();
      DialogResult = DialogResult.OK;
    }

    private void buttonUploadPhoto_Click(object sender, EventArgs e)
    {
      using (var openFileDialog = new OpenFileDialog())
      {
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
          pictureBoxPhoto.Image = Image.FromFile(openFileDialog.FileName);
        }
      }
    }

    private void pictureBoxPhoto_Click(object sender, EventArgs e)
    {

    }

    private void comboBoxPosition_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void dateTimePickerDOB_ValueChanged(object sender, EventArgs e)
    {
    }

    private void AddEmployeeForm_Load(object sender, EventArgs e)
    {

    }

    private void textBoxFirstName_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBoxMiddleName_TextChanged(object sender, EventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }
  }
}