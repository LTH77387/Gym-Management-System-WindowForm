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
    public partial class UserEnrollmentForm : Form
    {
        public int userID;
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Documents\\GymManagement.mdf;Integrated Security=True;Connect Timeout=30");
        public UserEnrollmentForm()
        {
            InitializeComponent();
        }

        private void UserEnrollmentForm_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Title, Category, Venue, Number_of_Sessions, Start_Date, End_Date FROM Classes", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                conn.Close();
                if (dataTable.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dataTable;
                    // Add columns to the DataGridView
                    DataGridViewButtonColumn enrollButtonColumn = new DataGridViewButtonColumn();
                    enrollButtonColumn.Text = "Enroll Now!";
                    enrollButtonColumn.UseColumnTextForButtonValue = true;
                    enrollButtonColumn.DefaultCellStyle.BackColor = Color.Green;
                    dataGridView1.Columns.Add(enrollButtonColumn);
                    dataGridView1.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UserEnrollmentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 6)
            {
                // the user who want to enroll must be a member of our gym
                int userID = LoginClass.UserID; // get the user id first
                this.userID = userID;
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Member_ID FROM Members WHERE Member_ID=@userID", conn);
                cmd.Parameters.AddWithValue("@userID", this.userID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                conn.Close();

                if(dataTable.Rows.Count > 0)
                {
                    // the user is already a member
                    MessageBox.Show("u are a member of our gym.");
                }
                else
                {
                    MessageBox.Show("U are not our member.");
                }
            }
        }
    }
}
