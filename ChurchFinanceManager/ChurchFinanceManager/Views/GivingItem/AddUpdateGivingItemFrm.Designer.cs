namespace ChurchFinanceManager
{
    partial class AddUpdateGivingItemFrm
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
            this.AddOfferingBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.givingTypesCmbBx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.amountTxt = new System.Windows.Forms.TextBox();
            this.noteTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddOfferingBtn
            // 
            this.AddOfferingBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddOfferingBtn.Location = new System.Drawing.Point(137, 154);
            this.AddOfferingBtn.Name = "AddOfferingBtn";
            this.AddOfferingBtn.Size = new System.Drawing.Size(149, 30);
            this.AddOfferingBtn.TabIndex = 7;
            this.AddOfferingBtn.Text = "Add Item";
            this.AddOfferingBtn.UseVisualStyleBackColor = true;
            this.AddOfferingBtn.Click += new System.EventHandler(this.AddOfferingBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 5;
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
            this.givingTypesCmbBx.Location = new System.Drawing.Point(87, 30);
            this.givingTypesCmbBx.Name = "givingTypesCmbBx";
            this.givingTypesCmbBx.Size = new System.Drawing.Size(200, 24);
            this.givingTypesCmbBx.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Amount";
            // 
            // amountTxt
            // 
            this.amountTxt.Location = new System.Drawing.Point(87, 69);
            this.amountTxt.Name = "amountTxt";
            this.amountTxt.Size = new System.Drawing.Size(199, 22);
            this.amountTxt.TabIndex = 9;
            // 
            // noteTxt
            // 
            this.noteTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteTxt.Location = new System.Drawing.Point(87, 120);
            this.noteTxt.Name = "noteTxt";
            this.noteTxt.Size = new System.Drawing.Size(200, 22);
            this.noteTxt.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Note";
            // 
            // AddUpdateGivingItemFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 205);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.noteTxt);
            this.Controls.Add(this.amountTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddOfferingBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.givingTypesCmbBx);
            this.Name = "AddUpdateGivingItemFrm";
            this.Text = "Add Offering Item";
            this.Load += new System.EventHandler(this.AddGivingItemFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddOfferingBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox givingTypesCmbBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amountTxt;
        private System.Windows.Forms.TextBox noteTxt;
        private System.Windows.Forms.Label label3;
    }
}