namespace GymManagementSystem
{
    partial class UserSettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSettingForm));
            label1 = new Label();
            groupBox1 = new GroupBox();
            linkLogout = new LinkLabel();
            linkSetting = new LinkLabel();
            linkLabel1 = new LinkLabel();
            linkProfile = new LinkLabel();
            label3 = new Label();
            label2 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnUpdate = new Button();
            txtPasswordErr = new Label();
            txtUserNameErr = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(812, 50);
            label1.Name = "label1";
            label1.Size = new Size(405, 52);
            label1.TabIndex = 72;
            label1.Text = "Profile Information";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkLogout);
            groupBox1.Controls.Add(linkSetting);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(linkProfile);
            groupBox1.Location = new Point(78, 243);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.No;
            groupBox1.Size = new Size(199, 508);
            groupBox1.TabIndex = 73;
            groupBox1.TabStop = false;
            // 
            // linkLogout
            // 
            linkLogout.AutoSize = true;
            linkLogout.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLogout.Location = new Point(63, 383);
            linkLogout.Name = "linkLogout";
            linkLogout.Size = new Size(71, 23);
            linkLogout.TabIndex = 4;
            linkLogout.TabStop = true;
            linkLogout.Text = "Logout";
            linkLogout.LinkClicked += linkLogout_LinkClicked;
            // 
            // linkSetting
            // 
            linkSetting.AutoSize = true;
            linkSetting.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkSetting.Location = new Point(21, 281);
            linkSetting.Name = "linkSetting";
            linkSetting.Size = new Size(161, 23);
            linkSetting.TabIndex = 3;
            linkSetting.TabStop = true;
            linkSetting.Text = "Change Password";
            linkSetting.LinkClicked += linkSetting_LinkClicked;
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
            // linkProfile
            // 
            linkProfile.AutoSize = true;
            linkProfile.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkProfile.Location = new Point(44, 178);
            linkProfile.Name = "linkProfile";
            linkProfile.Size = new Size(107, 23);
            linkProfile.TabIndex = 1;
            linkProfile.TabStop = true;
            linkProfile.Text = "Edit Profile";
            linkProfile.LinkClicked += linkProfile_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(829, 332);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 75;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(829, 227);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 74;
            label2.Text = "User Name: ";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(968, 224);
            txtUserName.Name = "txtUserName";
            txtUserName.ReadOnly = true;
            txtUserName.Size = new Size(200, 27);
            txtUserName.TabIndex = 76;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(968, 329);
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 77;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightSlateGray;
            btnUpdate.Location = new Point(1068, 433);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 44);
            btnUpdate.TabIndex = 78;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtPasswordErr
            // 
            txtPasswordErr.AutoSize = true;
            txtPasswordErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtPasswordErr.ForeColor = Color.Red;
            txtPasswordErr.Location = new Point(968, 382);
            txtPasswordErr.Name = "txtPasswordErr";
            txtPasswordErr.Size = new Size(52, 17);
            txtPasswordErr.TabIndex = 80;
            txtPasswordErr.Text = "label4";
            // 
            // txtUserNameErr
            // 
            txtUserNameErr.AutoSize = true;
            txtUserNameErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserNameErr.ForeColor = Color.Red;
            txtUserNameErr.Location = new Point(968, 271);
            txtUserNameErr.Name = "txtUserNameErr";
            txtUserNameErr.Size = new Size(52, 17);
            txtUserNameErr.TabIndex = 79;
            txtUserNameErr.Text = "label4";
            // 
            // UserSettingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(txtPasswordErr);
            Controls.Add(txtUserNameErr);
            Controls.Add(btnUpdate);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserSettingForm";
            Text = "UserSettingForm";
            FormClosed += UserSettingForm_FormClosed;
            Load += UserSettingForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button3;
        private Label label1;
        private GroupBox groupBox1;
        private LinkLabel linkSetting;
        private LinkLabel linkLabel1;
        private LinkLabel linkClass;
        private LinkLabel linkProfile;
        private Label label3;
        private Label label2;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnUpdate;
        private Label txtPasswordErr;
        private Label txtUserNameErr;
        private LinkLabel linkLogout;
    }
}