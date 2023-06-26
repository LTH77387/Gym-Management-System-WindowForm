namespace GymManagementSystem
{
    partial class EditMemberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMemberForm));
            txtNameErr = new Label();
            dtpJoinDateErr = new Label();
            label10 = new Label();
            txtAddressErr = new Label();
            txtPasswordErr = new Label();
            txtEmailErr = new Label();
            btnUpdate = new Button();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            label5 = new Label();
            dtpJoinDate = new DateTimePicker();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // txtNameErr
            // 
            txtNameErr.AutoSize = true;
            txtNameErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtNameErr.ForeColor = Color.Red;
            txtNameErr.Location = new Point(990, 306);
            txtNameErr.Name = "txtNameErr";
            txtNameErr.Size = new Size(52, 17);
            txtNameErr.TabIndex = 88;
            txtNameErr.Text = "label5";
            // 
            // dtpJoinDateErr
            // 
            dtpJoinDateErr.AutoSize = true;
            dtpJoinDateErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dtpJoinDateErr.ForeColor = Color.Red;
            dtpJoinDateErr.Location = new Point(990, 661);
            dtpJoinDateErr.Name = "dtpJoinDateErr";
            dtpJoinDateErr.Size = new Size(52, 17);
            dtpJoinDateErr.TabIndex = 85;
            dtpJoinDateErr.Text = "label5";
            dtpJoinDateErr.Click += dtpJoinDateErr_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(824, 625);
            label10.Name = "label10";
            label10.Size = new Size(82, 20);
            label10.TabIndex = 83;
            label10.Text = "Join Date : ";
            // 
            // txtAddressErr
            // 
            txtAddressErr.AutoSize = true;
            txtAddressErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtAddressErr.ForeColor = Color.Red;
            txtAddressErr.Location = new Point(990, 573);
            txtAddressErr.Name = "txtAddressErr";
            txtAddressErr.Size = new Size(52, 17);
            txtAddressErr.TabIndex = 82;
            txtAddressErr.Text = "label7";
            // 
            // txtPasswordErr
            // 
            txtPasswordErr.AutoSize = true;
            txtPasswordErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtPasswordErr.ForeColor = Color.Red;
            txtPasswordErr.Location = new Point(990, 475);
            txtPasswordErr.Name = "txtPasswordErr";
            txtPasswordErr.Size = new Size(52, 17);
            txtPasswordErr.TabIndex = 81;
            txtPasswordErr.Text = "label6";
            // 
            // txtEmailErr
            // 
            txtEmailErr.AutoSize = true;
            txtEmailErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmailErr.ForeColor = Color.Red;
            txtEmailErr.Location = new Point(990, 383);
            txtEmailErr.Name = "txtEmailErr";
            txtEmailErr.Size = new Size(52, 17);
            txtEmailErr.TabIndex = 80;
            txtEmailErr.Text = "label5";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightSlateGray;
            btnUpdate.Location = new Point(1138, 734);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 44);
            btnUpdate.TabIndex = 79;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(990, 428);
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(250, 27);
            txtPassword.TabIndex = 78;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(990, 340);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 27);
            txtEmail.TabIndex = 77;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(990, 524);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(250, 27);
            txtAddress.TabIndex = 76;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(824, 524);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 75;
            label4.Text = "Address : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(824, 435);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 74;
            label3.Text = "Password : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(824, 347);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 73;
            label2.Text = "Email : ";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(824, 54);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(223, 20);
            linkLabel1.TabIndex = 72;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back to member management";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(885, 159);
            label1.Name = "label1";
            label1.Size = new Size(273, 52);
            label1.TabIndex = 71;
            label1.Text = "Edit Member";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(824, 268);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 89;
            label5.Text = "Name : ";
            // 
            // dtpJoinDate
            // 
            dtpJoinDate.Location = new Point(990, 618);
            dtpJoinDate.Name = "dtpJoinDate";
            dtpJoinDate.Size = new Size(250, 27);
            dtpJoinDate.TabIndex = 91;
            // 
            // txtName
            // 
            txtName.Location = new Point(988, 261);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 27);
            txtName.TabIndex = 92;
            // 
            // EditMemberForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(txtName);
            Controls.Add(dtpJoinDate);
            Controls.Add(label5);
            Controls.Add(txtNameErr);
            Controls.Add(dtpJoinDateErr);
            Controls.Add(label10);
            Controls.Add(txtAddressErr);
            Controls.Add(txtPasswordErr);
            Controls.Add(txtEmailErr);
            Controls.Add(btnUpdate);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditMemberForm";
            Text = "EditMemberForm";
            Load += EditMemberForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtNameErr;
        private Label dtpJoinDateErr;
        private Label label10;
        private Label txtAddressErr;
        private Label txtPasswordErr;
        private Label txtEmailErr;
        private Button btnUpdate;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private Label label4;
        private Label label3;
        private Label label2;
        private LinkLabel linkLabel1;
        private Label label1;
        private Label label5;
        private DateTimePicker dtpJoinDate;
        private TextBox txtName;
    }
}