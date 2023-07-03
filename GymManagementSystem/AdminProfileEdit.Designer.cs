namespace GymManagementSystem
{
    partial class AdminProfileEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminProfileEdit));
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            label4 = new Label();
            label7 = new Label();
            label1 = new Label();
            btnUpdate = new Button();
            txtUserNameErr = new Label();
            txtPasswordErr = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(984, 280);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(200, 27);
            txtUserName.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(984, 398);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(905, 140);
            label4.Name = "label4";
            label4.Size = new Size(242, 52);
            label4.TabIndex = 5;
            label4.Text = "Profile Edit";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(852, 401);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 28;
            label7.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(852, 280);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 29;
            label1.Text = "User Name:";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightSlateGray;
            btnUpdate.Location = new Point(1084, 494);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 44);
            btnUpdate.TabIndex = 58;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtUserNameErr
            // 
            txtUserNameErr.AutoSize = true;
            txtUserNameErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserNameErr.ForeColor = Color.Red;
            txtUserNameErr.Location = new Point(984, 324);
            txtUserNameErr.Name = "txtUserNameErr";
            txtUserNameErr.Size = new Size(52, 17);
            txtUserNameErr.TabIndex = 59;
            txtUserNameErr.Text = "label5";
            // 
            // txtPasswordErr
            // 
            txtPasswordErr.AutoSize = true;
            txtPasswordErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtPasswordErr.ForeColor = Color.Red;
            txtPasswordErr.Location = new Point(984, 450);
            txtPasswordErr.Name = "txtPasswordErr";
            txtPasswordErr.Size = new Size(52, 17);
            txtPasswordErr.TabIndex = 60;
            txtPasswordErr.Text = "label5";
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(825, 51);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(100, 44);
            iconButton1.TabIndex = 90;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // AdminProfileEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(iconButton1);
            Controls.Add(txtPasswordErr);
            Controls.Add(txtUserNameErr);
            Controls.Add(btnUpdate);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminProfileEdit";
            Text = "AdminProfileEdit";
            FormClosed += AdminProfileEdit_FormClosed;
            Load += AdminProfileEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label label4;
        private Label label7;
        private Label label1;
        private Button btnUpdate;
        private Label txtUserNameErr;
        private Label txtPasswordErr;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}