namespace GymManagementSystem
{
    partial class EditUserForm
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
            linkLabel1 = new LinkLabel();
            txtRoleErr = new Label();
            txtPasswordErr = new Label();
            txtUserNameErr = new Label();
            btnUpdate = new Button();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            txtRole = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(803, 80);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(194, 20);
            linkLabel1.TabIndex = 36;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back to user management";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // txtRoleErr
            // 
            txtRoleErr.AutoSize = true;
            txtRoleErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtRoleErr.ForeColor = Color.Red;
            txtRoleErr.Location = new Point(927, 462);
            txtRoleErr.Name = "txtRoleErr";
            txtRoleErr.Size = new Size(52, 17);
            txtRoleErr.TabIndex = 35;
            txtRoleErr.Text = "label7";
            // 
            // txtPasswordErr
            // 
            txtPasswordErr.AutoSize = true;
            txtPasswordErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtPasswordErr.ForeColor = Color.Red;
            txtPasswordErr.Location = new Point(927, 364);
            txtPasswordErr.Name = "txtPasswordErr";
            txtPasswordErr.Size = new Size(52, 17);
            txtPasswordErr.TabIndex = 34;
            txtPasswordErr.Text = "label6";
            // 
            // txtUserNameErr
            // 
            txtUserNameErr.AutoSize = true;
            txtUserNameErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserNameErr.ForeColor = Color.Red;
            txtUserNameErr.Location = new Point(927, 272);
            txtUserNameErr.Name = "txtUserNameErr";
            txtUserNameErr.Size = new Size(52, 17);
            txtUserNameErr.TabIndex = 33;
            txtUserNameErr.Text = "label5";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightSlateGray;
            btnUpdate.Location = new Point(1027, 499);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 44);
            btnUpdate.TabIndex = 32;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(927, 317);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 31;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(927, 229);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(200, 27);
            txtUserName.TabIndex = 30;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(927, 413);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(200, 27);
            txtRole.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(803, 413);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 28;
            label4.Text = "Role:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(803, 324);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 27;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(803, 236);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 26;
            label2.Text = "User Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(865, 133);
            label1.Name = "label1";
            label1.Size = new Size(200, 52);
            label1.TabIndex = 25;
            label1.Text = "Edit User";
            // 
            // EditUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(linkLabel1);
            Controls.Add(txtRoleErr);
            Controls.Add(txtPasswordErr);
            Controls.Add(txtUserNameErr);
            Controls.Add(btnUpdate);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(txtRole);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditUserForm";
            Text = "EditUserForm";
            FormClosed += EditUserForm_FormClosed;
            Load += EditUserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Label txtRoleErr;
        private Label txtPasswordErr;
        private Label txtUserNameErr;
        private Button btnUpdate;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private TextBox txtRole;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}