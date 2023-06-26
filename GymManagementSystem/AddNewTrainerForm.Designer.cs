namespace GymManagementSystem
{
    partial class AddNewTrainerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewTrainerForm));
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            txtPhoneNumberErr = new Label();
            txtAddressErr = new Label();
            txtTrainerNameErr = new Label();
            btnAdd = new Button();
            txtAddress = new TextBox();
            txtTrainerName = new TextBox();
            txtPhoneNumber = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(815, 157);
            label1.Name = "label1";
            label1.Size = new Size(342, 52);
            label1.TabIndex = 1;
            label1.Text = "Add new trainer";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(791, 80);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(213, 20);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back to trainer management";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // txtPhoneNumberErr
            // 
            txtPhoneNumberErr.AutoSize = true;
            txtPhoneNumberErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtPhoneNumberErr.ForeColor = Color.Red;
            txtPhoneNumberErr.Location = new Point(941, 518);
            txtPhoneNumberErr.Name = "txtPhoneNumberErr";
            txtPhoneNumberErr.Size = new Size(52, 17);
            txtPhoneNumberErr.TabIndex = 36;
            txtPhoneNumberErr.Text = "label7";
            // 
            // txtAddressErr
            // 
            txtAddressErr.AutoSize = true;
            txtAddressErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtAddressErr.ForeColor = Color.Red;
            txtAddressErr.Location = new Point(941, 420);
            txtAddressErr.Name = "txtAddressErr";
            txtAddressErr.Size = new Size(52, 17);
            txtAddressErr.TabIndex = 35;
            txtAddressErr.Text = "label6";
            // 
            // txtTrainerNameErr
            // 
            txtTrainerNameErr.AutoSize = true;
            txtTrainerNameErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtTrainerNameErr.ForeColor = Color.Red;
            txtTrainerNameErr.Location = new Point(941, 328);
            txtTrainerNameErr.Name = "txtTrainerNameErr";
            txtTrainerNameErr.Size = new Size(52, 17);
            txtTrainerNameErr.TabIndex = 34;
            txtTrainerNameErr.Text = "label5";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightSlateGray;
            btnAdd.Location = new Point(1041, 555);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 44);
            btnAdd.TabIndex = 33;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(941, 373);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(200, 27);
            txtAddress.TabIndex = 32;
            // 
            // txtTrainerName
            // 
            txtTrainerName.Location = new Point(941, 285);
            txtTrainerName.Name = "txtTrainerName";
            txtTrainerName.Size = new Size(200, 27);
            txtTrainerName.TabIndex = 31;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(941, 469);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(200, 27);
            txtPhoneNumber.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(817, 469);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 29;
            label5.Text = "Phone Number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(817, 380);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 28;
            label6.Text = "Address:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(817, 292);
            label7.Name = "label7";
            label7.Size = new Size(101, 20);
            label7.TabIndex = 27;
            label7.Text = "Trainer Name:";
            // 
            // AddNewTrainerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(txtPhoneNumberErr);
            Controls.Add(txtAddressErr);
            Controls.Add(txtTrainerNameErr);
            Controls.Add(btnAdd);
            Controls.Add(txtAddress);
            Controls.Add(txtTrainerName);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddNewTrainerForm";
            Text = "AddNewTrainerForm";
            FormClosed += AddNewTrainerForm_FormClosed;
            Load += AddNewTrainerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel linkLabel1;
        private Label txtPhoneNumberErr;
        private Label txtAddressErr;
        private Label txtTrainerNameErr;
        private Button btnAdd;
        private TextBox txtAddress;
        private TextBox txtTrainerName;
        private TextBox txtPhoneNumber;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}