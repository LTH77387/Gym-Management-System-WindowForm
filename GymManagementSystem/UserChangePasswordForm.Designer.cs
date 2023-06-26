namespace GymManagementSystem
{
    partial class UserChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserChangePasswordForm));
            label1 = new Label();
            txtOldPasswordErr = new Label();
            label3 = new Label();
            txtOldPassword = new TextBox();
            btnUpdate = new Button();
            txtNewPasswordErr = new Label();
            label4 = new Label();
            txtNewPassword = new TextBox();
            txtConfirmPasswordErr = new Label();
            label6 = new Label();
            txtConfirmPassword = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(840, 58);
            label1.Name = "label1";
            label1.Size = new Size(371, 52);
            label1.TabIndex = 73;
            label1.Text = "Change Password";
            // 
            // txtOldPasswordErr
            // 
            txtOldPasswordErr.AutoSize = true;
            txtOldPasswordErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtOldPasswordErr.ForeColor = Color.Red;
            txtOldPasswordErr.Location = new Point(992, 267);
            txtOldPasswordErr.Name = "txtOldPasswordErr";
            txtOldPasswordErr.Size = new Size(52, 17);
            txtOldPasswordErr.TabIndex = 77;
            txtOldPasswordErr.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(840, 217);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 75;
            label3.Text = "Old Password :";
            // 
            // txtOldPassword
            // 
            txtOldPassword.Location = new Point(992, 214);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.Size = new Size(200, 27);
            txtOldPassword.TabIndex = 74;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightSlateGray;
            btnUpdate.Location = new Point(1092, 588);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 44);
            btnUpdate.TabIndex = 80;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtNewPasswordErr
            // 
            txtNewPasswordErr.AutoSize = true;
            txtNewPasswordErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtNewPasswordErr.ForeColor = Color.Red;
            txtNewPasswordErr.Location = new Point(992, 391);
            txtNewPasswordErr.Name = "txtNewPasswordErr";
            txtNewPasswordErr.Size = new Size(52, 17);
            txtNewPasswordErr.TabIndex = 83;
            txtNewPasswordErr.Text = "label4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(840, 341);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 82;
            label4.Text = "New Password :";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(992, 338);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(200, 27);
            txtNewPassword.TabIndex = 81;
            // 
            // txtConfirmPasswordErr
            // 
            txtConfirmPasswordErr.AutoSize = true;
            txtConfirmPasswordErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtConfirmPasswordErr.ForeColor = Color.Red;
            txtConfirmPasswordErr.Location = new Point(992, 518);
            txtConfirmPasswordErr.Name = "txtConfirmPasswordErr";
            txtConfirmPasswordErr.Size = new Size(52, 17);
            txtConfirmPasswordErr.TabIndex = 86;
            txtConfirmPasswordErr.Text = "label4";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(840, 468);
            label6.Name = "label6";
            label6.Size = new Size(134, 20);
            label6.TabIndex = 85;
            label6.Text = "Confirm Password :";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(992, 465);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(200, 27);
            txtConfirmPassword.TabIndex = 84;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(643, 66);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(100, 44);
            iconButton1.TabIndex = 87;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // UserChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(iconButton1);
            Controls.Add(txtConfirmPasswordErr);
            Controls.Add(label6);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtNewPasswordErr);
            Controls.Add(label4);
            Controls.Add(txtNewPassword);
            Controls.Add(btnUpdate);
            Controls.Add(txtOldPasswordErr);
            Controls.Add(label3);
            Controls.Add(txtOldPassword);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserChangePasswordForm";
            Text = "UserChangePasswordForm";
            FormClosed += UserChangePasswordForm_FormClosed;
            Load += UserChangePasswordForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label txtOldPasswordErr;
        private Label label3;
        private TextBox txtOldPassword;
        private Button btnUpdate;
        private Label txtNewPasswordErr;
        private Label label4;
        private TextBox txtNewPassword;
        private Label txtConfirmPasswordErr;
        private Label label6;
        private TextBox txtConfirmPassword;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}