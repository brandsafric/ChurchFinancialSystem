namespace ChurchFinanceManager
{
    partial class frmDashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offeringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offeringTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offeringsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.familiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(793, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membersToolStripMenuItem,
            this.offeringToolStripMenuItem,
            this.servicesToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // membersToolStripMenuItem
            // 
            this.membersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membersToolStripMenuItem1,
            this.familiesToolStripMenuItem});
            this.membersToolStripMenuItem.Name = "membersToolStripMenuItem";
            this.membersToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.membersToolStripMenuItem.Text = "Members";
            this.membersToolStripMenuItem.Click += new System.EventHandler(this.membersToolStripMenuItem_Click);
            // 
            // offeringToolStripMenuItem
            // 
            this.offeringToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.offeringTypesToolStripMenuItem,
            this.offeringsToolStripMenuItem});
            this.offeringToolStripMenuItem.Name = "offeringToolStripMenuItem";
            this.offeringToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.offeringToolStripMenuItem.Text = "Offering";
            // 
            // offeringTypesToolStripMenuItem
            // 
            this.offeringTypesToolStripMenuItem.Name = "offeringTypesToolStripMenuItem";
            this.offeringTypesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.offeringTypesToolStripMenuItem.Text = "Offering Types";
            this.offeringTypesToolStripMenuItem.Click += new System.EventHandler(this.offeringTypesToolStripMenuItem_Click);
            // 
            // offeringsToolStripMenuItem
            // 
            this.offeringsToolStripMenuItem.Name = "offeringsToolStripMenuItem";
            this.offeringsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.offeringsToolStripMenuItem.Text = "Offerings";
            this.offeringsToolStripMenuItem.Click += new System.EventHandler(this.offeringsToolStripMenuItem_Click);
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.servicesToolStripMenuItem.Text = "Services";
            this.servicesToolStripMenuItem.Click += new System.EventHandler(this.ServicesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // membersToolStripMenuItem1
            // 
            this.membersToolStripMenuItem1.Name = "membersToolStripMenuItem1";
            this.membersToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.membersToolStripMenuItem1.Text = "Members";
            this.membersToolStripMenuItem1.Click += new System.EventHandler(this.MembersToolStripMenuItem1_Click);
            // 
            // familiesToolStripMenuItem
            // 
            this.familiesToolStripMenuItem.Name = "familiesToolStripMenuItem";
            this.familiesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.familiesToolStripMenuItem.Text = "Families";
            this.familiesToolStripMenuItem.Click += new System.EventHandler(this.FamiliesToolStripMenuItem_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 537);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDashboard";
            this.Text = "Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offeringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offeringTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offeringsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem familiesToolStripMenuItem;
    }
}

