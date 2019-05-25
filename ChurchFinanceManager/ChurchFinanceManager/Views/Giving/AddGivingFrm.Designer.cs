namespace ChurchFinanceManager
{
    partial class AddGivingFrm
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
            this.AddOfferingBtn = new System.Windows.Forms.Button();
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
            this.membersCmbBx.Size = new System.Drawing.Size(200, 24);
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
            this.givingDateDateTimePicker.Location = new System.Drawing.Point(77, 42);
            this.givingDateDateTimePicker.Name = "givingDateDateTimePicker";
            this.givingDateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.givingDateDateTimePicker.TabIndex = 2;
            // 
            // AddOfferingBtn
            // 
            this.AddOfferingBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddOfferingBtn.Location = new System.Drawing.Point(128, 92);
            this.AddOfferingBtn.Name = "AddOfferingBtn";
            this.AddOfferingBtn.Size = new System.Drawing.Size(149, 30);
            this.AddOfferingBtn.TabIndex = 3;
            this.AddOfferingBtn.Text = "Add Offering";
            this.AddOfferingBtn.UseVisualStyleBackColor = true;
            this.AddOfferingBtn.Click += new System.EventHandler(this.AddOfferingBtn_Click);
            // 
            // AddGivingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 134);
            this.Controls.Add(this.AddOfferingBtn);
            this.Controls.Add(this.givingDateDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.membersCmbBx);
            this.Name = "AddGivingFrm";
            this.Text = "Add Giving";
            this.Load += new System.EventHandler(this.AddGivingFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox membersCmbBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker givingDateDateTimePicker;
        private System.Windows.Forms.Button AddOfferingBtn;
    }
}