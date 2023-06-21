using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void trainerManagementToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TrainerManagementForm trainerManagementForm = new TrainerManagementForm();
            trainerManagementForm.Show();
            this.Hide();
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManagementForm userManagementForm = new UserManagementForm();
            userManagementForm.Show();
            this.Hide();
        }

        private void gymClassManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassManagementForm classManagementForm = new ClassManagementForm();
            classManagementForm.Show();
            this.Hide();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminProfileEdit adminProfileEdit = new AdminProfileEdit();
            adminProfileEdit.Show();
            this.Hide();
        }
    }
}
