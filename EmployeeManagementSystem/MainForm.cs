using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainCloseLable_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Conformation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            addEmployee1.Visible = false;
            salary1.Visible = false;

            Dashboard dashForm = dashboard1 as Dashboard;

            if (dashForm != null)
            {
                dashForm.RefreshData();
            }
        }

        private void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addEmployee1.Visible = true;
            salary1.Visible = false;

            AddEmployee addEmplForm = addEmployee1 as AddEmployee;

            if (addEmplForm != null)
            {
                addEmplForm.RefreshData();
            }
        }

        private void SalaryBtn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addEmployee1.Visible = false;
            salary1.Visible = true;

            Salary salaryForm = salary1 as Salary;
            if (salaryForm != null)
            {
                salaryForm.RefreshData();
            }
        }
    }
}
