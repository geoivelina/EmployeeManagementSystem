using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class Salary : UserControl
    {

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\EmployeeManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
        public Salary()
        {
            InitializeComponent();
            DisplayEmployees();
            DisableFields();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }

            DisplayEmployees();
            DisableFields();
        }

        public void DisableFields()
        {
            SalaryEmployeeIDTextBox.Enabled = false;
            SalaryFullNameLableTextBox.Enabled = false;
            SalaryPositionTextBox.Enabled = false;
        }

        public void DisplayEmployees()
        {
            SalaryData employeeData = new SalaryData();
            List<SalaryData> list = employeeData.SalaryEmployeeListData();
            SalaryEmployeesDataPreview.DataSource = list;
        }

        private void SalaryUpdateBtn_Click(object sender, EventArgs e)
        {
            if (SalaryEmployeeIDTextBox.Text == ""
                || SalaryFullNameLableTextBox.Text == ""
                || SalaryPositionTextBox.Text == ""
                || SalarySalaryTextBox.Text == "")
            {
                MessageBox.Show("All fields are required", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to update Employee ID: " + SalaryEmployeeIDTextBox.Text.Trim() + "?","Configuration Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    if (connection.State == System.Data.ConnectionState.Closed)
                    {
                        try
                        {
                            connection.Open();
                            DateTime today = DateTime.Today;

                            string updateData = "UPDATE Employees SET salary = @Salary, update_date = @UpdateDate WHERE employee_id = @EmployeeId";

                            using (SqlCommand cmd = new SqlCommand(updateData, connection))
                            {
                                cmd.Parameters.AddWithValue("@Salary", SalarySalaryTextBox.Text.Trim());
                                cmd.Parameters.AddWithValue("@UpdateDate", today);
                                cmd.Parameters.AddWithValue("@EmployeeId", SalaryEmployeeIDTextBox.Text.Trim());

                                cmd.ExecuteNonQuery();

                                DisplayEmployees();
                                MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                ClearFields();
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

       public void ClearFields()
        {
            SalaryEmployeeIDTextBox.Text = "";
            SalaryFullNameLableTextBox.Text = "";
            SalaryPositionTextBox.Text = "";
            SalarySalaryTextBox.Text = "";
        }

        private void SalaryEmployeesDataPreview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = SalaryEmployeesDataPreview.Rows[e.RowIndex];

                SalaryEmployeeIDTextBox.Text = row.Cells[0].Value.ToString();
                SalaryFullNameLableTextBox.Text = row.Cells[1].Value.ToString();
                SalaryPositionTextBox.Text = row.Cells[4].Value.ToString();
                SalarySalaryTextBox.Text = row.Cells[5].Value.ToString();
            }
        }

        private void SalaryClearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
