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
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            linkLabel2 = new LinkLabel();
            dataGridView1 = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new FontAwesome.Sharp.IconButton();
            btnEnroll = new Button();
            pictureBox2 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(711, 9);
            label1.Name = "label1";
            label1.Size = new Size(598, 70);
            label1.TabIndex = 0;
            label1.Text = "Welcome to our Gym!";
            // 
            // linkSetting
            // 
            linkSetting.AutoSize = true;
            linkSetting.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkSetting.Location = new Point(93, 496);
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
            linkTrainer.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            linkTrainer.Location = new Point(82, 287);
            linkTrainer.Name = "linkTrainer";
            linkTrainer.Size = new Size(109, 20);
            linkTrainer.TabIndex = 2;
            linkTrainer.TabStop = true;
            linkTrainer.Text = "View Trainers";
            linkTrainer.LinkClicked += linkTrainer_LinkClicked;
            // 
            // linkClass
            // 
            linkClass.AutoSize = true;
            linkClass.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            linkClass.Location = new Point(82, 196);
            linkClass.Name = "linkClass";
            linkClass.Size = new Size(101, 20);
            linkClass.TabIndex = 1;
            linkClass.TabStop = true;
            linkClass.Text = "View Classes";
            linkClass.LinkClicked += linkClass_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(93, 107);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(62, 23);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Home";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox6);
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(linkLabel2);
            groupBox1.Controls.Add(linkTrainer);
            groupBox1.Controls.Add(linkSetting);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(linkClass);
            groupBox1.Location = new Point(75, 234);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.No;
            groupBox1.Size = new Size(211, 572);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(12, 476);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(64, 66);
            pictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox6.TabIndex = 9;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 363);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(64, 66);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 268);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(64, 66);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 173);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(64, 66);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.home1;
            pictureBox1.Location = new Point(12, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.Location = new Point(82, 389);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(129, 17);
            linkLabel2.TabIndex = 4;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Enrollment History";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(308, 271);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.ShowCellErrors = false;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.ShowRowErrors = false;
            dataGridView1.Size = new Size(1475, 535);
            dataGridView1.TabIndex = 5;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1500, 228);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(150, 27);
            txtSearch.TabIndex = 32;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LightSlateGray;
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnSearch.IconColor = Color.Black;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.Location = new Point(1683, 218);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 47);
            btnSearch.TabIndex = 33;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnEnroll
            // 
            btnEnroll.BackColor = Color.LightSlateGray;
            btnEnroll.Location = new Point(308, 221);
            btnEnroll.Name = "btnEnroll";
            btnEnroll.Size = new Size(100, 44);
            btnEnroll.TabIndex = 34;
            btnEnroll.Text = "Enroll Now !";
            btnEnroll.UseVisualStyleBackColor = false;
            btnEnroll.Click += btnEnroll_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.SwiftGym036_sr;
            pictureBox2.Location = new Point(1, -8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1920, 1030);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
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
            Controls.Add(pictureBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HomeForm";
            Text = "HomeForm";
            FormClosed += HomeForm_FormClosed;
            Load += HomeForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
    }
}