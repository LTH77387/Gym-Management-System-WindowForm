namespace GymManagementSystem
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            btnRegister = new Button();
            label3 = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            txtuserNameErr = new Label();
            txtPasswordErr = new Label();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(1056, 440);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(93, 40);
            btnRegister.TabIndex = 13;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(829, 330);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 12;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(829, 223);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 11;
            label2.Text = "User Name: ";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(949, 330);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 10;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(949, 216);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(200, 27);
            txtUserName.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(848, 110);
            label1.Name = "label1";
            label1.Size = new Size(271, 40);
            label1.TabIndex = 8;
            label1.Text = "Register Account";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(829, 450);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(178, 20);
            linkLabel1.TabIndex = 28;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Already have an account?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // txtuserNameErr
            // 
            txtuserNameErr.AutoSize = true;
            txtuserNameErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtuserNameErr.ForeColor = Color.Red;
            txtuserNameErr.Location = new Point(949, 259);
            txtuserNameErr.Name = "txtuserNameErr";
            txtuserNameErr.Size = new Size(52, 17);
            txtuserNameErr.TabIndex = 29;
            txtuserNameErr.Text = "label4";
            // 
            // txtPasswordErr
            // 
            txtPasswordErr.AutoSize = true;
            txtPasswordErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtPasswordErr.ForeColor = Color.Red;
            txtPasswordErr.Location = new Point(949, 369);
            txtPasswordErr.Name = "txtPasswordErr";
            txtPasswordErr.Size = new Size(52, 17);
            txtPasswordErr.TabIndex = 30;
            txtPasswordErr.Text = "label5";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(txtPasswordErr);
            Controls.Add(txtuserNameErr);
            Controls.Add(linkLabel1);
            Controls.Add(btnRegister);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private Label label3;
        private Label label2;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label label1;
        private LinkLabel linkLabel1;
        private Label txtuserNameErr;
        private Label txtPasswordErr;
    }
}