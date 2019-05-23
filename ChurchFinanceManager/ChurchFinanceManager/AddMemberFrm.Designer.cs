namespace ChurchFinanceManager
{
    partial class AddMemberFrm
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
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.middleNameTxt = new System.Windows.Forms.TextBox();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cityTxt = new System.Windows.Forms.TextBox();
            this.isRegularChkBx = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddMemberBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Location = new System.Drawing.Point(108, 18);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(255, 22);
            this.firstNameTxt.TabIndex = 0;
            // 
            // middleNameTxt
            // 
            this.middleNameTxt.Location = new System.Drawing.Point(108, 46);
            this.middleNameTxt.Name = "middleNameTxt";
            this.middleNameTxt.Size = new System.Drawing.Size(255, 22);
            this.middleNameTxt.TabIndex = 1;
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(108, 74);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(255, 22);
            this.lastNameTxt.TabIndex = 2;
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(108, 102);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(255, 22);
            this.birthdayDateTimePicker.TabIndex = 3;
            // 
            // cityTxt
            // 
            this.cityTxt.Location = new System.Drawing.Point(108, 149);
            this.cityTxt.Name = "cityTxt";
            this.cityTxt.Size = new System.Drawing.Size(255, 22);
            this.cityTxt.TabIndex = 4;
            // 
            // isRegularChkBx
            // 
            this.isRegularChkBx.AutoSize = true;
            this.isRegularChkBx.Checked = true;
            this.isRegularChkBx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isRegularChkBx.Location = new System.Drawing.Point(108, 189);
            this.isRegularChkBx.Name = "isRegularChkBx";
            this.isRegularChkBx.Size = new System.Drawing.Size(135, 21);
            this.isRegularChkBx.TabIndex = 5;
            this.isRegularChkBx.Text = "Regular Member";
            this.isRegularChkBx.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Middle Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Birthday";
            // 
            // AddMemberBtn
            // 
            this.AddMemberBtn.Location = new System.Drawing.Point(250, 233);
            this.AddMemberBtn.Name = "AddMemberBtn";
            this.AddMemberBtn.Size = new System.Drawing.Size(114, 29);
            this.AddMemberBtn.TabIndex = 11;
            this.AddMemberBtn.Text = "Add Member";
            this.AddMemberBtn.UseVisualStyleBackColor = true;
            this.AddMemberBtn.Click += new System.EventHandler(this.AddMemberBtn_Click);
            // 
            // AddMemberFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 274);
            this.Controls.Add(this.AddMemberBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.isRegularChkBx);
            this.Controls.Add(this.cityTxt);
            this.Controls.Add(this.birthdayDateTimePicker);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.middleNameTxt);
            this.Controls.Add(this.firstNameTxt);
            this.Name = "AddMemberFrm";
            this.Text = "Add Member";
            this.Load += new System.EventHandler(this.AddMember_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.TextBox middleNameTxt;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.TextBox cityTxt;
        private System.Windows.Forms.CheckBox isRegularChkBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddMemberBtn;
    }
}