using System.Data;
using System.Data.SqlClient;
namespace GymManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // if user name is empty
            if (txtUserName.Text == "")
            {
                txtUserNameErr.Text = "User Name cannot be empty";
                txtUserNameErr.Show();
            }

            // if password is empty
            if (txtPassword.Text == "")
            {
                txtPasswordErr.Text = "Password cannot be empty";
                txtPasswordErr.Show();
            }

            // if all conditions are correct
            if (txtUserName.Text != "" && txtPassword.Text != "")
            {
                try
                {
                    // sql connection
                    SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Documents\\GymManagement.mdf;Integrated Security=True;Connect Timeout=30");

                    // open the connection
                    conn.Open();

                    // login command (query) to be executed
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE User_Name=@user_name AND Password=@password", conn);

                    // add the parameter
                    cmd.Parameters.AddWithValue("@user_name", txtUserName.Text);

                    // add the parameter
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                    // data adapter is the bridge between data table and user
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    // the selected rows are stored in the data table
                    DataTable dataTable = new DataTable();

                    // fill to the adapter
                    adapter.Fill(dataTable);

                    // if data table has rows greater than 0
                    if (dataTable.Rows.Count > 0)
                    {
                        int userID = Convert.ToInt32(dataTable.Rows[0]["User_ID"]);
                        LoginClass.UserID = userID;
                        string role = Convert.ToString(dataTable.Rows[0]["Role"]);

                        //test the authenticated user is admin or not
                        if (role == "admin")
                        {
                            MainMenuForm mainMenuForm = new MainMenuForm();
                            mainMenuForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            HomeForm homeForm = new HomeForm();
                            homeForm.Show();
                            this.Hide();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Login Fail!", "Warning Status!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // close the connection
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // during the form load, hide all the erorr messages
            txtUserNameErr.Hide();
            txtPasswordErr.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // set the password char to default when user clicks edit profile
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*'; // set password char to *
            }
        }
    }
}