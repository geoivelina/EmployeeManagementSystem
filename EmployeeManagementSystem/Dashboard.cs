using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class Dashboard : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\EmployeeManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");

        public Dashboard()
        {
            InitializeComponent();
            DisplayTotalEmployees();
            DisplayActiveEmployees();
            DisplayInactiveEmployees();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;

            }
            DisplayTotalEmployees();
            DisplayActiveEmployees();
            DisplayInactiveEmployees();
        }

        public void DisplayTotalEmployees()
        {
            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();

                    string selectData = "SELECT COUNT(id) FROM Employees WHERE delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connection))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            DashboardTotalNumberEmployeesLable.Text = count.ToString();

                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { connection.Close(); }
            }
        }

        public void DisplayActiveEmployees()
        {
            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();

                    string selectData = "SELECT COUNT(id) FROM Employees WHERE status =@Status AND delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connection))
                    {
                        cmd.Parameters.AddWithValue("@Status", @"Active");
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            DashboardActiveEmployeesNumberLable.Text = count.ToString();

                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { connection.Close(); }
            }
        }

        public void DisplayInactiveEmployees()
        {
            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();

                    string selectData = "SELECT COUNT(id) FROM Employees WHERE status =@Status AND delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connection))
                    {
                        cmd.Parameters.AddWithValue("@Status", @"Inactive");
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            DashboardInactiveEmployeesNumberLable.Text = count.ToString();

                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { connection.Close(); }
            }
        }
    }
}
