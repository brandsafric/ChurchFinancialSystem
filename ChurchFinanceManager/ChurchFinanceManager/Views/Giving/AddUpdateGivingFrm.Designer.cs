namespace ChurchFinanceManager
{
    partial class AddUpdateGivingFrm
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
            this.membersCmbBx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.givingDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.submitBtn = new System.Windows.Forms.Button();
            this.serviceCmbBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // membersCmbBx
            // 
            this.membersCmbBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.membersCmbBx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.membersCmbBx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.membersCmbBx.FormattingEnabled = true;
            this.membersCmbBx.Location = new System.Drawing.Point(77, 12);
            this.membersCmbBx.Name = "membersCmbBx";
            this.membersCmbBx.Size = new System.Drawing.Size(244, 24);
            this.membersCmbBx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Member";
            // 
            // givingDateDateTimePicker
            // 
            this.givingDateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.givingDateDateTimePicker.Location = new System.Drawing.Point(77, 72);
            this.givingDateDateTimePicker.Name = "givingDateDateTimePicker";
            this.givingDateDateTimePicker.Size = new System.Drawing.Size(244, 22);
            this.givingDateDateTimePicker.TabIndex = 2;
            this.givingDateDateTimePicker.ValueChanged += new System.EventHandler(this.GivingDateDateTimePicker_ValueChanged);
            // 
            // submitBtn
            // 
            this.submitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submitBtn.Location = new System.Drawing.Point(172, 139);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(149, 30);
            this.submitBtn.TabIndex = 3;
            this.submitBtn.Text = "Add Offering";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.AddOfferingBtn_Click);
            // 
            // serviceCmbBox
            // 
            this.serviceCmbBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceCmbBox.FormattingEnabled = true;
            this.serviceCmbBox.Location = new System.Drawing.Point(77, 42);
            this.serviceCmbBox.Name = "serviceCmbBox";
            this.serviceCmbBox.Size = new System.Drawing.Size(244, 24);
            this.serviceCmbBox.TabIndex = 4;
            // 
            // AddUpdateGivingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 181);
            this.Controls.Add(this.serviceCmbBox);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.givingDateDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.membersCmbBx);
            this.Name = "AddUpdateGivingFrm";
            this.Text = "Add Giving";
            this.Load += new System.EventHandler(this.AddUpdateGivingFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox membersCmbBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker givingDateDateTimePicker;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.ComboBox serviceCmbBox;
    }
}