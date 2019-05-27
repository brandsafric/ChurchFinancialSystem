namespace ChurchFinanceManager
{
    partial class AddUpdateGivingTypeFrm
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
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.isRegularChkBx = new System.Windows.Forms.CheckBox();
            this.isActiveChkBx = new System.Windows.Forms.CheckBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleTxt
            // 
            this.titleTxt.Location = new System.Drawing.Point(110, 14);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(177, 22);
            this.titleTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // isRegularChkBx
            // 
            this.isRegularChkBx.AutoSize = true;
            this.isRegularChkBx.Checked = true;
            this.isRegularChkBx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isRegularChkBx.Location = new System.Drawing.Point(110, 55);
            this.isRegularChkBx.Name = "isRegularChkBx";
            this.isRegularChkBx.Size = new System.Drawing.Size(171, 21);
            this.isRegularChkBx.TabIndex = 2;
            this.isRegularChkBx.Text = "Regular Offering Type";
            this.isRegularChkBx.UseVisualStyleBackColor = true;
            // 
            // isActiveChkBx
            // 
            this.isActiveChkBx.AutoSize = true;
            this.isActiveChkBx.Checked = true;
            this.isActiveChkBx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isActiveChkBx.Location = new System.Drawing.Point(110, 94);
            this.isActiveChkBx.Name = "isActiveChkBx";
            this.isActiveChkBx.Size = new System.Drawing.Size(68, 21);
            this.isActiveChkBx.TabIndex = 3;
            this.isActiveChkBx.Text = "Active";
            this.isActiveChkBx.UseVisualStyleBackColor = true;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(110, 140);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 29);
            this.createBtn.TabIndex = 4;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // AddGivingTypeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 189);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.isActiveChkBx);
            this.Controls.Add(this.isRegularChkBx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleTxt);
            this.Name = "AddGivingTypeFrm";
            this.Text = "Add Offering Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox isRegularChkBx;
        private System.Windows.Forms.CheckBox isActiveChkBx;
        private System.Windows.Forms.Button createBtn;
    }
}