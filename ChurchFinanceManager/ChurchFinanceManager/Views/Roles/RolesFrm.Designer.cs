namespace ChurchFinanceManager { 
    partial class RolesFrm
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
            this.rolesSplitContainer = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.adminNotificationLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.applyBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.rolesChkLstBx = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.rolesSplitContainer)).BeginInit();
            this.rolesSplitContainer.Panel1.SuspendLayout();
            this.rolesSplitContainer.Panel2.SuspendLayout();
            this.rolesSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // rolesSplitContainer
            // 
            this.rolesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rolesSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.rolesSplitContainer.IsSplitterFixed = true;
            this.rolesSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.rolesSplitContainer.Name = "rolesSplitContainer";
            this.rolesSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // rolesSplitContainer.Panel1
            // 
            this.rolesSplitContainer.Panel1.Controls.Add(this.label3);
            this.rolesSplitContainer.Panel1.Controls.Add(this.userNameTxt);
            this.rolesSplitContainer.Panel1.Controls.Add(this.nameTxt);
            this.rolesSplitContainer.Panel1.Controls.Add(this.label2);
            // 
            // rolesSplitContainer.Panel2
            // 
            this.rolesSplitContainer.Panel2.Controls.Add(this.adminNotificationLbl);
            this.rolesSplitContainer.Panel2.Controls.Add(this.label1);
            this.rolesSplitContainer.Panel2.Controls.Add(this.applyBtn);
            this.rolesSplitContainer.Panel2.Controls.Add(this.cancelBtn);
            this.rolesSplitContainer.Panel2.Controls.Add(this.rolesChkLstBx);
            this.rolesSplitContainer.Size = new System.Drawing.Size(474, 403);
            this.rolesSplitContainer.SplitterDistance = 87;
            this.rolesSplitContainer.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username";
            // 
            // userNameTxt
            // 
            this.userNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameTxt.Enabled = false;
            this.userNameTxt.Location = new System.Drawing.Point(91, 49);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(371, 22);
            this.userNameTxt.TabIndex = 2;
            // 
            // nameTxt
            // 
            this.nameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTxt.Enabled = false;
            this.nameTxt.Location = new System.Drawing.Point(91, 15);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(371, 22);
            this.nameTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // adminNotificationLbl
            // 
            this.adminNotificationLbl.AutoSize = true;
            this.adminNotificationLbl.Location = new System.Drawing.Point(63, 11);
            this.adminNotificationLbl.Name = "adminNotificationLbl";
            this.adminNotificationLbl.Size = new System.Drawing.Size(368, 17);
            this.adminNotificationLbl.TabIndex = 5;
            this.adminNotificationLbl.Text = "The admin\'s roles cannot be edited and will have all roles";
            this.adminNotificationLbl.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Roles:";
            // 
            // applyBtn
            // 
            this.applyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.applyBtn.Location = new System.Drawing.Point(387, 262);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(75, 38);
            this.applyBtn.TabIndex = 3;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.Location = new System.Drawing.Point(306, 262);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 38);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // rolesChkLstBx
            // 
            this.rolesChkLstBx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rolesChkLstBx.FormattingEnabled = true;
            this.rolesChkLstBx.Items.AddRange(new object[] {
            "asd",
            "sdasdsa",
            "asdas"});
            this.rolesChkLstBx.Location = new System.Drawing.Point(66, 31);
            this.rolesChkLstBx.Name = "rolesChkLstBx";
            this.rolesChkLstBx.Size = new System.Drawing.Size(396, 208);
            this.rolesChkLstBx.TabIndex = 0;
            // 
            // RolesFrm
            // 
            this.AcceptButton = this.applyBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 403);
            this.Controls.Add(this.rolesSplitContainer);
            this.Name = "RolesFrm";
            this.Text = "User Roles";
            this.Load += new System.EventHandler(this.RolesFrm_Load);
            this.rolesSplitContainer.Panel1.ResumeLayout(false);
            this.rolesSplitContainer.Panel1.PerformLayout();
            this.rolesSplitContainer.Panel2.ResumeLayout(false);
            this.rolesSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesSplitContainer)).EndInit();
            this.rolesSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer rolesSplitContainer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.CheckedListBox rolesChkLstBx;
        private System.Windows.Forms.Label adminNotificationLbl;
    }
}