using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class EditMemberForm : Form
    {
        public int MemberID;
        public string name, email, password, address, joinDate;
        public EditMemberForm(int memberID, string name, string email, string password, string address, string joinDate)
        {
            InitializeComponent();
            this.MemberID = memberID;
            this.name = name;
            this.email = email;
            this.password = password;
            this.address = address;
            this.joinDate = joinDate;
        }

        private void dtpJoinDateErr_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MemberManagementForm memberManagementForm = new MemberManagementForm();
            memberManagementForm.Show();
            this.Hide();
        }

        private void EditMemberForm_Load(object sender, EventArgs e)
        {
            // hide all the error messages
            txtNameErr.Hide();
            txtEmailErr.Hide();
            txtPasswordErr.Hide();
            txtAddressErr.Hide();
            dtpJoinDateErr.Hide();
            // initialize data into each text box
            txtName.Text = this.name;
            txtEmail.Text = this.email;
            txtPassword.Text = this.password;
            txtAddress.Text = this.address;
            dtpJoinDate.Value = DateTime.Parse(this.joinDate);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // validation
            if(txtName.Text == "")
            {
                txtNameErr.Text = "Name cannot be empty.";
                txtNameErr.Show();
            }
            if(txtEmail.Text == "")
            {
                txtEmailErr.Text = "Email cannot be empty.";
                txtEmailErr.Show();
            }
            if( txtPassword.Text == "")
            {
                txtPasswordErr.Text = "Password cannot be empty.";
                txtPasswordErr.Show();
            }
            if(txtAddress.Text == "")
            {
                txtAddressErr.Text = "Address cannot be empty.";
                txtAddressErr.Show();
            }
            if(txtName.Text != "" && txtEmail.Text != "" && txtPassword.Text != "" && txtAddress.Text != "")
            {
                try
                {
                    // run update query for edit member
                    SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Documents\\GymManagement.mdf;Integrated Security=True;Connect Timeout=30");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Members SET Name=@name, Email=@email, Address=@address, Join_Date=@join_date WHERE Member_ID=@memberID", conn);
                    cmd.Parameters.AddWithValue("@memberID", this.MemberID);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@join_date", dtpJoinDate.Value);
                    cmd.ExecuteNonQuery();
                    DialogResult result = MessageBox.Show("Member Updated!", "Success Message!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        MemberManagementForm memberManagementForm = new MemberManagementForm();
                        memberManagementForm.Show();
                        this.Hide();
                    }
                }
                catch(Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
