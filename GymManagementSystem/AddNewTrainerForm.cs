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
    public partial class AddNewTrainerForm : Form
    {
        public AddNewTrainerForm()
        {
            InitializeComponent();
        }

        private void AddNewTrainerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void AddNewTrainerForm_Load(object sender, EventArgs e)
        {
            // hide all the error messages
            txtTrainerNameErr.Hide();
            txtAddressErr.Hide();
            txtPhoneNumberErr.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TrainerManagementForm trainerManagementForm = new TrainerManagementForm();
            trainerManagementForm.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTrainerName.Text == "")
            {
                txtTrainerNameErr.Text = "Trainer name cannot be empty.";
                txtTrainerNameErr.Show();
            }
            if (txtAddress.Text == "")
            {
                txtAddressErr.Text = "Address cannot be empty.";
                txtAddressErr.Show();
            }
            if (txtPhoneNumber.Text == "")
            {
                txtPhoneNumberErr.Text = "Phone Number cannot be empty.";
                txtPhoneNumberErr.Show();
            }
            if (txtTrainerName.Text != "" && txtAddress.Text != "" && txtPhoneNumber.Text != "")
            {
                try
                {

                    SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Documents\\GymManagement.mdf;Integrated Security=True;Connect Timeout=30");

                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO Trainers (Trainer_Name,Address,Phone_Number) VALUES (@trainer_name,@address,@phone_number)", conn);

                    cmd.Parameters.AddWithValue("@trainer_name", txtTrainerName.Text);

                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);

                    cmd.Parameters.AddWithValue("@phone_number", txtPhoneNumber.Text);

                    cmd.ExecuteNonQuery();

                    conn.Close();

                    DialogResult result = MessageBox.Show("Trainer Added!", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // if ok is clicked, then clear all the inputs in order to avoid violation
                    if (result == DialogResult.OK)
                    {
                        txtTrainerName.Text = string.Empty;
                        txtAddress.Text = string.Empty;
                        txtPhoneNumber.Text = string.Empty;
                    }
                }

                catch (Exception ex)

                {

                    MessageBox.Show("Error: " + ex.Message);

                }
            }
        }
    }
}
