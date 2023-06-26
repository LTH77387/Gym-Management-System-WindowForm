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
    }
}
