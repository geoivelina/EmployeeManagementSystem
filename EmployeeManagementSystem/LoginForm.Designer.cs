namespace EmployeeManagementSystem
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoginRegisterPictureBox = new System.Windows.Forms.PictureBox();
            this.LoginEMSLable = new System.Windows.Forms.Label();
            this.LoginRegisterBtn = new System.Windows.Forms.Button();
            this.LoginRegisterLable = new System.Windows.Forms.Label();
            this.LoginLable = new System.Windows.Forms.Label();
            this.LoginCloseLable = new System.Windows.Forms.Label();
            this.LoginUsernameLable = new System.Windows.Forms.Label();
            this.LoginUsernameValueTextBox = new System.Windows.Forms.TextBox();
            this.LoginPasswordValueTextBox = new System.Windows.Forms.TextBox();
            this.LoginPasswordLable = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.LoginShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginRegisterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LoginRegisterPictureBox);
            this.panel1.Controls.Add(this.LoginEMSLable);
            this.panel1.Controls.Add(this.LoginRegisterBtn);
            this.panel1.Controls.Add(this.LoginRegisterLable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 534);
            this.panel1.TabIndex = 0;
            // 
            // LoginRegisterPictureBox
            // 
            this.LoginRegisterPictureBox.Image = global::EmployeeManagementSystem.Properties.Resources.employeeCard;
            this.LoginRegisterPictureBox.Location = new System.Drawing.Point(91, 147);
            this.LoginRegisterPictureBox.Name = "LoginRegisterPictureBox";
            this.LoginRegisterPictureBox.Size = new System.Drawing.Size(148, 172);
            this.LoginRegisterPictureBox.TabIndex = 9;
            this.LoginRegisterPictureBox.TabStop = false;
            // 
            // LoginEMSLable
            // 
            this.LoginEMSLable.AutoSize = true;
            this.LoginEMSLable.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginEMSLable.Location = new System.Drawing.Point(11, 74);
            this.LoginEMSLable.Name = "LoginEMSLable";
            this.LoginEMSLable.Size = new System.Drawing.Size(294, 25);
            this.LoginEMSLable.TabIndex = 8;
            this.LoginEMSLable.Text = "Employee Management System";
            // 
            // LoginRegisterBtn
            // 
            this.LoginRegisterBtn.BackColor = System.Drawing.Color.White;
            this.LoginRegisterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginRegisterBtn.FlatAppearance.BorderSize = 0;
            this.LoginRegisterBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.LoginRegisterBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.LoginRegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginRegisterBtn.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginRegisterBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LoginRegisterBtn.Location = new System.Drawing.Point(103, 446);
            this.LoginRegisterBtn.Name = "LoginRegisterBtn";
            this.LoginRegisterBtn.Size = new System.Drawing.Size(136, 47);
            this.LoginRegisterBtn.TabIndex = 7;
            this.LoginRegisterBtn.Text = "Register";
            this.LoginRegisterBtn.UseVisualStyleBackColor = false;
            this.LoginRegisterBtn.Click += new System.EventHandler(this.LoginRegisterBtn_Click);
            // 
            // LoginRegisterLable
            // 
            this.LoginRegisterLable.AutoSize = true;
            this.LoginRegisterLable.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginRegisterLable.Location = new System.Drawing.Point(72, 389);
            this.LoginRegisterLable.Name = "LoginRegisterLable";
            this.LoginRegisterLable.Size = new System.Drawing.Size(194, 22);
            this.LoginRegisterLable.TabIndex = 1;
            this.LoginRegisterLable.Text = "Register Your Account";
            // 
            // LoginLable
            // 
            this.LoginLable.AutoSize = true;
            this.LoginLable.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLable.Location = new System.Drawing.Point(435, 59);
            this.LoginLable.Name = "LoginLable";
            this.LoginLable.Size = new System.Drawing.Size(192, 31);
            this.LoginLable.TabIndex = 0;
            this.LoginLable.Text = "Login Account";
            // 
            // LoginCloseLable
            // 
            this.LoginCloseLable.AutoSize = true;
            this.LoginCloseLable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginCloseLable.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginCloseLable.Location = new System.Drawing.Point(679, 7);
            this.LoginCloseLable.Name = "LoginCloseLable";
            this.LoginCloseLable.Size = new System.Drawing.Size(22, 24);
            this.LoginCloseLable.TabIndex = 1;
            this.LoginCloseLable.Text = "X";
            this.LoginCloseLable.Click += new System.EventHandler(this.CloseLable_Click);
            // 
            // LoginUsernameLable
            // 
            this.LoginUsernameLable.AutoSize = true;
            this.LoginUsernameLable.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginUsernameLable.Location = new System.Drawing.Point(414, 136);
            this.LoginUsernameLable.Name = "LoginUsernameLable";
            this.LoginUsernameLable.Size = new System.Drawing.Size(95, 22);
            this.LoginUsernameLable.TabIndex = 2;
            this.LoginUsernameLable.Text = "Username:";
            // 
            // LoginUsernameValueTextBox
            // 
            this.LoginUsernameValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginUsernameValueTextBox.Location = new System.Drawing.Point(414, 164);
            this.LoginUsernameValueTextBox.Name = "LoginUsernameValueTextBox";
            this.LoginUsernameValueTextBox.Size = new System.Drawing.Size(226, 30);
            this.LoginUsernameValueTextBox.TabIndex = 3;
            // 
            // LoginPasswordValueTextBox
            // 
            this.LoginPasswordValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginPasswordValueTextBox.Location = new System.Drawing.Point(414, 244);
            this.LoginPasswordValueTextBox.Name = "LoginPasswordValueTextBox";
            this.LoginPasswordValueTextBox.PasswordChar = '*';
            this.LoginPasswordValueTextBox.Size = new System.Drawing.Size(226, 30);
            this.LoginPasswordValueTextBox.TabIndex = 5;
            // 
            // LoginPasswordLable
            // 
            this.LoginPasswordLable.AutoSize = true;
            this.LoginPasswordLable.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPasswordLable.Location = new System.Drawing.Point(414, 216);
            this.LoginPasswordLable.Name = "LoginPasswordLable";
            this.LoginPasswordLable.Size = new System.Drawing.Size(91, 22);
            this.LoginPasswordLable.TabIndex = 4;
            this.LoginPasswordLable.Text = "Password:";
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.FlatAppearance.BorderSize = 0;
            this.LoginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.LoginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LoginBtn.Location = new System.Drawing.Point(468, 365);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(112, 47);
            this.LoginBtn.TabIndex = 6;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // LoginShowPasswordCheckBox
            // 
            this.LoginShowPasswordCheckBox.AutoSize = true;
            this.LoginShowPasswordCheckBox.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginShowPasswordCheckBox.Location = new System.Drawing.Point(532, 289);
            this.LoginShowPasswordCheckBox.Name = "LoginShowPasswordCheckBox";
            this.LoginShowPasswordCheckBox.Size = new System.Drawing.Size(108, 19);
            this.LoginShowPasswordCheckBox.TabIndex = 7;
            this.LoginShowPasswordCheckBox.Text = "Show password";
            this.LoginShowPasswordCheckBox.UseVisualStyleBackColor = true;
            this.LoginShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.LoginShowPasswordCheckBox_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(712, 534);
            this.Controls.Add(this.LoginShowPasswordCheckBox);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.LoginPasswordValueTextBox);
            this.Controls.Add(this.LoginPasswordLable);
            this.Controls.Add(this.LoginUsernameValueTextBox);
            this.Controls.Add(this.LoginUsernameLable);
            this.Controls.Add(this.LoginLable);
            this.Controls.Add(this.LoginCloseLable);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginRegisterPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LoginLable;
        private System.Windows.Forms.Label LoginCloseLable;
        private System.Windows.Forms.Label LoginUsernameLable;
        private System.Windows.Forms.TextBox LoginUsernameValueTextBox;
        private System.Windows.Forms.TextBox LoginPasswordValueTextBox;
        private System.Windows.Forms.Label LoginPasswordLable;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.CheckBox LoginShowPasswordCheckBox;
        private System.Windows.Forms.Button LoginRegisterBtn;
        private System.Windows.Forms.Label LoginRegisterLable;
        private System.Windows.Forms.PictureBox LoginRegisterPictureBox;
        private System.Windows.Forms.Label LoginEMSLable;
    }
}

