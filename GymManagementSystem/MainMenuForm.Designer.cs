namespace GymManagementSystem
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            iconSplitButton1 = new FontAwesome.Sharp.IconSplitButton();
            menuStrip1 = new MenuStrip();
            memberManagementToolStripMenuItem = new ToolStripMenuItem();
            trainerManagementToolStripMenuItem = new ToolStripMenuItem();
            gymClassManagementToolStripMenuItem = new ToolStripMenuItem();
            enrollmentManagementToolStripMenuItem = new ToolStripMenuItem();
            userManagementToolStripMenuItem = new ToolStripMenuItem();
            profileToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // iconSplitButton1
            // 
            iconSplitButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            iconSplitButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconSplitButton1.IconColor = Color.Black;
            iconSplitButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSplitButton1.IconSize = 48;
            iconSplitButton1.Name = "iconSplitButton1";
            iconSplitButton1.Rotation = 0D;
            iconSplitButton1.Size = new Size(23, 23);
            iconSplitButton1.Text = "iconSplitButton1";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { memberManagementToolStripMenuItem, trainerManagementToolStripMenuItem, gymClassManagementToolStripMenuItem, enrollmentManagementToolStripMenuItem, userManagementToolStripMenuItem, profileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1924, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // memberManagementToolStripMenuItem
            // 
            memberManagementToolStripMenuItem.Name = "memberManagementToolStripMenuItem";
            memberManagementToolStripMenuItem.Size = new Size(171, 24);
            memberManagementToolStripMenuItem.Text = "Member Management";
            memberManagementToolStripMenuItem.Click += memberManagementToolStripMenuItem_Click;
            // 
            // trainerManagementToolStripMenuItem
            // 
            trainerManagementToolStripMenuItem.Name = "trainerManagementToolStripMenuItem";
            trainerManagementToolStripMenuItem.Size = new Size(160, 24);
            trainerManagementToolStripMenuItem.Text = "Trainer Management";
            trainerManagementToolStripMenuItem.Click += trainerManagementToolStripMenuItem_Click_1;
            // 
            // gymClassManagementToolStripMenuItem
            // 
            gymClassManagementToolStripMenuItem.Name = "gymClassManagementToolStripMenuItem";
            gymClassManagementToolStripMenuItem.Size = new Size(182, 24);
            gymClassManagementToolStripMenuItem.Text = "Gym Class Management";
            gymClassManagementToolStripMenuItem.Click += gymClassManagementToolStripMenuItem_Click;
            // 
            // enrollmentManagementToolStripMenuItem
            // 
            enrollmentManagementToolStripMenuItem.Name = "enrollmentManagementToolStripMenuItem";
            enrollmentManagementToolStripMenuItem.Size = new Size(187, 24);
            enrollmentManagementToolStripMenuItem.Text = "Enrollment Management";
            enrollmentManagementToolStripMenuItem.Click += enrollmentManagementToolStripMenuItem_Click;
            // 
            // userManagementToolStripMenuItem
            // 
            userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            userManagementToolStripMenuItem.Size = new Size(144, 24);
            userManagementToolStripMenuItem.Text = "User Management";
            userManagementToolStripMenuItem.Click += userManagementToolStripMenuItem_Click;
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(66, 24);
            profileToolStripMenuItem.Text = "Profile";
            profileToolStripMenuItem.Click += profileToolStripMenuItem_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainMenuForm";
            Text = "MainMenuForm";
            FormClosed += MainMenuForm_FormClosed;
            Load += MainMenuForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconSplitButton iconSplitButton1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem memberManagementToolStripMenuItem;
        private ToolStripMenuItem trainerManagementToolStripMenuItem;
        private ToolStripMenuItem gymClassManagementToolStripMenuItem;
        private ToolStripMenuItem enrollmentManagementToolStripMenuItem;
        private ToolStripMenuItem userManagementToolStripMenuItem;
        private ToolStripMenuItem profileToolStripMenuItem;
    }
}