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
    public partial class UserSettingForm : Form
    {
        public int userID;
        // sql connection
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Documents\\GymManagement.mdf;Integrated Security=True;Connect Timeout=30");
        public UserSettingForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }

        private void UserSettingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void UserSettingForm_Load(object sender, EventArgs e)
        {
            try
            {
                txtUserNameErr.Hide();
                txtPasswordErr.Hide();
                btnUpdate.Visible = false;
                int userID = LoginClass.UserID; // get user id from the global class
                this.userID = userID; // assign the id to the global property
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE User_ID=@userID", conn);
                cmd.Parameters.AddWithValue("@userID", userID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                conn.Close();
                if (dataTable.Rows.Count > 0)
                {
                    txtUserName.Text = dataTable.Rows[0]["User_Name"].ToString();
                    txtPassword.PasswordChar = '*';
                    txtPassword.Text = dataTable.Rows[0]["Password"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtUserName.ReadOnly = false;
            txtPassword.ReadOnly = false;
            btnUpdate.Visible = true;

            // set the password char to default when user clicks edit profile
            txtPassword.PasswordChar = '\0';
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserNameErr.Text = "Please fill out this field.";
                txtUserNameErr.Show();
            }
            if (txtPassword.Text == "")
            {
                txtPasswordErr.Text = "Please fill out this field.";
                txtPasswordErr.Show();
            }

            // if validation fine
            if (txtUserName.Text != "" && txtPassword.Text != "")
            {
                // update case
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Users SET User_Name=@user_name, Password=@password WHERE User_ID=@userID", conn);
                    cmd.Parameters.AddWithValue("@user_name", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@userID", this.userID);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    DialogResult result = MessageBox.Show("Profile Updated!", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        HomeForm homeForm = new HomeForm();
                        homeForm.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to logout?", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        private void linkSetting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserChangePasswordForm userChangeForm = new UserChangePasswordForm();
            userChangeForm.Show();
            this.Hide();
        }
    }
}
