namespace EmployeeManagementSystem
{
    partial class RegisterForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RegisterShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.RegisterAccountBtn = new System.Windows.Forms.Button();
            this.RegisterPasswordValueTextBox = new System.Windows.Forms.TextBox();
            this.RegisterPasswordLable = new System.Windows.Forms.Label();
            this.RegisterUsernameValueTextBox = new System.Windows.Forms.TextBox();
            this.RegisterUsernameLable = new System.Windows.Forms.Label();
            this.RegisterAccountLable = new System.Windows.Forms.Label();
            this.РегистерCloseLable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RegisterPictureBox = new System.Windows.Forms.PictureBox();
            this.RegisterEMSLable = new System.Windows.Forms.Label();
            this.RegisterLoginBtn = new System.Windows.Forms.Button();
            this.RegisterLoginLable = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RegisterShowPasswordCheckBox
            // 
            this.RegisterShowPasswordCheckBox.AutoSize = true;
            this.RegisterShowPasswordCheckBox.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterShowPasswordCheckBox.Location = new System.Drawing.Point(529, 289);
            this.RegisterShowPasswordCheckBox.Name = "RegisterShowPasswordCheckBox";
            this.RegisterShowPasswordCheckBox.Size = new System.Drawing.Size(108, 19);
            this.RegisterShowPasswordCheckBox.TabIndex = 16;
            this.RegisterShowPasswordCheckBox.Text = "Show password";
            this.RegisterShowPasswordCheckBox.UseVisualStyleBackColor = true;
            this.RegisterShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.RegisterShowPasswordCheckBox_CheckedChanged);
            // 
            // RegisterAccountBtn
            // 
            this.RegisterAccountBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.RegisterAccountBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterAccountBtn.FlatAppearance.BorderSize = 0;
            this.RegisterAccountBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.RegisterAccountBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.RegisterAccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterAccountBtn.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterAccountBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RegisterAccountBtn.Location = new System.Drawing.Point(457, 365);
            this.RegisterAccountBtn.Name = "RegisterAccountBtn";
            this.RegisterAccountBtn.Size = new System.Drawing.Size(132, 47);
            this.RegisterAccountBtn.TabIndex = 15;
            this.RegisterAccountBtn.Text = "Register";
            this.RegisterAccountBtn.UseVisualStyleBackColor = false;
            this.RegisterAccountBtn.Click += new System.EventHandler(this.RegisterAccountBtn_Click);
            // 
            // RegisterPasswordValueTextBox
            // 
            this.RegisterPasswordValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterPasswordValueTextBox.Location = new System.Drawing.Point(411, 244);
            this.RegisterPasswordValueTextBox.Name = "RegisterPasswordValueTextBox";
            this.RegisterPasswordValueTextBox.PasswordChar = '*';
            this.RegisterPasswordValueTextBox.Size = new System.Drawing.Size(226, 30);
            this.RegisterPasswordValueTextBox.TabIndex = 14;
            // 
            // RegisterPasswordLable
            // 
            this.RegisterPasswordLable.AutoSize = true;
            this.RegisterPasswordLable.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterPasswordLable.Location = new System.Drawing.Point(411, 216);
            this.RegisterPasswordLable.Name = "RegisterPasswordLable";
            this.RegisterPasswordLable.Size = new System.Drawing.Size(91, 22);
            this.RegisterPasswordLable.TabIndex = 13;
            this.RegisterPasswordLable.Text = "Password:";
            // 
            // RegisterUsernameValueTextBox
            // 
            this.RegisterUsernameValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterUsernameValueTextBox.Location = new System.Drawing.Point(411, 164);
            this.RegisterUsernameValueTextBox.Name = "RegisterUsernameValueTextBox";
            this.RegisterUsernameValueTextBox.Size = new System.Drawing.Size(226, 30);
            this.RegisterUsernameValueTextBox.TabIndex = 12;
            // 
            // RegisterUsernameLable
            // 
            this.RegisterUsernameLable.AutoSize = true;
            this.RegisterUsernameLable.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterUsernameLable.Location = new System.Drawing.Point(411, 136);
            this.RegisterUsernameLable.Name = "RegisterUsernameLable";
            this.RegisterUsernameLable.Size = new System.Drawing.Size(95, 22);
            this.RegisterUsernameLable.TabIndex = 11;
            this.RegisterUsernameLable.Text = "Username:";
            // 
            // RegisterAccountLable
            // 
            this.RegisterAccountLable.AutoSize = true;
            this.RegisterAccountLable.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterAccountLable.Location = new System.Drawing.Point(432, 59);
            this.RegisterAccountLable.Name = "RegisterAccountLable";
            this.RegisterAccountLable.Size = new System.Drawing.Size(219, 31);
            this.RegisterAccountLable.TabIndex = 8;
            this.RegisterAccountLable.Text = "Register Account";
            // 
            // РегистерCloseLable
            // 
            this.РегистерCloseLable.AutoSize = true;
            this.РегистерCloseLable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.РегистерCloseLable.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.РегистерCloseLable.Location = new System.Drawing.Point(676, 7);
            this.РегистерCloseLable.Name = "РегистерCloseLable";
            this.РегистерCloseLable.Size = new System.Drawing.Size(22, 24);
            this.РегистерCloseLable.TabIndex = 10;
            this.РегистерCloseLable.Text = "X";
            this.РегистерCloseLable.Click += new System.EventHandler(this.РегистерCloseLable_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.RegisterPictureBox);
            this.panel1.Controls.Add(this.RegisterEMSLable);
            this.panel1.Controls.Add(this.RegisterLoginBtn);
            this.panel1.Controls.Add(this.RegisterLoginLable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 534);
            this.panel1.TabIndex = 9;
            // 
            // RegisterPictureBox
            // 
            this.RegisterPictureBox.Image = global::EmployeeManagementSystem.Properties.Resources.employeeCard;
            this.RegisterPictureBox.Location = new System.Drawing.Point(91, 147);
            this.RegisterPictureBox.Name = "RegisterPictureBox";
            this.RegisterPictureBox.Size = new System.Drawing.Size(148, 172);
            this.RegisterPictureBox.TabIndex = 9;
            this.RegisterPictureBox.TabStop = false;
            // 
            // RegisterEMSLable
            // 
            this.RegisterEMSLable.AutoSize = true;
            this.RegisterEMSLable.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterEMSLable.Location = new System.Drawing.Point(11, 74);
            this.RegisterEMSLable.Name = "RegisterEMSLable";
            this.RegisterEMSLable.Size = new System.Drawing.Size(294, 25);
            this.RegisterEMSLable.TabIndex = 8;
            this.RegisterEMSLable.Text = "Employee Management System";
            // 
            // RegisterLoginBtn
            // 
            this.RegisterLoginBtn.BackColor = System.Drawing.Color.White;
            this.RegisterLoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterLoginBtn.FlatAppearance.BorderSize = 0;
            this.RegisterLoginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.RegisterLoginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.RegisterLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterLoginBtn.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterLoginBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RegisterLoginBtn.Location = new System.Drawing.Point(103, 446);
            this.RegisterLoginBtn.Name = "RegisterLoginBtn";
            this.RegisterLoginBtn.Size = new System.Drawing.Size(136, 47);
            this.RegisterLoginBtn.TabIndex = 7;
            this.RegisterLoginBtn.Text = "Login";
            this.RegisterLoginBtn.UseVisualStyleBackColor = false;
            this.RegisterLoginBtn.Click += new System.EventHandler(this.RegisterLoginBtn_Click);
            // 
            // RegisterLoginLable
            // 
            this.RegisterLoginLable.AutoSize = true;
            this.RegisterLoginLable.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterLoginLable.Location = new System.Drawing.Point(72, 389);
            this.RegisterLoginLable.Name = "RegisterLoginLable";
            this.RegisterLoginLable.Size = new System.Drawing.Size(177, 22);
            this.RegisterLoginLable.TabIndex = 1;
            this.RegisterLoginLable.Text = "Login Your Account";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(712, 534);
            this.Controls.Add(this.RegisterShowPasswordCheckBox);
            this.Controls.Add(this.RegisterAccountBtn);
            this.Controls.Add(this.RegisterPasswordValueTextBox);
            this.Controls.Add(this.RegisterPasswordLable);
            this.Controls.Add(this.RegisterUsernameValueTextBox);
            this.Controls.Add(this.RegisterUsernameLable);
            this.Controls.Add(this.RegisterAccountLable);
            this.Controls.Add(this.РегистерCloseLable);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox RegisterShowPasswordCheckBox;
        private System.Windows.Forms.Button RegisterAccountBtn;
        private System.Windows.Forms.TextBox RegisterPasswordValueTextBox;
        private System.Windows.Forms.Label RegisterPasswordLable;
        private System.Windows.Forms.TextBox RegisterUsernameValueTextBox;
        private System.Windows.Forms.Label RegisterUsernameLable;
        private System.Windows.Forms.Label RegisterAccountLable;
        private System.Windows.Forms.Label РегистерCloseLable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox RegisterPictureBox;
        private System.Windows.Forms.Label RegisterEMSLable;
        private System.Windows.Forms.Button RegisterLoginBtn;
        private System.Windows.Forms.Label RegisterLoginLable;
    }
}