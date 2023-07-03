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
    public partial class UserChangePasswordForm : Form
    {
        public int userID;
        public string oldPassword;
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Documents\\GymManagement.mdf;Integrated Security=True;Connect Timeout=30");
        public UserChangePasswordForm()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            UserSettingForm userSettingForm = new UserSettingForm();
            userSettingForm.Show();
            this.Hide();
        }

        private void UserChangePasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void UserChangePasswordForm_Load(object sender, EventArgs e)
        {
            // hide all the error messages
            txtOldPasswordErr.Hide();
            txtNewPasswordErr.Hide();
            txtConfirmPasswordErr.Hide();

            // get and set the user id to the global property
            int userID = LoginClass.UserID;
            this.userID = userID;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.Text == "")
            {
                // old password null case
                txtOldPasswordErr.Text = "Old Password cannot be empty.";
                txtOldPasswordErr.Show();
            }
            if (txtNewPassword.Text == "")
            {
                // new password null case
                txtNewPasswordErr.Text = "New Password cannot be empty.";
                txtNewPasswordErr.Show();
            }
            if (txtConfirmPassword.Text == "")
            {
                // confirm password null case
                txtConfirmPasswordErr.Text = "Confirm Password cannot be empty.";
                txtConfirmPasswordErr.Show();
            }

            // if validation fine
            if (txtOldPassword.Text != "" && txtNewPassword.Text != "" && txtConfirmPassword.Text != "")
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Password FROM Users WHERE User_ID=@userID", conn);
                    cmd.Parameters.AddWithValue("@userID", this.userID);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    conn.Close();
                    if (dataTable.Rows.Count > 0)
                    {
                        string oldPassword = dataTable.Rows[0]["Password"].ToString();
                        this.oldPassword = oldPassword;
                    }
                    // check if the old password that user enters is the same as the password in the database
                    if (txtOldPassword.Text == this.oldPassword)
                    {
                        // MessageBox.Show("Yep your password is the same!");

                        //  check if the new password and confirm password that user enters are the same
                        if (txtNewPassword.Text == txtConfirmPassword.Text)
                        {
                            //MessageBox.Show("Nice! New Password and Confirm Password are the same!");
                            // change password  case
                            try
                            {
                                conn.Open();
                                SqlCommand sql = new SqlCommand("UPDATE Users SET Password=@confirmPassword WHERE User_ID=@userID", conn);
                                sql.Parameters.AddWithValue("@confirmPassword", txtConfirmPassword.Text);
                                sql.Parameters.AddWithValue("@userID", this.userID);
                                sql.ExecuteNonQuery();
                                conn.Close();
                                DialogResult result = MessageBox.Show("Password Changed!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (result == DialogResult.OK)
                                {
                                    UserSettingForm userSettingForm = new UserSettingForm();
                                    userSettingForm.Show();
                                    this.Hide();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("New Password and Confirm Password must be the same.Try again...");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Your password is not correct. try again!");
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
