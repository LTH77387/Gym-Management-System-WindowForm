namespace GymManagementSystem
{
    partial class UserManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagementForm));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnSearch = new FontAwesome.Sharp.IconButton();
            txtSearch = new TextBox();
            label2 = new Label();
            rdbAdmin = new RadioButton();
            rdbUser = new RadioButton();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1885, 641);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(755, 38);
            label1.Name = "label1";
            label1.Size = new Size(294, 40);
            label1.TabIndex = 9;
            label1.Text = "User Management";
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(16, 41);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(100, 44);
            iconButton1.TabIndex = 90;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LightSlateGray;
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnSearch.IconColor = Color.Black;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.Location = new Point(1695, 41);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 47);
            btnSearch.TabIndex = 94;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1472, 51);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 27);
            txtSearch.TabIndex = 93;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(1152, 52);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 97;
            label2.Text = "Sort By: ";
            // 
            // rdbAdmin
            // 
            rdbAdmin.AutoSize = true;
            rdbAdmin.Location = new Point(1272, 51);
            rdbAdmin.Name = "rdbAdmin";
            rdbAdmin.Size = new Size(72, 24);
            rdbAdmin.TabIndex = 98;
            rdbAdmin.TabStop = true;
            rdbAdmin.Text = "admin";
            rdbAdmin.UseVisualStyleBackColor = true;
            rdbAdmin.CheckedChanged += rdbAdmin_CheckedChanged;
            // 
            // rdbUser
            // 
            rdbUser.AutoSize = true;
            rdbUser.Location = new Point(1377, 52);
            rdbUser.Name = "rdbUser";
            rdbUser.Size = new Size(57, 24);
            rdbUser.TabIndex = 99;
            rdbUser.TabStop = true;
            rdbUser.Text = "user";
            rdbUser.UseVisualStyleBackColor = true;
            rdbUser.CheckedChanged += rdbUser_CheckedChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LightSlateGray;
            btnRefresh.Location = new Point(1801, 42);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 44);
            btnRefresh.TabIndex = 100;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // UserManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(btnRefresh);
            Controls.Add(rdbUser);
            Controls.Add(rdbAdmin);
            Controls.Add(label2);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(iconButton1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserManagementForm";
            Text = "UserManagementForm";
            FormClosed += UserManagementForm_FormClosed;
            Load += UserManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnSearch;
        private TextBox txtSearch;
        private Label label2;
        private RadioButton rdbAdmin;
        private RadioButton rdbUser;
        private Button btnRefresh;
    }
}