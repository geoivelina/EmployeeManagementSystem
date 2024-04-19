using System.Collections.Generic;
using System.Data;
using System;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    public class SalaryData
    {
        public string EmployeeId { get; set; } //0
        public string FullName { get; set; } //1
        public string Gender { get; set; } //2
        public string PhoneNumber { get; set; } //3
        public string Postion { get; set; } //4
        public int Salary { get; set; } //5

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\EmployeeManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");

        public List<SalaryData> SalaryEmployeeListData()
        {
            List<SalaryData> employeeData = new List<SalaryData>();

            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();

                    string slectData = "SELECT * FROM Employees WHERE status = 'Active' AND delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(slectData, connection))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            SalaryData data = new SalaryData();
                            data.EmployeeId = reader["employee_id"].ToString();
                            data.FullName = reader["full_name"].ToString();
                            data.Gender = reader["gender"].ToString();
                            data.PhoneNumber = reader["phone_number"].ToString();
                            data.Postion = reader["position"].ToString();
                            data.Salary = (int)reader["salary"];

                            employeeData.Add(data);

                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error:" + ex);
                }
                finally { connection.Close(); }
            }
            return employeeData;
        }
    }
}
