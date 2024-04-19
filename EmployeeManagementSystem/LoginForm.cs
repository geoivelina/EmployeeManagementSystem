using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class LoginForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\EmployeeManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
        public LoginForm()
        {
            InitializeComponent();
        }

        private void CloseLable_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginRegisterBtn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (LoginUsernameLable.Text == ""
                 || LoginPasswordValueTextBox.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error Meassage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {

                
                try
                {
                    connect.Open();

                        string selectData = "SELECT * FROM Users WHERE username = @username AND password =@password";
                        
                        using(SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", LoginUsernameValueTextBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", LoginPasswordValueTextBox.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count>=1)
                            {
                                MessageBox.Show("You successfully loged in!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                MainForm mainFOrm = new MainForm();
                                mainFOrm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username or Password!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void LoginShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoginPasswordValueTextBox.PasswordChar = LoginShowPasswordCheckBox.Checked ? '\0' : '*'; 
        }
    }
}
