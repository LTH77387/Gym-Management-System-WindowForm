namespace GymManagementSystem
{
    partial class AddNewClassForm
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
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            chooseTrainerErr = new Label();
            cboTrainer = new ComboBox();
            label11 = new Label();
            endDateErr = new Label();
            startDateErr = new Label();
            txtNumberOfSessionsErr = new Label();
            txtNumberOfSessions = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtVenueErr = new Label();
            txtCategoryErr = new Label();
            txtTitleErr = new Label();
            btnAdd = new Button();
            txtCategory = new TextBox();
            txtTitle = new TextBox();
            txtVenue = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(816, 107);
            label1.Name = "label1";
            label1.Size = new Size(391, 52);
            label1.TabIndex = 13;
            label1.Text = "Add new gym class";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(816, 37);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(198, 20);
            linkLabel1.TabIndex = 24;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back to class management";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(980, 761);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(250, 27);
            dtpEndDate.TabIndex = 48;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(982, 672);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(250, 27);
            dtpStartDate.TabIndex = 47;
            // 
            // chooseTrainerErr
            // 
            chooseTrainerErr.AutoSize = true;
            chooseTrainerErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chooseTrainerErr.ForeColor = Color.Red;
            chooseTrainerErr.Location = new Point(982, 265);
            chooseTrainerErr.Name = "chooseTrainerErr";
            chooseTrainerErr.Size = new Size(52, 17);
            chooseTrainerErr.TabIndex = 46;
            chooseTrainerErr.Text = "label5";
            // 
            // cboTrainer
            // 
            cboTrainer.FormattingEnabled = true;
            cboTrainer.Location = new Point(980, 219);
            cboTrainer.Name = "cboTrainer";
            cboTrainer.Size = new Size(250, 28);
            cboTrainer.TabIndex = 45;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(816, 227);
            label11.Name = "label11";
            label11.Size = new Size(108, 20);
            label11.TabIndex = 44;
            label11.Text = "Choose trainer:";
            // 
            // endDateErr
            // 
            endDateErr.AutoSize = true;
            endDateErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            endDateErr.ForeColor = Color.Red;
            endDateErr.Location = new Point(982, 810);
            endDateErr.Name = "endDateErr";
            endDateErr.Size = new Size(52, 17);
            endDateErr.TabIndex = 43;
            endDateErr.Text = "label7";
            // 
            // startDateErr
            // 
            startDateErr.AutoSize = true;
            startDateErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            startDateErr.ForeColor = Color.Red;
            startDateErr.Location = new Point(982, 712);
            startDateErr.Name = "startDateErr";
            startDateErr.Size = new Size(52, 17);
            startDateErr.TabIndex = 42;
            startDateErr.Text = "label6";
            // 
            // txtNumberOfSessionsErr
            // 
            txtNumberOfSessionsErr.AutoSize = true;
            txtNumberOfSessionsErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumberOfSessionsErr.ForeColor = Color.Red;
            txtNumberOfSessionsErr.Location = new Point(982, 620);
            txtNumberOfSessionsErr.Name = "txtNumberOfSessionsErr";
            txtNumberOfSessionsErr.Size = new Size(52, 17);
            txtNumberOfSessionsErr.TabIndex = 41;
            txtNumberOfSessionsErr.Text = "label5";
            // 
            // txtNumberOfSessions
            // 
            txtNumberOfSessions.Location = new Point(982, 577);
            txtNumberOfSessions.Name = "txtNumberOfSessions";
            txtNumberOfSessions.Size = new Size(250, 27);
            txtNumberOfSessions.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(816, 761);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 39;
            label8.Text = "End Date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(816, 672);
            label9.Name = "label9";
            label9.Size = new Size(76, 20);
            label9.TabIndex = 38;
            label9.Text = "Start Date";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(816, 584);
            label10.Name = "label10";
            label10.Size = new Size(143, 20);
            label10.TabIndex = 37;
            label10.Text = "Number of Sessions:";
            // 
            // txtVenueErr
            // 
            txtVenueErr.AutoSize = true;
            txtVenueErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtVenueErr.ForeColor = Color.Red;
            txtVenueErr.Location = new Point(982, 532);
            txtVenueErr.Name = "txtVenueErr";
            txtVenueErr.Size = new Size(52, 17);
            txtVenueErr.TabIndex = 36;
            txtVenueErr.Text = "label7";
            // 
            // txtCategoryErr
            // 
            txtCategoryErr.AutoSize = true;
            txtCategoryErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtCategoryErr.ForeColor = Color.Red;
            txtCategoryErr.Location = new Point(982, 434);
            txtCategoryErr.Name = "txtCategoryErr";
            txtCategoryErr.Size = new Size(52, 17);
            txtCategoryErr.TabIndex = 35;
            txtCategoryErr.Text = "label6";
            // 
            // txtTitleErr
            // 
            txtTitleErr.AutoSize = true;
            txtTitleErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtTitleErr.ForeColor = Color.Red;
            txtTitleErr.Location = new Point(982, 342);
            txtTitleErr.Name = "txtTitleErr";
            txtTitleErr.Size = new Size(52, 17);
            txtTitleErr.TabIndex = 34;
            txtTitleErr.Text = "label5";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightSlateGray;
            btnAdd.Location = new Point(1130, 853);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 44);
            btnAdd.TabIndex = 33;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(982, 387);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(250, 27);
            txtCategory.TabIndex = 32;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(982, 299);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(250, 27);
            txtTitle.TabIndex = 31;
            // 
            // txtVenue
            // 
            txtVenue.Location = new Point(982, 483);
            txtVenue.Name = "txtVenue";
            txtVenue.Size = new Size(250, 27);
            txtVenue.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(816, 483);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 29;
            label4.Text = "Venue:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(816, 394);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 28;
            label3.Text = "Category:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(816, 306);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 27;
            label2.Text = "Title:";
            // 
            // AddNewClassForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(chooseTrainerErr);
            Controls.Add(cboTrainer);
            Controls.Add(label11);
            Controls.Add(endDateErr);
            Controls.Add(startDateErr);
            Controls.Add(txtNumberOfSessionsErr);
            Controls.Add(txtNumberOfSessions);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(txtVenueErr);
            Controls.Add(txtCategoryErr);
            Controls.Add(txtTitleErr);
            Controls.Add(btnAdd);
            Controls.Add(txtCategory);
            Controls.Add(txtTitle);
            Controls.Add(txtVenue);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Name = "AddNewClassForm";
            Text = "AddNewClassForm";
            FormClosed += AddNewClassForm_FormClosed;
            Load += AddNewClassForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel linkLabel1;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private Label chooseTrainerErr;
        private ComboBox cboTrainer;
        private Label label11;
        private Label endDateErr;
        private Label startDateErr;
        private Label txtNumberOfSessionsErr;
        private TextBox txtNumberOfSessions;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label txtVenueErr;
        private Label txtCategoryErr;
        private Label txtTitleErr;
        private Button btnAdd;
        private TextBox txtCategory;
        private TextBox txtTitle;
        private TextBox txtVenue;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}