using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }



        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // during the form load, hide all the error messages
            txtuserNameErr.Hide();
            txtPasswordErr.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // if user name input field is null
            if (txtUserName.Text == "")
            {
                txtuserNameErr.Text = "User Name cannot be empty.";
                txtuserNameErr.Show();
            }

            // if password is null
            if (txtPassword.Text == "")
            {
                txtPasswordErr.Text = "Password cannot be empty.";
                txtPasswordErr.Show();
            }

            //both conditions correct then register
            if (txtUserName.Text != "" && txtPassword.Text != "")
            {
                try
                {
                    //connect to sql
                    SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Documents\\GymManagement.mdf;Integrated Security=True;Connect Timeout=30");

                    //open the connection
                    conn.Open();

                    //sql command to be executed
                    SqlCommand cmd = new SqlCommand("INSERT INTO Users (User_Name,Password) VALUES (@user_name,@password)", conn);

                    // add with parameters
                    cmd.Parameters.AddWithValue("@user_name", txtUserName.Text);

                    // add with parameters
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                    // execute non query
                    cmd.ExecuteNonQuery();

                    // close the connection
                    conn.Close();

                    DialogResult result = MessageBox.Show("Registration Success!", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // if yes is chosen then redirect to the home form
                    if (result == DialogResult.OK)
                    {
                        LoginForm loginForm = new LoginForm();
                        loginForm.Show();
                        this.Hide();
                    }
                }

                catch (Exception ex)

                {

                    MessageBox.Show("Error: " + ex.Message);

                }
            }
        }
    }
}
