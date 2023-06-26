namespace GymManagementSystem
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            txtUserNameErr = new Label();
            txtPasswordErr = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(873, 139);
            label1.Name = "label1";
            label1.Size = new Size(230, 40);
            label1.TabIndex = 0;
            label1.Text = "Login Account";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(952, 227);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(200, 27);
            txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(952, 343);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(832, 234);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 5;
            label2.Text = "User Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(832, 343);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 6;
            label3.Text = "Password:";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(1059, 449);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(93, 40);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUserNameErr
            // 
            txtUserNameErr.AutoSize = true;
            txtUserNameErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserNameErr.ForeColor = Color.Red;
            txtUserNameErr.Location = new Point(952, 272);
            txtUserNameErr.Name = "txtUserNameErr";
            txtUserNameErr.Size = new Size(52, 17);
            txtUserNameErr.TabIndex = 30;
            txtUserNameErr.Text = "label4";
            // 
            // txtPasswordErr
            // 
            txtPasswordErr.AutoSize = true;
            txtPasswordErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtPasswordErr.ForeColor = Color.Red;
            txtPasswordErr.Location = new Point(952, 396);
            txtPasswordErr.Name = "txtPasswordErr";
            txtPasswordErr.Size = new Size(52, 17);
            txtPasswordErr.TabIndex = 31;
            txtPasswordErr.Text = "label4";
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Eye;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton1.Location = new Point(1169, 343);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(49, 33);
            iconButton1.TabIndex = 32;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(iconButton1);
            Controls.Add(txtPasswordErr);
            Controls.Add(txtUserNameErr);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Text = "Login Form";
            FormClosed += LoginForm_FormClosed;
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label label2;
        private Label label3;
        private Button btnLogin;
        private Label txtUserNameErr;
        private Label txtPasswordErr;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}