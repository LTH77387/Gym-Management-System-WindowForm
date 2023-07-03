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
                SqlCommand cmd = new SqlCommand("SELECT Classes.Class_ID, Trainers.Trainer_ID, Classes.Title, Classes.Category, Classes.Venue, Classes.Number_of_Sessions, Classes.Start_Date, Classes.End_Date, Trainers.Trainer_Name, Trainers.Phone_Number FROM Classes LEFT JOIN Trainers ON Classes.Trainer_ID=Trainers.Trainer_ID", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                conn.Close();
                if (dataTable.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dataTable;

                    // Hide the "Class_ID" and "Trainer_ID" columns
                    dataGridView1.Columns["Class_ID"].Visible = false;
                    dataGridView1.Columns["Trainer_ID"].Visible = false;

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
            if (e.ColumnIndex == 10)
            {
                try
                {
                    // the user who want to enroll must be a member of our gym
                    int userID = LoginClass.UserID; // get the user id first
                    this.userID = userID;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Members WHERE User_ID=@userID", conn);
                    cmd.Parameters.AddWithValue("@userID", this.userID);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    conn.Close();
                  
                    if (dataTable.Rows.Count > 0)
                    {
                        int memberID = Convert.ToInt32(dataTable.Rows[0]["Member_ID"]);
                        // the user is already a member
                        // MessageBox.Show("u are a member of our gym.");
                        try
                        {
                            DialogResult result = MessageBox.Show("Do you want to enroll this class?", "Information!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            if (result == DialogResult.OK)
                            {
                                int classID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                                int trainerID = Convert.ToInt32((dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()));
                                conn.Open();
                                SqlCommand sql = new SqlCommand("INSERT INTO Enrollments (Member_ID,Class_ID,Trainer_ID) VALUES (@memberID,@classID,@trainerID)", conn);
                                sql.Parameters.AddWithValue("@memberID", memberID);
                                sql.Parameters.AddWithValue("@classID", classID);
                                sql.Parameters.AddWithValue("@trainerID", trainerID);
                                sql.ExecuteNonQuery();
                                MessageBox.Show("You are enrolled!", "Success Message!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        // not a member case
                        // MessageBox.Show("U are not our member.");
                        MemberRegistrationForm memberRegistrationForm = new MemberRegistrationForm(this.userID);
                        memberRegistrationForm.Show();
                        this.Hide();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

          
            }
        }
    }
}
