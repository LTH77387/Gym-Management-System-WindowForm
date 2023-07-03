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
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            txtPasswordErr = new Label();
            txtuserNameErr = new Label();
            linkLabel1 = new LinkLabel();
            btnRegister = new Button();
            label3 = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ScrollBar;
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(txtPasswordErr);
            groupBox1.Controls.Add(txtuserNameErr);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(btnRegister);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(470, 170);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(962, 475);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.buclogo;
            pictureBox1.Location = new Point(105, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(279, 263);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // txtPasswordErr
            // 
            txtPasswordErr.AutoSize = true;
            txtPasswordErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtPasswordErr.ForeColor = Color.Red;
            txtPasswordErr.Location = new Point(625, 304);
            txtPasswordErr.Name = "txtPasswordErr";
            txtPasswordErr.Size = new Size(52, 17);
            txtPasswordErr.TabIndex = 40;
            txtPasswordErr.Text = "label5";
            // 
            // txtuserNameErr
            // 
            txtuserNameErr.AutoSize = true;
            txtuserNameErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtuserNameErr.ForeColor = Color.Red;
            txtuserNameErr.Location = new Point(625, 194);
            txtuserNameErr.Name = "txtuserNameErr";
            txtuserNameErr.Size = new Size(52, 17);
            txtuserNameErr.TabIndex = 39;
            txtuserNameErr.Text = "label4";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(505, 385);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(178, 20);
            linkLabel1.TabIndex = 38;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Already have an account?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.LightSlateGray;
            btnRegister.Location = new Point(725, 373);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(100, 44);
            btnRegister.TabIndex = 37;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(505, 265);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 36;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(505, 158);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 35;
            label2.Text = "User Name: ";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(625, 265);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 34;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(625, 151);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(200, 27);
            txtUserName.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(524, 45);
            label1.Name = "label1";
            label1.Size = new Size(271, 40);
            label1.TabIndex = 32;
            label1.Text = "Register Account";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label txtPasswordErr;
        private Label txtuserNameErr;
        private LinkLabel linkLabel1;
        private Button btnRegister;
        private Label label3;
        private Label label2;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label label1;
    }
}