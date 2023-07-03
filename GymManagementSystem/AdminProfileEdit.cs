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
    public partial class AdminProfileEdit : Form
    {
        public int userID;
        // sql connection
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Documents\\GymManagement.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminProfileEdit()
        {
            InitializeComponent();
        }

        private void AdminProfileEdit_Load(object sender, EventArgs e)
        {
            // hide all the error messages
            txtUserNameErr.Hide();
            txtPasswordErr.Hide();
            try
            {
                int userID = LoginClass.UserID;
                this.userID = userID;
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE User_ID=@user_id", conn);
                cmd.Parameters.AddWithValue("@user_id", this.userID);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                conn.Close();
                if (dataTable.Rows.Count > 0)
                {
                    txtUserName.Text = dataTable.Rows[0]["User_Name"].ToString();
                    txtPassword.Text = dataTable.Rows[0]["Password"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AdminProfileEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserNameErr.Text = "User name cannot be empty.";
                txtUserNameErr.Show();
            }
            if (txtPassword.Text == "")
            {
                txtPasswordErr.Text = "Password cannot be empty.";
                txtPasswordErr.Show();
            }
            if (txtUserName.Text != "" && txtPassword.Text != "")
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
                    MainMenuForm mainMenuForm = new MainMenuForm();
                    mainMenuForm.Show();
                    this.Hide();
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Hide();
        }
    }
}
