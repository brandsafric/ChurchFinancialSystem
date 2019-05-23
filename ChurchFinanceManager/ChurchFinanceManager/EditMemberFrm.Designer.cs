namespace ChurchFinanceManager
{
    partial class EditMemberFrm
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
            this.UpdateMemberBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.isRegularChkBx = new System.Windows.Forms.CheckBox();
            this.cityTxt = new System.Windows.Forms.TextBox();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.middleNameTxt = new System.Windows.Forms.TextBox();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UpdateMemberBtn
            // 
            this.UpdateMemberBtn.Location = new System.Drawing.Point(201, 226);
            this.UpdateMemberBtn.Name = "UpdateMemberBtn";
            this.UpdateMemberBtn.Size = new System.Drawing.Size(161, 29);
            this.UpdateMemberBtn.TabIndex = 23;
            this.UpdateMemberBtn.Text = "Update Member";
            this.UpdateMemberBtn.UseVisualStyleBackColor = true;
            this.UpdateMemberBtn.Click += new System.EventHandler(this.UpdateMemberBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Birthday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Middle Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "First Name";
            // 
            // isRegularChkBx
            // 
            this.isRegularChkBx.AutoSize = true;
            this.isRegularChkBx.Checked = true;
            this.isRegularChkBx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isRegularChkBx.Location = new System.Drawing.Point(106, 182);
            this.isRegularChkBx.Name = "isRegularChkBx";
            this.isRegularChkBx.Size = new System.Drawing.Size(135, 21);
            this.isRegularChkBx.TabIndex = 17;
            this.isRegularChkBx.Text = "Regular Member";
            this.isRegularChkBx.UseVisualStyleBackColor = true;
            // 
            // cityTxt
            // 
            this.cityTxt.Location = new System.Drawing.Point(106, 142);
            this.cityTxt.Name = "cityTxt";
            this.cityTxt.Size = new System.Drawing.Size(255, 22);
            this.cityTxt.TabIndex = 16;
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(106, 95);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(255, 22);
            this.birthdayDateTimePicker.TabIndex = 15;
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(106, 67);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(255, 22);
            this.lastNameTxt.TabIndex = 14;
            // 
            // middleNameTxt
            // 
            this.middleNameTxt.Location = new System.Drawing.Point(106, 39);
            this.middleNameTxt.Name = "middleNameTxt";
            this.middleNameTxt.Size = new System.Drawing.Size(255, 22);
            this.middleNameTxt.TabIndex = 13;
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Location = new System.Drawing.Point(106, 11);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(255, 22);
            this.firstNameTxt.TabIndex = 12;
            // 
            // EditMemberFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 267);
            this.Controls.Add(this.UpdateMemberBtn);
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
            this.Name = "EditMemberFrm";
            this.Text = "Edit Member";
            this.Load += new System.EventHandler(this.EditMember_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateMemberBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox isRegularChkBx;
        private System.Windows.Forms.TextBox cityTxt;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.TextBox middleNameTxt;
        private System.Windows.Forms.TextBox firstNameTxt;
    }
}