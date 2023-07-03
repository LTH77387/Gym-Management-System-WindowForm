using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class HomeForm : Form
    {
        public bool clickViewClass = false;
        public bool clickViewTrainer = false;
        public bool rowAdded = false;
        public int userID, memberID;
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Documents\\GymManagement.mdf;Integrated Security=True;Connect Timeout=30");
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            // hide some necessary items for user experience(UX)
            dataGridView1.Hide();
            txtSearch.Hide();
            btnEnroll.Visible = false;
            btnSearch.Visible = false;

            // auto focus on Home tab
            linkLabel1_LinkClicked(linkLabel1, new LinkLabelLinkClickedEventArgs(linkLabel1.Links[0])); // Simulate click event
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkClass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                clickViewClass = true; // if user clicks view classes and then search so that the data from the class will be fetched
                clickViewTrainer = false;
                txtSearch.Show();
                btnSearch.Visible = true;
                btnEnroll.Visible = true;
                dataGridView1.Hide();
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Title, Category, Venue, Number_of_Sessions, Start_Date, End_Date FROM Classes", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                conn.Close();
                if (dataTable.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.Hide();
            clickViewClass = false;
            clickViewTrainer = false;
            txtSearch.Text = string.Empty;
            txtSearch.Hide();
            btnSearch.Visible = false;
            btnEnroll.Visible = false;
        }

        private void linkTrainer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                clickViewTrainer = true;

                clickViewClass = false;

                txtSearch.Show();

                btnSearch.Visible = true;

                dataGridView1.Hide();

                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT Trainer_Name, Address, Phone_Number FROM Trainers", conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                conn.Close();

                if (dataTable.Rows.Count > 0)
                {
                    if (clickViewTrainer && !clickViewClass)
                    {
                        dataGridView1.DataSource = dataTable;
                        dataGridView1.Show();
                    }
                }

            }

            catch (Exception ex)

            {

                MessageBox.Show("Error: " + ex.Message);

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {

            }
            else
            {
                if (clickViewClass)
                {
                    try
                    {
                        // search from classes table
                        //MessageBox.Show("U can search from Classes table.");
                        dataGridView1.Hide();
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("SELECT * FROM Classes WHERE Title LIKE '%' + @SearchTerm + '%' OR Category LIKE '%' + @SearchTerm + '%'", conn);
                        cmd.Parameters.AddWithValue("@SearchTerm", txtSearch.Text);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        if (dataTable.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dataTable;
                            dataGridView1.Show();
                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (clickViewTrainer)
                {
                    try
                    {
                        // search from trainers table
                        //MessageBox.Show("U can search from Trainers table.");
                        dataGridView1.Hide();
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("SELECT * FROM Trainers WHERE Trainer_Name LIKE '%' + @SearchTerm + '%' ", conn);
                        cmd.Parameters.AddWithValue("@SearchTerm", txtSearch.Text);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        conn.Close();
                        if (dataTable.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dataTable;
                            dataGridView1.Show();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

        }

        private void linkSetting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserSettingForm userSettingForm = new UserSettingForm();
            userSettingForm.Show();
            this.Hide();
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            UserEnrollmentForm userEnrollmentForm = new UserEnrollmentForm();
            userEnrollmentForm.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // get the login user id first
                this.userID = LoginClass.UserID;

                // check that user id exists in Members table or not
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Member_ID FROM Members WHERE Members.User_ID=@userID", conn);
                cmd.Parameters.AddWithValue("@userID", this.userID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                conn.Close();
                if (dataTable.Rows.Count > 0)
                {
                    // the current user is the member of the gym so that he can access the enrollment history
                    this.memberID = Convert.ToInt32(dataTable.Rows[0]["Member_ID"]);
                    conn.Open();
                    SqlCommand sql = new SqlCommand("SELECT Classes.Title AS Class_Title, Classes.Category, Classes.Start_Date, Classes.End_Date, Members.Name AS Member_Name, Trainers.Trainer_Name, Trainers.Phone_Number AS Trainer_Phone_Number FROM Enrollments INNER JOIN Classes ON Enrollments.Class_ID=Classes.Class_ID INNER JOIN Members ON Enrollments.Member_ID=Members.Member_ID INNER JOIN Trainers ON Enrollments.Trainer_ID=Trainers.Trainer_ID WHERE Enrollments.Member_ID=@memberID", conn);
                    sql.Parameters.AddWithValue("@memberID", this.memberID);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql);
                    DataTable dataTable2 = new DataTable();
                    sqlDataAdapter.Fill(dataTable2);
                    conn.Close();
                    if (dataTable2.Rows.Count > 0)
                    {
                        dataGridView1.Hide();
                        dataGridView1.DataSource = dataTable2;
                        dataGridView1.Show();
                    }
                    else
                    {
                        MessageBox.Show("No enrollments found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Not a Member. Register first.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
