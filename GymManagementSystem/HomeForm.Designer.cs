namespace GymManagementSystem
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            label1 = new Label();
            linkSetting = new LinkLabel();
            linkTrainer = new LinkLabel();
            linkClass = new LinkLabel();
            linkLabel1 = new LinkLabel();
            groupBox1 = new GroupBox();
            linkLabel2 = new LinkLabel();
            dataGridView1 = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new FontAwesome.Sharp.IconButton();
            btnEnroll = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(778, 36);
            label1.Name = "label1";
            label1.Size = new Size(441, 52);
            label1.TabIndex = 0;
            label1.Text = "Welcome to our Gym!";
            // 
            // linkSetting
            // 
            linkSetting.AutoSize = true;
            linkSetting.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkSetting.Location = new Point(63, 485);
            linkSetting.Name = "linkSetting";
            linkSetting.Size = new Size(71, 23);
            linkSetting.TabIndex = 3;
            linkSetting.TabStop = true;
            linkSetting.Text = "Setting";
            linkSetting.LinkClicked += linkSetting_LinkClicked;
            // 
            // linkTrainer
            // 
            linkTrainer.AutoSize = true;
            linkTrainer.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkTrainer.Location = new Point(35, 288);
            linkTrainer.Name = "linkTrainer";
            linkTrainer.Size = new Size(130, 23);
            linkTrainer.TabIndex = 2;
            linkTrainer.TabStop = true;
            linkTrainer.Text = "View Trainers";
            linkTrainer.LinkClicked += linkTrainer_LinkClicked;
            // 
            // linkClass
            // 
            linkClass.AutoSize = true;
            linkClass.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkClass.Location = new Point(35, 183);
            linkClass.Name = "linkClass";
            linkClass.Size = new Size(120, 23);
            linkClass.TabIndex = 1;
            linkClass.TabStop = true;
            linkClass.Text = "View Classes";
            linkClass.LinkClicked += linkClass_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(63, 86);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(62, 23);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Home";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkLabel2);
            groupBox1.Controls.Add(linkTrainer);
            groupBox1.Controls.Add(linkSetting);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(linkClass);
            groupBox1.Location = new Point(75, 234);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.No;
            groupBox1.Size = new Size(194, 572);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.Location = new Point(12, 389);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(176, 23);
            linkLabel2.TabIndex = 4;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Enrollment History";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(348, 320);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.ShowCellErrors = false;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.ShowRowErrors = false;
            dataGridView1.Size = new Size(1475, 486);
            dataGridView1.TabIndex = 5;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1447, 243);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(250, 27);
            txtSearch.TabIndex = 32;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LightSlateGray;
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnSearch.IconColor = Color.Black;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.Location = new Point(1723, 234);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 47);
            btnSearch.TabIndex = 33;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnEnroll
            // 
            btnEnroll.BackColor = Color.LightSlateGray;
            btnEnroll.Location = new Point(348, 243);
            btnEnroll.Name = "btnEnroll";
            btnEnroll.Size = new Size(100, 44);
            btnEnroll.TabIndex = 34;
            btnEnroll.Text = "Enroll Now !";
            btnEnroll.UseVisualStyleBackColor = false;
            btnEnroll.Click += btnEnroll_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(btnEnroll);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HomeForm";
            Text = "HomeForm";
            FormClosed += HomeForm_FormClosed;
            Load += HomeForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel linkSetting;
        private LinkLabel linkTrainer;
        private LinkLabel linkClass;
        private LinkLabel linkLabel1;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnSearch;
        private LinkLabel linkLabel2;
        private Button btnEnroll;
    }
}