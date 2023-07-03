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
            groupBox1 = new GroupBox();
            checkBox1 = new CheckBox();
            btnLogin = new Button();
            txtPasswordErr = new Label();
            label1 = new Label();
            txtUserNameErr = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ScrollBar;
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(txtPasswordErr);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtUserNameErr);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(624, 175);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(721, 526);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(512, 280);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 32;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LightSlateGray;
            btnLogin.Location = new Point(392, 376);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 44);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPasswordErr
            // 
            txtPasswordErr.AutoSize = true;
            txtPasswordErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtPasswordErr.ForeColor = Color.Red;
            txtPasswordErr.Location = new Point(292, 335);
            txtPasswordErr.Name = "txtPasswordErr";
            txtPasswordErr.Size = new Size(52, 17);
            txtPasswordErr.TabIndex = 31;
            txtPasswordErr.Text = "label4";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(213, 74);
            label1.Name = "label1";
            label1.Size = new Size(230, 40);
            label1.TabIndex = 0;
            label1.Text = "Login Account";
            // 
            // txtUserNameErr
            // 
            txtUserNameErr.AutoSize = true;
            txtUserNameErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserNameErr.ForeColor = Color.Red;
            txtUserNameErr.Location = new Point(292, 207);
            txtUserNameErr.Name = "txtUserNameErr";
            txtUserNameErr.Size = new Size(52, 17);
            txtUserNameErr.TabIndex = 30;
            txtUserNameErr.Text = "label4";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(292, 162);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(200, 27);
            txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(292, 278);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(172, 278);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 6;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 169);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 5;
            label2.Text = "User Name: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._60016869939b1c17a239f2f1_fitness_plus_gym;
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1924, 1053);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Text = "Login Form";
            FormClosed += LoginForm_FormClosed;
            Load += LoginForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnLogin;
        private Label txtPasswordErr;
        private Label label1;
        private Label txtUserNameErr;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
    }
}