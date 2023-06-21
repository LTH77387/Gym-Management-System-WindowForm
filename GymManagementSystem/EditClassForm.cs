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
    public partial class EditClassForm : Form
    {
        public int classID, trainerID;
        public string title, category, venue, number_of_sessions, start_date, end_date;
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Documents\\GymManagement.mdf;Integrated Security=True;Connect Timeout=30");
        public EditClassForm(int classID, int trainerID, string title, string category, string venue, string number_of_sessions, string start_date, string end_date)
        {
            InitializeComponent();
            this.classID = classID;
            this.trainerID = trainerID;
            this.title = title;
            this.category = category;
            this.venue = venue;
            this.number_of_sessions = number_of_sessions;
            this.start_date = start_date;
            this.end_date = end_date;
        }

        private void EditClassForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClassManagementForm classManagementForm = new ClassManagementForm();
            classManagementForm.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cboTrainer.Text == "")
            {
                chooseTrainerErr.Text = "Please choose trainer name.";
                chooseTrainerErr.Show();
            }
            if (txtTitle.Text == "")
            {
                txtTitleErr.Text = "Title cannot be empty.";
                txtTitleErr.Show();
            }
            if (txtCategory.Text == "")
            {
                txtCategoryErr.Text = "Category cannot be empty.";
                txtCategoryErr.Show();
            }
            if (txtVenue.Text == "")
            {
                txtVenueErr.Text = "Venue cannot be empty.";
                txtVenueErr.Show();
            }
            if (txtNumberOfSessions.Text == "")
            {
                txtNumberOfSessionsErr.Text = "Number of sessions cannot be empty.";
                txtNumberOfSessionsErr.Show();
            }
            //if (dtpStartDate.Text == "")
            //{
            //    startDateErr.Text = "Start Date cannot be empty.";
            //    startDateErr.Show();
            //}
            //if (dtpEndDate.Text == "")
            //{
            //    endDateErr.Text = "End Date cannot be empty.";
            //    endDateErr.Show();
            //}


            // update class data 
            try
            {
                if (cboTrainer.Text != "" && txtTitle.Text != "" && txtCategory.Text != "" && txtVenue.Text != "" && txtNumberOfSessions.Text != "")
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Classes SET Trainer_ID=@trainerID, Title=@title, Category=@category, Venue=@venue, Number_of_Sessions=@number_of_sessions, Start_Date=@start_date, End_Date=@end_date WHERE Class_ID=@classID", conn);
                    cmd.Parameters.AddWithValue("@classID", this.classID);
                    cmd.Parameters.AddWithValue("@trainerID", this.trainerID);
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@category", txtCategory.Text);
                    cmd.Parameters.AddWithValue("@venue", txtVenue.Text);
                    cmd.Parameters.AddWithValue("@number_of_sessions", txtNumberOfSessions.Text);
                    cmd.Parameters.AddWithValue("@start_date", dtpStartDate.Value);
                    cmd.Parameters.AddWithValue("@end_date", dtpEndDate.Value);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    DialogResult result = MessageBox.Show("Class Updated!", "Success: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        ClassManagementForm classManagementForm = new ClassManagementForm();
                        classManagementForm.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditClassForm_Load(object sender, EventArgs e)
        {
            // hide all the error messsages
            chooseTrainerErr.Hide();
            txtTitleErr.Hide();
            txtCategoryErr.Hide();
            txtVenueErr.Hide();
            txtNumberOfSessionsErr.Hide();
            startDateErr.Hide();
            endDateErr.Hide();

            // initialize the fields
            txtTitle.Text = this.title;
            txtCategory.Text = this.category;
            txtVenue.Text = this.venue;
            txtNumberOfSessions.Text = this.number_of_sessions;
            dtpStartDate.Value = DateTime.Parse(this.start_date);
            dtpEndDate.Value = DateTime.Parse(this.end_date);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Trainer_ID, Trainer_Name FROM Trainers ", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // if there is the same id data then place the trainer name at the top of combo box
                        if (this.trainerID == Convert.ToInt32(row["Trainer_ID"]))
                        {
                            cboTrainer.Text = row["Trainer_Name"].ToString();
                        }
                        // then add the other trainer names
                        cboTrainer.Items.Add(row["Trainer_Name"]);
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
