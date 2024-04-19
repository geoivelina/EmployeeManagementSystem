using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class AddEmployee : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\EmployeeManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
        public AddEmployee()
        {
            InitializeComponent();
            DisplayEmployeeData();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            DisplayEmployeeData();
        }

        public void DisplayEmployeeData()
        {
            EmployeeData data = new EmployeeData();
            List<EmployeeData> list = data.EmployeeListData();

            EmployeeDataPreview.DataSource = list;
        }
        private void AddEmployeeAddBtn_Click(object sender, EventArgs e)
        {
            if (AddEmployeeIDTextBox.Text == ""
                || AddEmployeeFullNameTextBox.Text == ""
                || AddEmployeeGenderComboBox.Text == ""
                || AddEmployeePositionComboBox.Text == ""
                || AddEmployeePhoneNumberTextBox.Text == ""
                || AddEmployeeStatusComboBox.Text == ""
                || AddEmployeePictureBox.Image == null)
            {
                MessageBox.Show("All fiealds are required", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    try
                    {
                        connection.Open();
                        string checkEmployeeId = "SELECT COUNT(*) FROM Employees WHERE employee_id = @EmplId AND delete_date IS NULL";

                        using (SqlCommand findEmployee = new SqlCommand(checkEmployeeId, connection))
                        {
                            findEmployee.Parameters.AddWithValue("@EmplId", AddEmployeeIDTextBox.Text.Trim());
                            int count = (int)findEmployee.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(AddEmployeeIDTextBox.Text.Trim() + "alredy exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO Employees" +
                                    "(employee_id, full_name, gender,phone_number,position,image, salary, insert_date, status)" + "VALUES(@EmployeeId, @FullName, @Gender, @PhoneNumber, @Postion, @Image, @Salary,  @InsertDate, @Status)";

                                string path = Path.Combine(@"C:\Users\User\source\repos\EmployeeManagementSystem\EmployeeManagementSystem\Directory\" + AddEmployeeIDTextBox.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(AddEmployeePictureBox.ImageLocation, path, true);

                                using (SqlCommand cmd = new SqlCommand(insertData, connection))
                                {
                                    cmd.Parameters.AddWithValue("@EmployeeId", AddEmployeeIDTextBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@FullName", AddEmployeeFullNameTextBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@Gender", AddEmployeeGenderComboBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@PhoneNumber", AddEmployeePhoneNumberTextBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@Postion", AddEmployeePositionComboBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@Image", path);
                                    cmd.Parameters.AddWithValue("@Salary", 0);
                                    cmd.Parameters.AddWithValue("@InsertDate", today);
                                    cmd.Parameters.AddWithValue("@Status", AddEmployeeStatusComboBox.Text.Trim());


                                    cmd.ExecuteNonQuery();
                                    DisplayEmployeeData();
                                    MessageBox.Show("Employee Added Successfuly!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    ClearFields();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {

                    }
                }
            }
        }

        private void AddEmployeeImportPictureBtn_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files(*.jpg; *.png) |*.jpg;*.png";
                string imagePath = "";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    AddEmployeePictureBox.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ClearFields()
        {
            AddEmployeeIDTextBox.Text = "";
            AddEmployeeFullNameTextBox.Text = "";
            AddEmployeeGenderComboBox.SelectedIndex = -1;
            AddEmployeePositionComboBox.SelectedIndex = -1;
            AddEmployeePhoneNumberTextBox.Text = "";
            AddEmployeeStatusComboBox.SelectedIndex = -1;
            AddEmployeePictureBox.Image = null;
        }
        private void AddEmployeeUpdateBtn_Click(object sender, EventArgs e)
        {
            if (AddEmployeeIDTextBox.Text == ""
              || AddEmployeeFullNameTextBox.Text == ""
              || AddEmployeeGenderComboBox.Text == ""
              || AddEmployeePhoneNumberTextBox.Text == ""
              || AddEmployeePositionComboBox.Text == ""
              || AddEmployeeStatusComboBox.Text == ""
              || AddEmployeePictureBox.Image == null)
            {
                MessageBox.Show("All fiealds are required", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to update Employee ID: " + AddEmployeeIDTextBox.Text.Trim() + "?", "Configuration Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connection.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE Employees SET full_name = @FullName, gender = @Gender,phone_number = @PhoneNumber,position = @Postion, update_date = @UpdateData,status = @Status WHERE  employee_id = @EmployeeId";

                        using (SqlCommand cmd = new SqlCommand(updateData, connection))
                        {
                            cmd.Parameters.AddWithValue("@Fullname", AddEmployeeFullNameTextBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@Gender", AddEmployeeGenderComboBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@PhoneNumber", AddEmployeePhoneNumberTextBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@Postion", AddEmployeePositionComboBox.Text.Trim());
                            // cmd.Parameters.AddWithValue("@Image", path);
                            cmd.Parameters.AddWithValue("@UpdateData", today);
                            cmd.Parameters.AddWithValue("@Status", AddEmployeeStatusComboBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@EmployeeId", AddEmployeeIDTextBox.Text.Trim());

                            cmd.ExecuteNonQuery();

                            DisplayEmployeeData();

                            MessageBox.Show("Employee Updated Successfuly!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ClearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Cancelled!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void AddEmployeeClearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void EmployeeDataPreview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                DataGridViewRow row = EmployeeDataPreview.Rows[e.RowIndex];

                AddEmployeeIDTextBox.Text = row.Cells[1].Value.ToString();
                AddEmployeeFullNameTextBox.Text = row.Cells[2].Value.ToString();
                AddEmployeeGenderComboBox.Text = row.Cells[3].Value.ToString();
                AddEmployeePhoneNumberTextBox.Text = row.Cells[4].Value.ToString();
                AddEmployeePositionComboBox.Text = row.Cells[5].Value.ToString();

                string imagePath = row.Cells[6].Value.ToString();

                if (imagePath != null)
                {
                    AddEmployeePictureBox.Image = Image.FromFile(imagePath);
                }
                else
                {
                    AddEmployeePictureBox.Image = null;
                }
                AddEmployeeStatusComboBox.Text = row.Cells[7].Value.ToString();
            }
        }

        private void AddEmployeeDeleteBtn_Click(object sender, EventArgs e)
        {
            if (AddEmployeeIDTextBox.Text == ""
                         || AddEmployeeFullNameTextBox.Text == ""
                         || AddEmployeeGenderComboBox.Text == ""
                         || AddEmployeePhoneNumberTextBox.Text == ""
                         || AddEmployeePositionComboBox.Text == ""
                         || AddEmployeeStatusComboBox.Text == ""
                         || AddEmployeePictureBox.Image == null)
            {
                MessageBox.Show("All fiealds are required", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to delete Employee ID: " + AddEmployeeIDTextBox.Text.Trim() + "?", "Configuration Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connection.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE Employees SET delete_date = @DeleteDate WHERE employee_id = @EmployeeId";

                        using (SqlCommand cmd = new SqlCommand(updateData, connection))
                        {
                           
                            cmd.Parameters.AddWithValue("@DeleteDate", today);
                            cmd.Parameters.AddWithValue("@EmployeeId", AddEmployeeIDTextBox.Text.Trim());

                            cmd.ExecuteNonQuery();

                            DisplayEmployeeData();

                            MessageBox.Show("Employee Deleted Successfuly!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ClearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Cancelled!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
