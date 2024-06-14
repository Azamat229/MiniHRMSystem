namespace MiniHRMSystem
{
  partial class AddEmployeeForm
  {
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.TextBox textBoxFirstName;
    private System.Windows.Forms.TextBox textBoxLastName;
    private System.Windows.Forms.TextBox textBoxMiddleName;

    private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
    private System.Windows.Forms.ComboBox comboBoxGender;
    private System.Windows.Forms.ComboBox comboBoxPosition;
    private System.Windows.Forms.PictureBox pictureBoxPhoto;
    private System.Windows.Forms.Button buttonSave;
    private System.Windows.Forms.Button buttonUploadPhoto;

    // Добавлены метки
    private System.Windows.Forms.Label labelFirstName; // Метка для FirstName
    private System.Windows.Forms.Label labelLastName;  // Метка для LastName
    private System.Windows.Forms.Label labelMiddleName; // Метка для MiddleName


    private void InitializeComponent()
    {
      textBoxFirstName = new System.Windows.Forms.TextBox();
      textBoxLastName = new System.Windows.Forms.TextBox();
      textBoxMiddleName = new System.Windows.Forms.TextBox();
      dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
      comboBoxGender = new System.Windows.Forms.ComboBox();
      comboBoxPosition = new System.Windows.Forms.ComboBox();
      pictureBoxPhoto = new System.Windows.Forms.PictureBox();
      buttonSave = new System.Windows.Forms.Button();
      buttonUploadPhoto = new System.Windows.Forms.Button();
      labelFirstName = new System.Windows.Forms.Label();
      labelLastName = new System.Windows.Forms.Label();
      labelMiddleName = new System.Windows.Forms.Label();
      label1 = new System.Windows.Forms.Label();
      label2 = new System.Windows.Forms.Label();
      label3 = new System.Windows.Forms.Label();
      label4 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).BeginInit();
      SuspendLayout();
      // 
      // textBoxFirstName
      // 
      textBoxFirstName.Location = new System.Drawing.Point(117, 23);
      textBoxFirstName.Name = "textBoxFirstName";
      textBoxFirstName.Size = new System.Drawing.Size(260, 23);
      textBoxFirstName.TabIndex = 0;
      // 
      // textBoxLastName
      // 
      textBoxLastName.Location = new System.Drawing.Point(117, 53);
      textBoxLastName.Name = "textBoxLastName";
      textBoxLastName.Size = new System.Drawing.Size(260, 23);
      textBoxLastName.TabIndex = 1;
      // 
      // textBoxMiddleName
      // 
      textBoxMiddleName.Location = new System.Drawing.Point(117, 88);
      textBoxMiddleName.Name = "textBoxMiddleName";
      textBoxMiddleName.Size = new System.Drawing.Size(260, 23);
      textBoxMiddleName.TabIndex = 2;
      textBoxMiddleName.TextChanged += textBoxMiddleName_TextChanged;
      // 
      // dateTimePickerDOB
      // 
      dateTimePickerDOB.Location = new System.Drawing.Point(117, 128);
      dateTimePickerDOB.Name = "dateTimePickerDOB";
      dateTimePickerDOB.Size = new System.Drawing.Size(260, 23);
      dateTimePickerDOB.TabIndex = 1;
      dateTimePickerDOB.ValueChanged += dateTimePickerDOB_ValueChanged;
      // 
      // comboBoxGender
      // 
      comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      comboBoxGender.FormattingEnabled = true;
      comboBoxGender.Items.AddRange(new object[] { "Male", "Female" });
      comboBoxGender.Location = new System.Drawing.Point(117, 154);
      comboBoxGender.Name = "comboBoxGender";
      comboBoxGender.Size = new System.Drawing.Size(260, 23);
      comboBoxGender.TabIndex = 2;
      comboBoxGender.SelectedIndexChanged += comboBoxGender_SelectedIndexChanged;
      // 
      // comboBoxPosition
      // 
      comboBoxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      comboBoxPosition.FormattingEnabled = true;
      comboBoxPosition.Location = new System.Drawing.Point(117, 181);
      comboBoxPosition.Name = "comboBoxPosition";
      comboBoxPosition.Size = new System.Drawing.Size(260, 23);
      comboBoxPosition.TabIndex = 3;
      comboBoxPosition.SelectedIndexChanged += comboBoxPosition_SelectedIndexChanged;
      // 
      // pictureBoxPhoto
      // 
      pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      pictureBoxPhoto.Location = new System.Drawing.Point(117, 208);
      pictureBoxPhoto.Name = "pictureBoxPhoto";
      pictureBoxPhoto.Size = new System.Drawing.Size(100, 100);
      pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      pictureBoxPhoto.TabIndex = 4;
      pictureBoxPhoto.TabStop = false;
      pictureBoxPhoto.Click += pictureBoxPhoto_Click;
      // 
      // buttonSave
      // 
      buttonSave.Location = new System.Drawing.Point(117, 314);
      buttonSave.Name = "buttonSave";
      buttonSave.Size = new System.Drawing.Size(260, 23);
      buttonSave.TabIndex = 6;
      buttonSave.Text = "Save";
      buttonSave.UseVisualStyleBackColor = true;
      buttonSave.Click += buttonSave_Click;
      // 
      // buttonUploadPhoto
      // 
      buttonUploadPhoto.Location = new System.Drawing.Point(223, 285);
      buttonUploadPhoto.Name = "buttonUploadPhoto";
      buttonUploadPhoto.Size = new System.Drawing.Size(154, 23);
      buttonUploadPhoto.TabIndex = 5;
      buttonUploadPhoto.Text = "Upload Photo";
      buttonUploadPhoto.UseVisualStyleBackColor = true;
      buttonUploadPhoto.Click += buttonUploadPhoto_Click;
      // 
      // labelFirstName
      // 
      labelFirstName.AutoSize = true;
      labelFirstName.Location = new System.Drawing.Point(30, 26);
      labelFirstName.Name = "labelFirstName";
      labelFirstName.Size = new System.Drawing.Size(64, 15);
      labelFirstName.TabIndex = 0;
      labelFirstName.Text = "First Name";
      // 
      // labelLastName
      // 
      labelLastName.AutoSize = true;
      labelLastName.Location = new System.Drawing.Point(30, 56);
      labelLastName.Name = "labelLastName";
      labelLastName.Size = new System.Drawing.Size(63, 15);
      labelLastName.TabIndex = 0;
      labelLastName.Text = "Last Name";
      // 
      // labelMiddleName
      // 
      labelMiddleName.AutoSize = true;
      labelMiddleName.Location = new System.Drawing.Point(30, 91);
      labelMiddleName.Name = "labelMiddleName";
      labelMiddleName.Size = new System.Drawing.Size(79, 15);
      labelMiddleName.TabIndex = 0;
      labelMiddleName.Text = "Middle Name";
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new System.Drawing.Point(30, 134);
      label1.Name = "label1";
      label1.Size = new System.Drawing.Size(54, 15);
      label1.TabIndex = 7;
      label1.Text = "Birth day";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new System.Drawing.Point(30, 157);
      label2.Name = "label2";
      label2.Size = new System.Drawing.Size(25, 15);
      label2.TabIndex = 8;
      label2.Text = "Sex";
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Location = new System.Drawing.Point(30, 189);
      label3.Name = "label3";
      label3.Size = new System.Drawing.Size(50, 15);
      label3.TabIndex = 9;
      label3.Text = "Position";
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Location = new System.Drawing.Point(30, 247);
      label4.Name = "label4";
      label4.Size = new System.Drawing.Size(39, 15);
      label4.TabIndex = 10;
      label4.Text = "Photo";
      label4.Click += label4_Click;
      // 
      // AddEmployeeForm
      // 
      ClientSize = new System.Drawing.Size(794, 618);
      Controls.Add(label4);
      Controls.Add(label3);
      Controls.Add(label2);
      Controls.Add(label1);
      Controls.Add(buttonSave);
      Controls.Add(buttonUploadPhoto);
      Controls.Add(pictureBoxPhoto);
      Controls.Add(comboBoxPosition);
      Controls.Add(comboBoxGender);
      Controls.Add(dateTimePickerDOB);
      Controls.Add(textBoxMiddleName);
      Controls.Add(labelMiddleName);
      Controls.Add(textBoxLastName);
      Controls.Add(labelLastName);
      Controls.Add(textBoxFirstName);
      Controls.Add(labelFirstName);
      Name = "AddEmployeeForm";
      Text = "Add Employee";
      Load += AddEmployeeForm_Load;
      ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
  }
}
