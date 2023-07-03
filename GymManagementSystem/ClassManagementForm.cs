using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;

namespace GymManagementSystem
{
    public partial class ClassManagementForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Documents\\GymManagement.mdf;Integrated Security=True;Connect Timeout=30");
        public ClassManagementForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewClassForm addNewClassForm = new AddNewClassForm();
            addNewClassForm.Show();
            this.Hide();
        }

        private void ClassManagementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Hide();
        }

        private void ClassManagementForm_Load(object sender, EventArgs e)
        {
            fetchClassData("FormLoad");
        }

        // select classes data
        private void fetchClassData(string methodName)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Classes", conn);
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
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                // edit case
                try
                {
                    int classID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    int trainerID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    string title = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string category = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string venue = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    string number_of_sessions = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    string start_date = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                    string end_date = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

                    // call the edit form and pass all the arguments 
                    EditClassForm editClassForm = new EditClassForm(classID, trainerID, title, category, venue, number_of_sessions, start_date, end_date);
                    editClassForm.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (e.ColumnIndex == 9)
            {
                // delete case
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                Class_Delete(id);
            }
        }

        // delete method
        private void Class_Delete(int id)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete this class?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM Classes WHERE Class_ID=@classID", conn);

                    cmd.Parameters.AddWithValue("@classID", id);

                    cmd.ExecuteNonQuery();

                    conn.Close();
                    DialogResult dialogResult = MessageBox.Show("Class Deleted!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.OK)
                    {
                        fetchClassData("Delete_Class");  // call the fetch method again in order to update the view data
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Classes WHERE Title LIKE '%' +@search+ '%' OR Category LIKE '%' +@search+ '%' ", conn);
                    cmd.Parameters.AddWithValue("@search", txtSearch.Text);
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
        }
    }
}
