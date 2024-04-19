using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class RegisterForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\EmployeeManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void РегистерCloseLable_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegisterLoginBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void RegisterShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            RegisterPasswordValueTextBox.PasswordChar =RegisterShowPasswordCheckBox.Checked ? '\0' : '*';
           
        }

        private void RegisterAccountBtn_Click(object sender, EventArgs e)
        {
            if (RegisterUsernameValueTextBox.Text == "" || RegisterPasswordValueTextBox.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error Meassage", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        //Check if the user exists
                        string selectedUserName = "SELECT COUNT (id) FROM Users WHERE username = @user";

                        using (SqlCommand checkUser = new SqlCommand(selectedUserName, connect))
                        {
                            checkUser.Parameters.AddWithValue("@user", RegisterUsernameValueTextBox.Text.Trim());
                            int count =(int)checkUser.ExecuteScalar();
                            if (count >= 1)
                            {
                                MessageBox.Show(RegisterUsernameValueTextBox.Text .Trim() + " alredy taken", "Error Meassage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime registerDate = DateTime.Today;

                                string insertData = "INSERT INTO Users (username, password, date_register) VALUES(@username, @password, @dateReg)";
                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", RegisterUsernameValueTextBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", RegisterPasswordValueTextBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateReg", registerDate);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Successfuly registerd!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    LoginForm loginFOrm = new LoginForm();
                                    loginFOrm.Show();
                                    this.Hide();
                                }
                        }
                       
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex, "Error Meassage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();     
                }
                }
            }
        }
    }
}
