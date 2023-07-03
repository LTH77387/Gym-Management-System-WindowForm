namespace GymManagementSystem
{
    partial class MemberRegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberRegistrationForm));
            txtNameErr = new Label();
            label1 = new Label();
            label7 = new Label();
            txtEmail = new TextBox();
            txtName = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            txtAddress = new TextBox();
            txtWeight = new TextBox();
            txtHeightInFt = new TextBox();
            txtEmailErr = new Label();
            txtAddressErr = new Label();
            txtWeightErr = new Label();
            txtHeightErr = new Label();
            txtHeightInInch = new TextBox();
            label11 = new Label();
            label12 = new Label();
            btnRegister = new Button();
            label13 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // txtNameErr
            // 
            txtNameErr.AutoSize = true;
            txtNameErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtNameErr.ForeColor = Color.Red;
            txtNameErr.Location = new Point(956, 278);
            txtNameErr.Name = "txtNameErr";
            txtNameErr.Size = new Size(52, 17);
            txtNameErr.TabIndex = 64;
            txtNameErr.Text = "label5";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(781, 232);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 63;
            label1.Text = "Name : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(781, 317);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 62;
            label7.Text = "Email : ";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(956, 314);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 27);
            txtEmail.TabIndex = 61;
            // 
            // txtName
            // 
            txtName.Location = new Point(956, 232);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 27);
            txtName.TabIndex = 60;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(781, 59);
            label4.Name = "label4";
            label4.Size = new Size(441, 52);
            label4.TabIndex = 65;
            label4.Text = "Member Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(781, 413);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 66;
            label2.Text = "Address : ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(781, 512);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 67;
            label3.Text = "Weight : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(781, 609);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 68;
            label5.Text = "Height : ";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(956, 406);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(200, 27);
            txtAddress.TabIndex = 69;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(956, 505);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(164, 27);
            txtWeight.TabIndex = 70;
            // 
            // txtHeightInFt
            // 
            txtHeightInFt.Location = new Point(956, 602);
            txtHeightInFt.Name = "txtHeightInFt";
            txtHeightInFt.Size = new Size(52, 27);
            txtHeightInFt.TabIndex = 71;
            // 
            // txtEmailErr
            // 
            txtEmailErr.AutoSize = true;
            txtEmailErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmailErr.ForeColor = Color.Red;
            txtEmailErr.Location = new Point(956, 365);
            txtEmailErr.Name = "txtEmailErr";
            txtEmailErr.Size = new Size(52, 17);
            txtEmailErr.TabIndex = 72;
            txtEmailErr.Text = "label5";
            // 
            // txtAddressErr
            // 
            txtAddressErr.AutoSize = true;
            txtAddressErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtAddressErr.ForeColor = Color.Red;
            txtAddressErr.Location = new Point(956, 458);
            txtAddressErr.Name = "txtAddressErr";
            txtAddressErr.Size = new Size(52, 17);
            txtAddressErr.TabIndex = 73;
            txtAddressErr.Text = "label5";
            // 
            // txtWeightErr
            // 
            txtWeightErr.AutoSize = true;
            txtWeightErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtWeightErr.ForeColor = Color.Red;
            txtWeightErr.Location = new Point(956, 555);
            txtWeightErr.Name = "txtWeightErr";
            txtWeightErr.Size = new Size(52, 17);
            txtWeightErr.TabIndex = 74;
            txtWeightErr.Text = "label5";
            // 
            // txtHeightErr
            // 
            txtHeightErr.AutoSize = true;
            txtHeightErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtHeightErr.ForeColor = Color.Red;
            txtHeightErr.Location = new Point(956, 658);
            txtHeightErr.Name = "txtHeightErr";
            txtHeightErr.Size = new Size(52, 17);
            txtHeightErr.TabIndex = 75;
            txtHeightErr.Text = "label5";
            // 
            // txtHeightInInch
            // 
            txtHeightInInch.Location = new Point(1068, 602);
            txtHeightInInch.Name = "txtHeightInInch";
            txtHeightInInch.Size = new Size(52, 27);
            txtHeightInInch.TabIndex = 76;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1028, 609);
            label11.Name = "label11";
            label11.Size = new Size(19, 20);
            label11.TabIndex = 77;
            label11.Text = "ft";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1135, 609);
            label12.Name = "label12";
            label12.Size = new Size(21, 20);
            label12.TabIndex = 78;
            label12.Text = "in";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.LightSlateGray;
            btnRegister.Location = new Point(1056, 722);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(100, 44);
            btnRegister.TabIndex = 79;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1134, 508);
            label13.Name = "label13";
            label13.Size = new Size(22, 20);
            label13.TabIndex = 80;
            label13.Text = "lb";
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(547, 67);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(100, 44);
            iconButton1.TabIndex = 89;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // MemberRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(iconButton1);
            Controls.Add(label13);
            Controls.Add(btnRegister);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(txtHeightInInch);
            Controls.Add(txtHeightErr);
            Controls.Add(txtWeightErr);
            Controls.Add(txtAddressErr);
            Controls.Add(txtEmailErr);
            Controls.Add(txtHeightInFt);
            Controls.Add(txtWeight);
            Controls.Add(txtAddress);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(txtNameErr);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MemberRegistrationForm";
            Text = "MemberRegistrationForm";
            FormClosed += MemberRegistrationForm_FormClosed;
            Load += MemberRegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtNameErr;
        private Label label1;
        private Label label7;
        private TextBox txtEmail;
        private TextBox txtName;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox txtAddress;
        private TextBox txtWeight;
        private TextBox txtHeightInFt;
        private Label txtEmailErr;
        private Label txtAddressErr;
        private Label txtWeightErr;
        private Label txtHeightErr;
        private TextBox txtHeightInInch;
        private Label label11;
        private Label label12;
        private Button btnRegister;
        private Label label13;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}