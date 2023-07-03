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
    public partial class EnrollmentManagementForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Documents\\GymManagement.mdf;Integrated Security=True;Connect Timeout=30");
        public EnrollmentManagementForm()
        {
            InitializeComponent();
        }

        private void EnrollmentManagementForm_Load(object sender, EventArgs e)
        {
            fetchEnrollmentData("FormLoad");
        }

        // fetch all the enrollment data
        private void fetchEnrollmentData(string methodName)
        {
            try
            {
                //if(methodName== "DeleteForm")
                //{
                //    dataGridView1.Rows.Clear();
                //}
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Enrollment_ID, Members.Name AS Member_Name, Members.Join_Date AS Subscription_Date, Classes.Title AS Class_Title, Classes.Start_Date AS Class_Start_Date, Classes.End_Date AS Class_End_Date, Trainers.Trainer_Name FROM Enrollments INNER JOIN Members ON Enrollments.Member_ID = Members.Member_ID INNER JOIN Classes ON Enrollments.Class_ID = Classes.Class_ID INNER JOIN Trainers ON Enrollments.Trainer_ID = Trainers.Trainer_ID", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                conn.Close();
                if (dataTable.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dataTable;
                    if (methodName == "FormLoad")
                    {
                        // Add columns to the DataGridView
                        DataGridViewButtonColumn deletetButtonColumn = new DataGridViewButtonColumn();
                        deletetButtonColumn.Text = "Delete";
                        deletetButtonColumn.UseColumnTextForButtonValue = true;
                        deletetButtonColumn.DefaultCellStyle.BackColor = Color.Red;
                        dataGridView1.Columns.Add(deletetButtonColumn);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EnrollmentManagementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Hide();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                // delete case
                int enrollmentID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                Delete_Enrollment(enrollmentID);
            }
        }
        private void Delete_Enrollment(int enrollmentID)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you want to delete?", "Alert!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Enrollments WHERE Enrollment_ID=@enrollmentID", conn);
                    cmd.Parameters.AddWithValue("@enrollmentID", enrollmentID);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    DialogResult result1 = MessageBox.Show("Enrollment deleted!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result1 == DialogResult.OK)
                    {
                        fetchEnrollmentData("DeleteForm");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
