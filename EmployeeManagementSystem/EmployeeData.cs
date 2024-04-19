using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    public class EmployeeData
    {
        public int ID { get; set; }
        public string EmployeeId { get; set; } // 1
        public string FullName { get; set; } // 2
        public string Gender { get; set; } // 3
        public string PhoneNumber { get; set; } // 4
        public string Postion { get; set; } // 5
        public string Image { get; set; } // 6
        public string Status { get; set; } // 7 

        public int Salary { get; set; } // 8

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\EmployeeManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");




        public List<EmployeeData> EmployeeListData()
        {
            List<EmployeeData> employeeData = new List<EmployeeData>();

            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();

                    string slectData = "SELECT * FROM Employees WHERE delete_date IS NULL";

                    using(SqlCommand cmd = new SqlCommand(slectData, connection))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            EmployeeData data = new EmployeeData();
                            data.ID = (int)reader["id"];
                            data.EmployeeId = reader["employee_id"].ToString();
                            data.FullName = reader["full_name"].ToString();
                            data.Gender = reader["gender"].ToString();
                            data.PhoneNumber = reader["phone_number"].ToString();
                            data.Postion = reader["position"].ToString();
                            data.Image = reader["image"].ToString();
                            data.Salary = (int)reader["salary"];
                            data.Status = reader["status"].ToString();

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

        public List<EmployeeData> SalaryEmployeeListData()
        {
            List<EmployeeData> employeeData = new List<EmployeeData>();

            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();

                    string slectData = "SELECT * FROM Employees WHERE delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(slectData, connection))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            EmployeeData data = new EmployeeData();

                            data.EmployeeId = reader["employee_id"].ToString();
                            data.FullName = reader["full_name"].ToString();
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
