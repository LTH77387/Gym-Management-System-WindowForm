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
    public partial class EditTrainerForm : Form
    {
        private int id;
        public string trainer_name, address, phone_number;
        public EditTrainerForm(int id, string trainer_name, string address, string phone_number)
        {
            InitializeComponent();
            this.id = id;
            this.trainer_name = trainer_name;
            this.address = address;
            this.phone_number = phone_number;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TrainerManagementForm trainerManagementForm = new TrainerManagementForm();
            trainerManagementForm.Show();
            this.Hide();
        }

        private void EditTrainerForm_Load(object sender, EventArgs e)
        {
            // get the initialized data into the text inputs
            txtTrainerName.Text = this.trainer_name;
            txtAddress.Text = this.address;
            txtPhoneNumber.Text = this.phone_number;

            // hide all the error messages
            txtTrainerNameErr.Hide();
            txtAddressErr.Hide();
            txtPhoneNumberErr.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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

                    SqlCommand sql = new SqlCommand("UPDATE Trainers SET Trainer_Name=@trainer_name, Address=@address, Phone_Number=@phone_number WHERE Trainer_ID=@trainerID", conn);

                    sql.Parameters.AddWithValue("@trainer_name", txtTrainerName.Text);

                    sql.Parameters.AddWithValue("@address", txtAddress.Text);

                    sql.Parameters.AddWithValue("@phone_number", txtPhoneNumber.Text);

                    sql.Parameters.AddWithValue("@trainerID", this.id);

                    sql.ExecuteNonQuery();

                    conn.Close();

                    DialogResult result = MessageBox.Show("Trainer Updated!", "Success: ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (result == DialogResult.OK)

                    {

                        // redirect to the home form is user clicks ok after update case
                        TrainerManagementForm trainerManagementForm = new TrainerManagementForm();
                        trainerManagementForm.Show();
                        this.Hide();
                    }

                }

                catch (Exception err)

                {

                    MessageBox.Show($"{err}", "Unexpected Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void EditTrainerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
