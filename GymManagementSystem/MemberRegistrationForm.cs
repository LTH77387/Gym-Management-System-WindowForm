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
    public partial class MemberRegistrationForm : Form
    {
        public int userID;
        public double heightInCentimeters;
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Documents\\GymManagement.mdf;Integrated Security=True;Connect Timeout=30");
        public MemberRegistrationForm(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void MemberRegistrationForm_Load(object sender, EventArgs e)
        {
            // hide all the error messages
            txtNameErr.Hide();
            txtEmailErr.Hide();
            txtAddressErr.Hide();
            txtWeightErr.Hide();
            txtHeightErr.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MemberRegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            UserEnrollmentForm userEnrollmentForm = new UserEnrollmentForm();
            userEnrollmentForm.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // validation
            if (txtName.Text == "")
            {
                txtNameErr.Text = "Name cannot be empty.";
                txtNameErr.Show();
            }
            if (txtEmail.Text == "")
            {
                txtEmailErr.Text = "Email cannot be empty.";
                txtEmailErr.Show();
            }
            if (txtAddress.Text == "")
            {
                txtAddressErr.Text = "Address cannot be empty.";
                txtAddressErr.Show();
            }
            if (txtWeight.Text == "")
            {
                txtWeightErr.Text = "Weight cannot be empty.";
                txtWeightErr.Show();
            }
            if (txtHeightInFt.Text == "" && txtHeightInInch.Text == "")
            {
                txtHeightErr.Text = "Height cannot be empty.";
                txtHeightErr.Show();
            }

            // if validation is fine
            if (txtName.Text != "" && txtEmail.Text != "" && txtAddress.Text != "" && txtWeight.Text != "" && txtHeightInFt.Text != "" || txtHeightInInch.Text != "")
            {
                try
                {
                    // calculate weight from lb to kg
                    double weightInPounds = Convert.ToDouble(txtWeight.Text);
                    double weightInKilograms = Math.Round(weightInPounds * 0.45359237, 2);



                    // if height in inches is not null
                    if (txtHeightInInch.Text != "") // inch shi tae case
                    {
                        // calculate height from ft & inches to cm
                        int heightInFeet = Convert.ToInt32(txtHeightInFt.Text);
                        int heightInInches = Convert.ToInt32(txtHeightInInch.Text);
                        // Convert feet and inches to centimeters
                        double totalInches = (heightInFeet * 12) + heightInInches;
                        double heightInCentimeters = totalInches * 2.54;
                        this.heightInCentimeters = heightInCentimeters;
                    }
                    else
                    {
                        // if no inches input
                        int heightInFeet = Convert.ToInt32(txtHeightInFt.Text);
                        double heightInCentimeters = heightInFeet * 30.48;
                        this.heightInCentimeters = heightInCentimeters;
                    }


                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Members (User_ID,Name,Email,Address,Weight,Height) VALUES (@userID,@name,@email,@address,@weight,@height)", conn);
                    cmd.Parameters.AddWithValue("@userID", this.userID);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@weight", weightInKilograms);
                    cmd.Parameters.AddWithValue("@height", heightInCentimeters);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    DialogResult result = MessageBox.Show("Member Registration Success!", "Succes Message!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        // empty all the text boxes
                        txtName.Text = string.Empty;
                        txtEmail.Text = string.Empty;
                        txtAddress.Text = string.Empty;
                        txtWeight.Text = string.Empty;
                        txtHeightInFt.Text = string.Empty;
                        txtHeightInInch.Text = string.Empty;

                        UserEnrollmentForm userEnrollmentForm = new UserEnrollmentForm();
                        userEnrollmentForm.Show();
                        this.Hide();
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
