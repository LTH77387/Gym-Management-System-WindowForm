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
    public partial class EditUserForm : Form
    {
        public int userID;
        public string userName, password, role;
        public EditUserForm(int userID, string userName, string password, string role)
        {
            InitializeComponent();
            this.userID = userID;
            this.userName = userName;
            this.password = password;
            this.role = role;
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            // hide all the error messages during form load
            txtUserNameErr.Hide();
            txtPasswordErr.Hide();
            txtRoleErr.Hide();

            // set all the initialized data into the text inputs
            txtUserName.Text = this.userName;
            txtPassword.Text = this.password;
            txtRole.Text = this.role;
        }

        private void EditUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserManagementForm userManagementForm = new UserManagementForm();
            userManagementForm.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserNameErr.Text = "User Name cannot be empty.";
                txtUserNameErr.Show();
            }
            if (txtPassword.Text == "")
            {
                txtPasswordErr.Text = "Password cannot be empty.";
                txtPasswordErr.Show();
            }
            if (txtRole.Text == "")
            {
                txtRoleErr.Text = "Role cannot be empty.";
                txtRoleErr.Show();
            }
            if (txtUserName.Text != "" && txtPassword.Text != "" && txtRole.Text != "")
            {
                try
                {
                    SqlConnection sqlConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Documents\\GymManagement.mdf;Integrated Security=True;Connect Timeout=30");
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Users SET User_Name=@user_name, Password=@password, Role=@role WHERE User_ID=@useriD", sqlConnection);
                    cmd.Parameters.AddWithValue("@user_name", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@role", txtRole.Text);
                    cmd.Parameters.AddWithValue("@userID", this.userID);
                    cmd.ExecuteNonQuery();
                    sqlConnection.Close();
                    DialogResult result = MessageBox.Show("User Updated!", "Success: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        UserManagementForm userManagementForm = new UserManagementForm();
                        userManagementForm.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
