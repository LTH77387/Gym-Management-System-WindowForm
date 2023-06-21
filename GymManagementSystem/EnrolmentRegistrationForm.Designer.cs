namespace GymManagementSystem
{
    partial class EnrolmentRegistrationForm
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
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            btnRegister = new Button();
            label3 = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(895, 277);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 27);
            textBox1.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(775, 277);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 30;
            label4.Text = "Email";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(895, 457);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 27);
            textBox2.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(775, 457);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 28;
            label5.Text = "Address";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(1002, 540);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(93, 40);
            btnRegister.TabIndex = 26;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(775, 363);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 25;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(775, 191);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 24;
            label2.Text = "User Name: ";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(895, 363);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 23;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(895, 184);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(200, 27);
            txtUserName.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(695, 90);
            label1.Name = "label1";
            label1.Size = new Size(525, 47);
            label1.TabIndex = 21;
            label1.Text = " Member Registration Form ";
            // 
            // EnrolmentRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(btnRegister);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label1);
            Name = "EnrolmentRegistrationForm";
            Text = "EnrolmentRegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private Button btnRegister;
        private Label label3;
        private Label label2;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label label1;
    }
}