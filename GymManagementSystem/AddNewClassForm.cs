using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class AddNewClassForm : Form
    {
        public int selectedTrainerID;
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Documents\\GymManagement.mdf;Integrated Security=True;Connect Timeout=30");
        public AddNewClassForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClassManagementForm classManagementForm = new ClassManagementForm();
            classManagementForm.Show();
            this.Hide();
        }

        private void AddNewClassForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void AddNewClassForm_Load(object sender, EventArgs e)
        {
            // hide all the error messsages
            chooseTrainerErr.Hide();
            txtTitleErr.Hide();
            txtCategoryErr.Hide();
            txtVenueErr.Hide();
            txtNumberOfSessionsErr.Hide();
            startDateErr.Hide();
            endDateErr.Hide();

            // fetch trainer data into combo box
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Trainers", conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                conn.Close();

                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string trainer_name = Convert.ToString(row["Trainer_Name"]);
                        cboTrainer.Items.Add(trainer_name);
                    }
                }





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // validation
            if(cboTrainer.Text == "")
            {
                chooseTrainerErr.Text = "Please choose trainer name.";
                chooseTrainerErr.Show();
            }
            if(txtTitle.Text == "")
            {
                txtTitleErr.Text = "Title cannot be empty.";
                txtTitleErr.Show();
            }
            if(txtCategory.Text == "")
            {
                txtCategoryErr.Text = "Category cannot be empty.";
                txtCategoryErr.Show();
            }
            if(txtVenue.Text == "")
            {
                txtVenueErr.Text = "Venue cannot be empty.";
                txtVenueErr.Show();
            }
            if(txtNumberOfSessions.Text == "")
            {
                txtNumberOfSessionsErr.Text = "Number of sessions cannot be empty.";
                txtNumberOfSessionsErr.Show();
            }
            if(dtpStartDate.Text == "")
            {
                startDateErr.Text = "Start Date cannot be empty.";
                startDateErr.Show();
            }
            if(dtpEndDate.Text == "")
            {
                endDateErr.Text = "End Date cannot be empty.";
                endDateErr.Show();
            }

            // if validation fine
            // search and fetch the trainer id respective to the trainer name selected
            if(cboTrainer.Text != "" && txtTitle.Text != "" && txtCategory.Text != "" && txtVenue.Text != "" && txtNumberOfSessions.Text != "" && dtpStartDate.Text != "" && dtpEndDate.Text != "")
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Trainer_ID FROM Trainers WHERE Trainer_Name=@trainer_name", conn);
                    cmd.Parameters.AddWithValue("@trainer_name", cboTrainer.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    conn.Close();
                    if (dataTable.Rows.Count > 0)
                    {
                        this.selectedTrainerID = Convert.ToInt32(dataTable.Rows[0]["Trainer_ID"]);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                // inert into classes db case
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Classes (Trainer_ID,Title,Category,Venue,Number_of_Sessions,Start_Date,End_Date) VALUES (@trainerID,@title,@category,@venue,@number_of_sessions,@start_date,@end_date)",conn);
                    cmd.Parameters.AddWithValue("@trainerID", this.selectedTrainerID);
                    cmd.Parameters.AddWithValue("@title",txtTitle.Text);
                    cmd.Parameters.AddWithValue("@category", txtCategory.Text);
                    cmd.Parameters.AddWithValue("@venue",txtVenue.Text);
                    cmd.Parameters.AddWithValue("@number_of_sessions",txtNumberOfSessions.Text);
                    cmd.Parameters.AddWithValue("@start_date", dtpStartDate.Value);
                    cmd.Parameters.AddWithValue("@end_date",dtpEndDate.Value);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    DialogResult result = MessageBox.Show("Class Created!", "Success Message!", MessageBoxButtons.OK,MessageBoxIcon.Information);

                    // press ok and clear all the form input fields
                    if (result == DialogResult.OK)
                    {
                        cboTrainer.SelectedIndex = -1;
                        txtTitle.Text = string.Empty;
                        txtCategory.Text = string.Empty;
                        txtVenue.Text = string.Empty;
                        txtNumberOfSessions.Text = string.Empty;
                        dtpStartDate.Value = DateTime.Now; // default by current date
                        dtpEndDate.Value = DateTime.Now;
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
