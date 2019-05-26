namespace ChurchFinanceManager
{
    partial class EditGivingItemFrm
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
            this.amountTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddOfferingBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.givingTypesCmbBx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // amountTxt
            // 
            this.amountTxt.Location = new System.Drawing.Point(85, 65);
            this.amountTxt.Name = "amountTxt";
            this.amountTxt.Size = new System.Drawing.Size(199, 22);
            this.amountTxt.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Amount";
            // 
            // AddOfferingBtn
            // 
            this.AddOfferingBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddOfferingBtn.Location = new System.Drawing.Point(135, 111);
            this.AddOfferingBtn.Name = "AddOfferingBtn";
            this.AddOfferingBtn.Size = new System.Drawing.Size(149, 30);
            this.AddOfferingBtn.TabIndex = 12;
            this.AddOfferingBtn.Text = "Update Item";
            this.AddOfferingBtn.UseVisualStyleBackColor = true;
            this.AddOfferingBtn.Click += new System.EventHandler(this.AddOfferingBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Type";
            // 
            // givingTypesCmbBx
            // 
            this.givingTypesCmbBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.givingTypesCmbBx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.givingTypesCmbBx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.givingTypesCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.givingTypesCmbBx.FormattingEnabled = true;
            this.givingTypesCmbBx.Location = new System.Drawing.Point(85, 26);
            this.givingTypesCmbBx.Name = "givingTypesCmbBx";
            this.givingTypesCmbBx.Size = new System.Drawing.Size(200, 24);
            this.givingTypesCmbBx.TabIndex = 10;
            // 
            // EditGivingItemFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 166);
            this.Controls.Add(this.amountTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddOfferingBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.givingTypesCmbBx);
            this.Name = "EditGivingItemFrm";
            this.Text = "Edit Offering Item";
            this.Load += new System.EventHandler(this.EditOfferingItemFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox amountTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddOfferingBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox givingTypesCmbBx;
    }
}