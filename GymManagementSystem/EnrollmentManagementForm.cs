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
        public EnrollmentManagementForm()
        {
            InitializeComponent();
        }

        private void EnrollmentManagementForm_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Documents\\GymManagement.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand cmd = new SqlCommand("SELECT Members.Name AS Member_Name, Members.Join_Date AS Subscription_Date, Classes.Title AS Class_Title, Classes.Start_Date AS Class_Start_Date, Classes.End_Date AS Class_End_Date, Trainers.Trainer_Name FROM Enrollments INNER JOIN Members ON Enrollments.Member_ID = Members.Member_ID INNER JOIN Classes ON Enrollments.Class_ID = Classes.Class_ID INNER JOIN Trainers ON Enrollments.Trainer_ID = Trainers.Trainer_ID", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dataTable;
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
    }
}
