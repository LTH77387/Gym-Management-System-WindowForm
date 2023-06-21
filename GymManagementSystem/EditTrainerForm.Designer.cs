namespace GymManagementSystem
{
    partial class EditTrainerForm
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
            linkLabel1 = new LinkLabel();
            txtPhoneNumberErr = new Label();
            txtAddressErr = new Label();
            txtTrainerNameErr = new Label();
            btnUpdate = new Button();
            txtAddress = new TextBox();
            txtTrainerName = new TextBox();
            txtPhoneNumber = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(764, 88);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(213, 20);
            linkLabel1.TabIndex = 24;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back to trainer management";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // txtPhoneNumberErr
            // 
            txtPhoneNumberErr.AutoSize = true;
            txtPhoneNumberErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtPhoneNumberErr.ForeColor = Color.Red;
            txtPhoneNumberErr.Location = new Point(888, 470);
            txtPhoneNumberErr.Name = "txtPhoneNumberErr";
            txtPhoneNumberErr.Size = new Size(52, 17);
            txtPhoneNumberErr.TabIndex = 23;
            txtPhoneNumberErr.Text = "label7";
            // 
            // txtAddressErr
            // 
            txtAddressErr.AutoSize = true;
            txtAddressErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtAddressErr.ForeColor = Color.Red;
            txtAddressErr.Location = new Point(888, 372);
            txtAddressErr.Name = "txtAddressErr";
            txtAddressErr.Size = new Size(52, 17);
            txtAddressErr.TabIndex = 22;
            txtAddressErr.Text = "label6";
            // 
            // txtTrainerNameErr
            // 
            txtTrainerNameErr.AutoSize = true;
            txtTrainerNameErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtTrainerNameErr.ForeColor = Color.Red;
            txtTrainerNameErr.Location = new Point(888, 280);
            txtTrainerNameErr.Name = "txtTrainerNameErr";
            txtTrainerNameErr.Size = new Size(52, 17);
            txtTrainerNameErr.TabIndex = 21;
            txtTrainerNameErr.Text = "label5";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightSlateGray;
            btnUpdate.Location = new Point(988, 507);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 44);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(888, 325);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(200, 27);
            txtAddress.TabIndex = 19;
            // 
            // txtTrainerName
            // 
            txtTrainerName.Location = new Point(888, 237);
            txtTrainerName.Name = "txtTrainerName";
            txtTrainerName.Size = new Size(200, 27);
            txtTrainerName.TabIndex = 18;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(888, 421);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(200, 27);
            txtPhoneNumber.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(764, 421);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 16;
            label4.Text = "Phone Number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(764, 332);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 15;
            label3.Text = "Address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(764, 244);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 14;
            label2.Text = "Trainer Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(788, 142);
            label1.Name = "label1";
            label1.Size = new Size(252, 52);
            label1.TabIndex = 13;
            label1.Text = "Edit trainer";
            // 
            // EditTrainerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(linkLabel1);
            Controls.Add(txtPhoneNumberErr);
            Controls.Add(txtAddressErr);
            Controls.Add(txtTrainerNameErr);
            Controls.Add(btnUpdate);
            Controls.Add(txtAddress);
            Controls.Add(txtTrainerName);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditTrainerForm";
            Text = "EditTrainerForm";
            FormClosed += EditTrainerForm_FormClosed;
            Load += EditTrainerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Label txtPhoneNumberErr;
        private Label txtAddressErr;
        private Label txtTrainerNameErr;
        private Button btnUpdate;
        private TextBox txtAddress;
        private TextBox txtTrainerName;
        private TextBox txtPhoneNumber;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}