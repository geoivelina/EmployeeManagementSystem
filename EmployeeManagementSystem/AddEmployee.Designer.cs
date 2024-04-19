namespace EmployeeManagementSystem
{
    partial class AddEmployee
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmployeeDataPreview = new System.Windows.Forms.DataGridView();
            this.EmployeesDataLable = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddEmployeeStatusComboBox = new System.Windows.Forms.ComboBox();
            this.AddEmplpyeeStatusLable = new System.Windows.Forms.Label();
            this.AddEmployeeClearBtn = new System.Windows.Forms.Button();
            this.AddEmployeeDeleteBtn = new System.Windows.Forms.Button();
            this.AddEmployeeUpdateBtn = new System.Windows.Forms.Button();
            this.AddEmployeeAddBtn = new System.Windows.Forms.Button();
            this.AddEmployeeImportPictureBtn = new System.Windows.Forms.Button();
            this.AddEmployeePictureBox = new System.Windows.Forms.PictureBox();
            this.AddEmployeePositionComboBox = new System.Windows.Forms.ComboBox();
            this.AddEmployeePossitionLable = new System.Windows.Forms.Label();
            this.AddEmployeePhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.AddEmployeePhoneNumberLable = new System.Windows.Forms.Label();
            this.AddEmployeeGenderComboBox = new System.Windows.Forms.ComboBox();
            this.AddEmployeeGenderLable = new System.Windows.Forms.Label();
            this.AddEmployeeFullNameTextBox = new System.Windows.Forms.TextBox();
            this.AddEmployeeFullNameLable = new System.Windows.Forms.Label();
            this.AddEmployeeIDTextBox = new System.Windows.Forms.TextBox();
            this.AddEmployeeIDLable = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataPreview)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddEmployeePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.EmployeeDataPreview);
            this.panel1.Controls.Add(this.EmployeesDataLable);
            this.panel1.Location = new System.Drawing.Point(28, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 247);
            this.panel1.TabIndex = 0;
            // 
            // EmployeeDataPreview
            // 
            this.EmployeeDataPreview.AllowUserToAddRows = false;
            this.EmployeeDataPreview.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeDataPreview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeeDataPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeDataPreview.EnableHeadersVisualStyles = false;
            this.EmployeeDataPreview.Location = new System.Drawing.Point(23, 67);
            this.EmployeeDataPreview.Name = "EmployeeDataPreview";
            this.EmployeeDataPreview.ReadOnly = true;
            this.EmployeeDataPreview.RowHeadersVisible = false;
            this.EmployeeDataPreview.RowHeadersWidth = 51;
            this.EmployeeDataPreview.RowTemplate.Height = 24;
            this.EmployeeDataPreview.Size = new System.Drawing.Size(700, 158);
            this.EmployeeDataPreview.TabIndex = 1;
            this.EmployeeDataPreview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeDataPreview_CellClick);
            // 
            // EmployeesDataLable
            // 
            this.EmployeesDataLable.AutoSize = true;
            this.EmployeesDataLable.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeesDataLable.Location = new System.Drawing.Point(19, 25);
            this.EmployeesDataLable.Name = "EmployeesDataLable";
            this.EmployeesDataLable.Size = new System.Drawing.Size(143, 22);
            this.EmployeesDataLable.TabIndex = 0;
            this.EmployeesDataLable.Text = "Employee`s Data";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.AddEmployeeStatusComboBox);
            this.panel2.Controls.Add(this.AddEmplpyeeStatusLable);
            this.panel2.Controls.Add(this.AddEmployeeClearBtn);
            this.panel2.Controls.Add(this.AddEmployeeDeleteBtn);
            this.panel2.Controls.Add(this.AddEmployeeUpdateBtn);
            this.panel2.Controls.Add(this.AddEmployeeAddBtn);
            this.panel2.Controls.Add(this.AddEmployeeImportPictureBtn);
            this.panel2.Controls.Add(this.AddEmployeePictureBox);
            this.panel2.Controls.Add(this.AddEmployeePositionComboBox);
            this.panel2.Controls.Add(this.AddEmployeePossitionLable);
            this.panel2.Controls.Add(this.AddEmployeePhoneNumberTextBox);
            this.panel2.Controls.Add(this.AddEmployeePhoneNumberLable);
            this.panel2.Controls.Add(this.AddEmployeeGenderComboBox);
            this.panel2.Controls.Add(this.AddEmployeeGenderLable);
            this.panel2.Controls.Add(this.AddEmployeeFullNameTextBox);
            this.panel2.Controls.Add(this.AddEmployeeFullNameLable);
            this.panel2.Controls.Add(this.AddEmployeeIDTextBox);
            this.panel2.Controls.Add(this.AddEmployeeIDLable);
            this.panel2.Location = new System.Drawing.Point(28, 290);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(748, 247);
            this.panel2.TabIndex = 1;
            // 
            // AddEmployeeStatusComboBox
            // 
            this.AddEmployeeStatusComboBox.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeeStatusComboBox.FormattingEnabled = true;
            this.AddEmployeeStatusComboBox.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.AddEmployeeStatusComboBox.Location = new System.Drawing.Point(162, 183);
            this.AddEmployeeStatusComboBox.Name = "AddEmployeeStatusComboBox";
            this.AddEmployeeStatusComboBox.Size = new System.Drawing.Size(196, 28);
            this.AddEmployeeStatusComboBox.TabIndex = 18;
            // 
            // AddEmplpyeeStatusLable
            // 
            this.AddEmplpyeeStatusLable.AutoSize = true;
            this.AddEmplpyeeStatusLable.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmplpyeeStatusLable.Location = new System.Drawing.Point(19, 181);
            this.AddEmplpyeeStatusLable.Name = "AddEmplpyeeStatusLable";
            this.AddEmplpyeeStatusLable.Size = new System.Drawing.Size(55, 20);
            this.AddEmplpyeeStatusLable.TabIndex = 17;
            this.AddEmplpyeeStatusLable.Text = "Status:";
            this.AddEmplpyeeStatusLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddEmployeeClearBtn
            // 
            this.AddEmployeeClearBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.AddEmployeeClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddEmployeeClearBtn.FlatAppearance.BorderSize = 0;
            this.AddEmployeeClearBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.AddEmployeeClearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.AddEmployeeClearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.AddEmployeeClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployeeClearBtn.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeeClearBtn.Location = new System.Drawing.Point(629, 169);
            this.AddEmployeeClearBtn.Name = "AddEmployeeClearBtn";
            this.AddEmployeeClearBtn.Size = new System.Drawing.Size(94, 42);
            this.AddEmployeeClearBtn.TabIndex = 16;
            this.AddEmployeeClearBtn.Text = "Clear";
            this.AddEmployeeClearBtn.UseVisualStyleBackColor = false;
            this.AddEmployeeClearBtn.Click += new System.EventHandler(this.AddEmployeeClearBtn_Click);
            // 
            // AddEmployeeDeleteBtn
            // 
            this.AddEmployeeDeleteBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.AddEmployeeDeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddEmployeeDeleteBtn.FlatAppearance.BorderSize = 0;
            this.AddEmployeeDeleteBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.AddEmployeeDeleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.AddEmployeeDeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.AddEmployeeDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployeeDeleteBtn.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeeDeleteBtn.Location = new System.Drawing.Point(629, 121);
            this.AddEmployeeDeleteBtn.Name = "AddEmployeeDeleteBtn";
            this.AddEmployeeDeleteBtn.Size = new System.Drawing.Size(94, 42);
            this.AddEmployeeDeleteBtn.TabIndex = 15;
            this.AddEmployeeDeleteBtn.Text = "Delete";
            this.AddEmployeeDeleteBtn.UseVisualStyleBackColor = false;
            this.AddEmployeeDeleteBtn.Click += new System.EventHandler(this.AddEmployeeDeleteBtn_Click);
            // 
            // AddEmployeeUpdateBtn
            // 
            this.AddEmployeeUpdateBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.AddEmployeeUpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddEmployeeUpdateBtn.FlatAppearance.BorderSize = 0;
            this.AddEmployeeUpdateBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.AddEmployeeUpdateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.AddEmployeeUpdateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.AddEmployeeUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployeeUpdateBtn.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeeUpdateBtn.Location = new System.Drawing.Point(629, 73);
            this.AddEmployeeUpdateBtn.Name = "AddEmployeeUpdateBtn";
            this.AddEmployeeUpdateBtn.Size = new System.Drawing.Size(94, 42);
            this.AddEmployeeUpdateBtn.TabIndex = 14;
            this.AddEmployeeUpdateBtn.Text = "Update";
            this.AddEmployeeUpdateBtn.UseVisualStyleBackColor = false;
            this.AddEmployeeUpdateBtn.Click += new System.EventHandler(this.AddEmployeeUpdateBtn_Click);
            // 
            // AddEmployeeAddBtn
            // 
            this.AddEmployeeAddBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.AddEmployeeAddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddEmployeeAddBtn.FlatAppearance.BorderSize = 0;
            this.AddEmployeeAddBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.AddEmployeeAddBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.AddEmployeeAddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.AddEmployeeAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployeeAddBtn.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeeAddBtn.Location = new System.Drawing.Point(629, 25);
            this.AddEmployeeAddBtn.Name = "AddEmployeeAddBtn";
            this.AddEmployeeAddBtn.Size = new System.Drawing.Size(94, 42);
            this.AddEmployeeAddBtn.TabIndex = 13;
            this.AddEmployeeAddBtn.Text = "Add";
            this.AddEmployeeAddBtn.UseVisualStyleBackColor = false;
            this.AddEmployeeAddBtn.Click += new System.EventHandler(this.AddEmployeeAddBtn_Click);
            // 
            // AddEmployeeImportPictureBtn
            // 
            this.AddEmployeeImportPictureBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.AddEmployeeImportPictureBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddEmployeeImportPictureBtn.FlatAppearance.BorderSize = 0;
            this.AddEmployeeImportPictureBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.AddEmployeeImportPictureBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.AddEmployeeImportPictureBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployeeImportPictureBtn.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeeImportPictureBtn.Location = new System.Drawing.Point(428, 180);
            this.AddEmployeeImportPictureBtn.Name = "AddEmployeeImportPictureBtn";
            this.AddEmployeeImportPictureBtn.Size = new System.Drawing.Size(126, 29);
            this.AddEmployeeImportPictureBtn.TabIndex = 12;
            this.AddEmployeeImportPictureBtn.Text = "Import";
            this.AddEmployeeImportPictureBtn.UseVisualStyleBackColor = false;
            this.AddEmployeeImportPictureBtn.Click += new System.EventHandler(this.AddEmployeeImportPictureBtn_Click);
            // 
            // AddEmployeePictureBox
            // 
            this.AddEmployeePictureBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.AddEmployeePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddEmployeePictureBox.Location = new System.Drawing.Point(428, 23);
            this.AddEmployeePictureBox.Name = "AddEmployeePictureBox";
            this.AddEmployeePictureBox.Size = new System.Drawing.Size(126, 138);
            this.AddEmployeePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddEmployeePictureBox.TabIndex = 11;
            this.AddEmployeePictureBox.TabStop = false;
            // 
            // AddEmployeePositionComboBox
            // 
            this.AddEmployeePositionComboBox.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeePositionComboBox.FormattingEnabled = true;
            this.AddEmployeePositionComboBox.Items.AddRange(new object[] {
            "Business Manager",
            "Front-End Developer",
            "Back-End Developer",
            "Data Administrator",
            "UI/UX Design",
            "Quality Assurance"});
            this.AddEmployeePositionComboBox.Location = new System.Drawing.Point(162, 145);
            this.AddEmployeePositionComboBox.Name = "AddEmployeePositionComboBox";
            this.AddEmployeePositionComboBox.Size = new System.Drawing.Size(196, 28);
            this.AddEmployeePositionComboBox.TabIndex = 9;
            // 
            // AddEmployeePossitionLable
            // 
            this.AddEmployeePossitionLable.AutoSize = true;
            this.AddEmployeePossitionLable.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeePossitionLable.Location = new System.Drawing.Point(19, 148);
            this.AddEmployeePossitionLable.Name = "AddEmployeePossitionLable";
            this.AddEmployeePossitionLable.Size = new System.Drawing.Size(70, 20);
            this.AddEmployeePossitionLable.TabIndex = 8;
            this.AddEmployeePossitionLable.Text = "Position:";
            this.AddEmployeePossitionLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddEmployeePhoneNumberTextBox
            // 
            this.AddEmployeePhoneNumberTextBox.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeePhoneNumberTextBox.Location = new System.Drawing.Point(162, 113);
            this.AddEmployeePhoneNumberTextBox.Name = "AddEmployeePhoneNumberTextBox";
            this.AddEmployeePhoneNumberTextBox.Size = new System.Drawing.Size(196, 26);
            this.AddEmployeePhoneNumberTextBox.TabIndex = 7;
            // 
            // AddEmployeePhoneNumberLable
            // 
            this.AddEmployeePhoneNumberLable.AutoSize = true;
            this.AddEmployeePhoneNumberLable.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeePhoneNumberLable.Location = new System.Drawing.Point(19, 116);
            this.AddEmployeePhoneNumberLable.Name = "AddEmployeePhoneNumberLable";
            this.AddEmployeePhoneNumberLable.Size = new System.Drawing.Size(118, 20);
            this.AddEmployeePhoneNumberLable.TabIndex = 6;
            this.AddEmployeePhoneNumberLable.Text = "Phone Number:";
            // 
            // AddEmployeeGenderComboBox
            // 
            this.AddEmployeeGenderComboBox.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeeGenderComboBox.FormattingEnabled = true;
            this.AddEmployeeGenderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.AddEmployeeGenderComboBox.Location = new System.Drawing.Point(162, 79);
            this.AddEmployeeGenderComboBox.Name = "AddEmployeeGenderComboBox";
            this.AddEmployeeGenderComboBox.Size = new System.Drawing.Size(196, 28);
            this.AddEmployeeGenderComboBox.TabIndex = 5;
            // 
            // AddEmployeeGenderLable
            // 
            this.AddEmployeeGenderLable.AutoSize = true;
            this.AddEmployeeGenderLable.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeeGenderLable.Location = new System.Drawing.Point(19, 79);
            this.AddEmployeeGenderLable.Name = "AddEmployeeGenderLable";
            this.AddEmployeeGenderLable.Size = new System.Drawing.Size(62, 20);
            this.AddEmployeeGenderLable.TabIndex = 4;
            this.AddEmployeeGenderLable.Text = "Gender:";
            this.AddEmployeeGenderLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddEmployeeFullNameTextBox
            // 
            this.AddEmployeeFullNameTextBox.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeeFullNameTextBox.Location = new System.Drawing.Point(162, 47);
            this.AddEmployeeFullNameTextBox.Name = "AddEmployeeFullNameTextBox";
            this.AddEmployeeFullNameTextBox.Size = new System.Drawing.Size(196, 26);
            this.AddEmployeeFullNameTextBox.TabIndex = 3;
            // 
            // AddEmployeeFullNameLable
            // 
            this.AddEmployeeFullNameLable.AutoSize = true;
            this.AddEmployeeFullNameLable.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeeFullNameLable.Location = new System.Drawing.Point(19, 47);
            this.AddEmployeeFullNameLable.Name = "AddEmployeeFullNameLable";
            this.AddEmployeeFullNameLable.Size = new System.Drawing.Size(88, 20);
            this.AddEmployeeFullNameLable.TabIndex = 2;
            this.AddEmployeeFullNameLable.Text = "Full Name:";
            // 
            // AddEmployeeIDTextBox
            // 
            this.AddEmployeeIDTextBox.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeeIDTextBox.Location = new System.Drawing.Point(162, 13);
            this.AddEmployeeIDTextBox.Name = "AddEmployeeIDTextBox";
            this.AddEmployeeIDTextBox.Size = new System.Drawing.Size(196, 26);
            this.AddEmployeeIDTextBox.TabIndex = 1;
            // 
            // AddEmployeeIDLable
            // 
            this.AddEmployeeIDLable.AutoSize = true;
            this.AddEmployeeIDLable.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeeIDLable.Location = new System.Drawing.Point(19, 13);
            this.AddEmployeeIDLable.Name = "AddEmployeeIDLable";
            this.AddEmployeeIDLable.Size = new System.Drawing.Size(105, 20);
            this.AddEmployeeIDLable.TabIndex = 0;
            this.AddEmployeeIDLable.Text = "Employee ID:";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddEmployee";
            this.Size = new System.Drawing.Size(803, 565);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataPreview)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddEmployeePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label EmployeesDataLable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView EmployeeDataPreview;
        private System.Windows.Forms.Label AddEmployeeGenderLable;
        private System.Windows.Forms.TextBox AddEmployeeFullNameTextBox;
        private System.Windows.Forms.Label AddEmployeeFullNameLable;
        private System.Windows.Forms.TextBox AddEmployeeIDTextBox;
        private System.Windows.Forms.Label AddEmployeeIDLable;
        private System.Windows.Forms.ComboBox AddEmployeeGenderComboBox;
        private System.Windows.Forms.PictureBox AddEmployeePictureBox;
        private System.Windows.Forms.ComboBox AddEmployeePositionComboBox;
        private System.Windows.Forms.Label AddEmployeePossitionLable;
        private System.Windows.Forms.TextBox AddEmployeePhoneNumberTextBox;
        private System.Windows.Forms.Label AddEmployeePhoneNumberLable;
        private System.Windows.Forms.Button AddEmployeeClearBtn;
        private System.Windows.Forms.Button AddEmployeeDeleteBtn;
        private System.Windows.Forms.Button AddEmployeeUpdateBtn;
        private System.Windows.Forms.Button AddEmployeeAddBtn;
        private System.Windows.Forms.Button AddEmployeeImportPictureBtn;
        private System.Windows.Forms.ComboBox AddEmployeeStatusComboBox;
        private System.Windows.Forms.Label AddEmplpyeeStatusLable;
    }
}
