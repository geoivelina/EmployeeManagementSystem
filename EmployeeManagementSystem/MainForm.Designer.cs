namespace EmployeeManagementSystem
{
    partial class MainForm
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
            this.MainPageTitlePanel = new System.Windows.Forms.Panel();
            this.MainCloseLable = new System.Windows.Forms.Label();
            this.EMSLabel = new System.Windows.Forms.Label();
            this.MainPageMenuPanel = new System.Windows.Forms.Panel();
            this.GreetinfUserLable = new System.Windows.Forms.Label();
            this.SignOutLable = new System.Windows.Forms.Label();
            this.MainPageCeterPanel = new System.Windows.Forms.Panel();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.SalaryBtn = new System.Windows.Forms.Button();
            this.AddEmployeeBtn = new System.Windows.Forms.Button();
            this.DashboardBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.salary1 = new EmployeeManagementSystem.Salary();
            this.addEmployee1 = new EmployeeManagementSystem.AddEmployee();
            this.dashboard1 = new EmployeeManagementSystem.Dashboard();
            this.MainPageTitlePanel.SuspendLayout();
            this.MainPageMenuPanel.SuspendLayout();
            this.MainPageCeterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPageTitlePanel
            // 
            this.MainPageTitlePanel.BackColor = System.Drawing.Color.CadetBlue;
            this.MainPageTitlePanel.Controls.Add(this.EMSLabel);
            this.MainPageTitlePanel.Controls.Add(this.MainCloseLable);
            this.MainPageTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPageTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.MainPageTitlePanel.Name = "MainPageTitlePanel";
            this.MainPageTitlePanel.Size = new System.Drawing.Size(1100, 35);
            this.MainPageTitlePanel.TabIndex = 0;
            // 
            // MainCloseLable
            // 
            this.MainCloseLable.AutoSize = true;
            this.MainCloseLable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainCloseLable.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainCloseLable.Location = new System.Drawing.Point(1068, 9);
            this.MainCloseLable.Name = "MainCloseLable";
            this.MainCloseLable.Size = new System.Drawing.Size(20, 21);
            this.MainCloseLable.TabIndex = 0;
            this.MainCloseLable.Text = "X";
            this.MainCloseLable.Click += new System.EventHandler(this.MainCloseLable_Click);
            // 
            // EMSLabel
            // 
            this.EMSLabel.AutoSize = true;
            this.EMSLabel.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMSLabel.Location = new System.Drawing.Point(3, 5);
            this.EMSLabel.Name = "EMSLabel";
            this.EMSLabel.Size = new System.Drawing.Size(294, 25);
            this.EMSLabel.TabIndex = 1;
            this.EMSLabel.Text = "Employee Management System";
            // 
            // MainPageMenuPanel
            // 
            this.MainPageMenuPanel.BackColor = System.Drawing.Color.CadetBlue;
            this.MainPageMenuPanel.Controls.Add(this.SignOutLable);
            this.MainPageMenuPanel.Controls.Add(this.LogoutBtn);
            this.MainPageMenuPanel.Controls.Add(this.SalaryBtn);
            this.MainPageMenuPanel.Controls.Add(this.AddEmployeeBtn);
            this.MainPageMenuPanel.Controls.Add(this.DashboardBtn);
            this.MainPageMenuPanel.Controls.Add(this.GreetinfUserLable);
            this.MainPageMenuPanel.Controls.Add(this.pictureBox1);
            this.MainPageMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainPageMenuPanel.Location = new System.Drawing.Point(0, 35);
            this.MainPageMenuPanel.Name = "MainPageMenuPanel";
            this.MainPageMenuPanel.Size = new System.Drawing.Size(297, 565);
            this.MainPageMenuPanel.TabIndex = 2;
            // 
            // GreetinfUserLable
            // 
            this.GreetinfUserLable.AutoSize = true;
            this.GreetinfUserLable.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreetinfUserLable.Location = new System.Drawing.Point(64, 195);
            this.GreetinfUserLable.Name = "GreetinfUserLable";
            this.GreetinfUserLable.Size = new System.Drawing.Size(149, 25);
            this.GreetinfUserLable.TabIndex = 1;
            this.GreetinfUserLable.Text = "Welcome, User";
            // 
            // SignOutLable
            // 
            this.SignOutLable.AutoSize = true;
            this.SignOutLable.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOutLable.ForeColor = System.Drawing.Color.Black;
            this.SignOutLable.Location = new System.Drawing.Point(73, 526);
            this.SignOutLable.Name = "SignOutLable";
            this.SignOutLable.Size = new System.Drawing.Size(81, 22);
            this.SignOutLable.TabIndex = 6;
            this.SignOutLable.Text = "Sign Out";
            // 
            // MainPageCeterPanel
            // 
            this.MainPageCeterPanel.Controls.Add(this.dashboard1);
            this.MainPageCeterPanel.Controls.Add(this.addEmployee1);
            this.MainPageCeterPanel.Controls.Add(this.salary1);
            this.MainPageCeterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPageCeterPanel.Location = new System.Drawing.Point(297, 35);
            this.MainPageCeterPanel.Name = "MainPageCeterPanel";
            this.MainPageCeterPanel.Size = new System.Drawing.Size(803, 565);
            this.MainPageCeterPanel.TabIndex = 3;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutBtn.FlatAppearance.BorderSize = 0;
            this.LogoutBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.LogoutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.LogoutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.ForeColor = System.Drawing.Color.White;
            this.LogoutBtn.Image = global::EmployeeManagementSystem.Properties.Resources.logout;
            this.LogoutBtn.Location = new System.Drawing.Point(32, 522);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(35, 35);
            this.LogoutBtn.TabIndex = 5;
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // SalaryBtn
            // 
            this.SalaryBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.SalaryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalaryBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.SalaryBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.SalaryBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.SalaryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalaryBtn.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaryBtn.Image = global::EmployeeManagementSystem.Properties.Resources.salary;
            this.SalaryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalaryBtn.Location = new System.Drawing.Point(12, 333);
            this.SalaryBtn.Name = "SalaryBtn";
            this.SalaryBtn.Size = new System.Drawing.Size(257, 43);
            this.SalaryBtn.TabIndex = 4;
            this.SalaryBtn.Text = "SALARY";
            this.SalaryBtn.UseVisualStyleBackColor = false;
            this.SalaryBtn.Click += new System.EventHandler(this.SalaryBtn_Click);
            // 
            // AddEmployeeBtn
            // 
            this.AddEmployeeBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.AddEmployeeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddEmployeeBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.AddEmployeeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.AddEmployeeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.AddEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployeeBtn.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeeBtn.Image = global::EmployeeManagementSystem.Properties.Resources.employee;
            this.AddEmployeeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddEmployeeBtn.Location = new System.Drawing.Point(12, 284);
            this.AddEmployeeBtn.Name = "AddEmployeeBtn";
            this.AddEmployeeBtn.Size = new System.Drawing.Size(257, 43);
            this.AddEmployeeBtn.TabIndex = 3;
            this.AddEmployeeBtn.Text = "ADD EMPLOYEE";
            this.AddEmployeeBtn.UseVisualStyleBackColor = false;
            this.AddEmployeeBtn.Click += new System.EventHandler(this.AddEmployeeBtn_Click);
            // 
            // DashboardBtn
            // 
            this.DashboardBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.DashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashboardBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.DashboardBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.DashboardBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.DashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardBtn.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardBtn.Image = global::EmployeeManagementSystem.Properties.Resources.dashboard;
            this.DashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardBtn.Location = new System.Drawing.Point(12, 235);
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.Size = new System.Drawing.Size(257, 43);
            this.DashboardBtn.TabIndex = 2;
            this.DashboardBtn.Text = "DASHBOARD";
            this.DashboardBtn.UseVisualStyleBackColor = false;
            this.DashboardBtn.Click += new System.EventHandler(this.DashboardBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EmployeeManagementSystem.Properties.Resources.employeeCard1;
            this.pictureBox1.Location = new System.Drawing.Point(65, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 172);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // salary1
            // 
            this.salary1.Location = new System.Drawing.Point(0, -2);
            this.salary1.Name = "salary1";
            this.salary1.Size = new System.Drawing.Size(803, 565);
            this.salary1.TabIndex = 0;
            // 
            // addEmployee1
            // 
            this.addEmployee1.Location = new System.Drawing.Point(3, 3);
            this.addEmployee1.Name = "addEmployee1";
            this.addEmployee1.Size = new System.Drawing.Size(803, 565);
            this.addEmployee1.TabIndex = 1;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(0, -2);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(803, 565);
            this.dashboard1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.MainPageCeterPanel);
            this.Controls.Add(this.MainPageMenuPanel);
            this.Controls.Add(this.MainPageTitlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.MainPageTitlePanel.ResumeLayout(false);
            this.MainPageTitlePanel.PerformLayout();
            this.MainPageMenuPanel.ResumeLayout(false);
            this.MainPageMenuPanel.PerformLayout();
            this.MainPageCeterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPageTitlePanel;
        private System.Windows.Forms.Label MainCloseLable;
        private System.Windows.Forms.Label EMSLabel;
        private System.Windows.Forms.Panel MainPageMenuPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label GreetinfUserLable;
        private System.Windows.Forms.Button SalaryBtn;
        private System.Windows.Forms.Button AddEmployeeBtn;
        private System.Windows.Forms.Button DashboardBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Label SignOutLable;
        private System.Windows.Forms.Panel MainPageCeterPanel;
        private Dashboard dashboard1;
        private AddEmployee addEmployee1;
        private Salary salary1;
    }
}