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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace GymManagementSystem
{
    public partial class TrainerManagementForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Documents\\GymManagement.mdf;Integrated Security=True;Connect Timeout=30");
        public TrainerManagementForm()
        {
            InitializeComponent();
        }

        private void TrainerManagementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewTrainerForm addNewTrainerForm = new AddNewTrainerForm();
            addNewTrainerForm.Show();
            this.Hide();
        }

        private void TrainerManagementForm_Load(object sender, EventArgs e)
        {
            // read all the trainer data
            fetchTrainerData("FormLoad");
        }

        // fetch the trainer data
        private void fetchTrainerData(string methodName)
        {
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
                    dataGridView1.DataSource = dataTable;

                    if (methodName == "FormLoad")
                    {
                        // Add columns to the DataGridView            
                        DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                        editButtonColumn.Text = "Edit";
                        editButtonColumn.UseColumnTextForButtonValue = true;
                        // Set the button column's cell style to have a green background color
                        editButtonColumn.DefaultCellStyle.BackColor = Color.Green;
                        dataGridView1.Columns.Add(editButtonColumn);

                        DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                        deleteButtonColumn.Text = "Delete";
                        deleteButtonColumn.UseColumnTextForButtonValue = true;
                        deleteButtonColumn.DefaultCellStyle.BackColor = Color.Red;
                        dataGridView1.Columns.Add(deleteButtonColumn);
                    }

                }

            }

            catch (Exception ex)

            {

                MessageBox.Show("Error: " + ex.Message);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                // edit case
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                string trainer_name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string address = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                string phone_number = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

                EditTrainerForm editTrainerForm = new EditTrainerForm(id, trainer_name, address, phone_number);
                editTrainerForm.Show();
                this.Hide();
            }
            else if (e.ColumnIndex == 5)
            {
                //delete case
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                Delete_Trainer(id);
            }
        }

        // delete trainer method
        private void Delete_Trainer(int id)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete this trainer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                conn.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM Trainers WHERE Trainer_ID=@trainerID", conn);

                cmd.Parameters.AddWithValue("@trainerID", id);

                cmd.ExecuteNonQuery();

                conn.Close();

                DialogResult dialogResult = MessageBox.Show("Trainer Deleted!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    fetchTrainerData("Delete_Trainer");
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Trainers WHERE Trainer_Name LIKE '%' +@search+ '%' ", conn);
                    cmd.Parameters.AddWithValue("@search", txtSearch.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    conn.Close();
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
        }
    }
}
