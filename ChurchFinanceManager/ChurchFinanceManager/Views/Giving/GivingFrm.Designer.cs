namespace ChurchFinanceManager
{
    partial class GivingFrm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.servicesCmbBx = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalOfferingTxt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.givingDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddGivingBtn = new System.Windows.Forms.Button();
            this.givingDataGridView = new System.Windows.Forms.DataGridView();
            this.totalTxt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.givingItemsDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.giverNameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteGivingItemBtn = new System.Windows.Forms.Button();
            this.updateGivingItemBtn = new System.Windows.Forms.Button();
            this.addGivingItemBtn = new System.Windows.Forms.Button();
            this.givingItemsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.givingDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.givingItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.servicesCmbBx);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.totalOfferingTxt);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.givingDateDateTimePicker);
            this.splitContainer1.Panel1.Controls.Add(this.DeleteBtn);
            this.splitContainer1.Panel1.Controls.Add(this.EditBtn);
            this.splitContainer1.Panel1.Controls.Add(this.AddGivingBtn);
            this.splitContainer1.Panel1.Controls.Add(this.givingDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.totalTxt);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.givingItemsDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.giverNameTxt);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.deleteGivingItemBtn);
            this.splitContainer1.Panel2.Controls.Add(this.updateGivingItemBtn);
            this.splitContainer1.Panel2.Controls.Add(this.addGivingItemBtn);
            this.splitContainer1.Panel2.Controls.Add(this.givingItemsDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(840, 591);
            this.splitContainer1.SplitterDistance = 474;
            this.splitContainer1.TabIndex = 0;
            // 
            // servicesCmbBx
            // 
            this.servicesCmbBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.servicesCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.servicesCmbBx.FormattingEnabled = true;
            this.servicesCmbBx.Location = new System.Drawing.Point(86, 21);
            this.servicesCmbBx.Name = "servicesCmbBx";
            this.servicesCmbBx.Size = new System.Drawing.Size(326, 24);
            this.servicesCmbBx.TabIndex = 19;
            this.servicesCmbBx.SelectedIndexChanged += new System.EventHandler(this.ServicesCmbBx_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Service";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Date";
            // 
            // totalOfferingTxt
            // 
            this.totalOfferingTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalOfferingTxt.AutoSize = true;
            this.totalOfferingTxt.Location = new System.Drawing.Point(365, 565);
            this.totalOfferingTxt.Name = "totalOfferingTxt";
            this.totalOfferingTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalOfferingTxt.Size = new System.Drawing.Size(36, 17);
            this.totalOfferingTxt.TabIndex = 16;
            this.totalOfferingTxt.Text = "0.00";
            this.totalOfferingTxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 565);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "TOTAL OFFERING:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Offerings";
            // 
            // givingDateDateTimePicker
            // 
            this.givingDateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.givingDateDateTimePicker.Location = new System.Drawing.Point(86, 55);
            this.givingDateDateTimePicker.Name = "givingDateDateTimePicker";
            this.givingDateDateTimePicker.Size = new System.Drawing.Size(326, 22);
            this.givingDateDateTimePicker.TabIndex = 4;
            this.givingDateDateTimePicker.ValueChanged += new System.EventHandler(this.GivingDateDateTimePicker_ValueChanged);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(304, 83);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(108, 34);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(190, 83);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(108, 34);
            this.EditBtn.TabIndex = 2;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddGivingBtn
            // 
            this.AddGivingBtn.Location = new System.Drawing.Point(85, 83);
            this.AddGivingBtn.Name = "AddGivingBtn";
            this.AddGivingBtn.Size = new System.Drawing.Size(99, 34);
            this.AddGivingBtn.TabIndex = 1;
            this.AddGivingBtn.Text = "Add";
            this.AddGivingBtn.UseVisualStyleBackColor = true;
            this.AddGivingBtn.Click += new System.EventHandler(this.AddGivingBtn_Click);
            // 
            // givingDataGridView
            // 
            this.givingDataGridView.AllowUserToAddRows = false;
            this.givingDataGridView.AllowUserToDeleteRows = false;
            this.givingDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.givingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.givingDataGridView.Location = new System.Drawing.Point(12, 128);
            this.givingDataGridView.MultiSelect = false;
            this.givingDataGridView.Name = "givingDataGridView";
            this.givingDataGridView.ReadOnly = true;
            this.givingDataGridView.RowHeadersWidth = 51;
            this.givingDataGridView.RowTemplate.Height = 24;
            this.givingDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.givingDataGridView.Size = new System.Drawing.Size(450, 408);
            this.givingDataGridView.TabIndex = 0;
            this.givingDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GivingDataGridView_CellContentClick);
            // 
            // totalTxt
            // 
            this.totalTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalTxt.AutoSize = true;
            this.totalTxt.Location = new System.Drawing.Point(237, 565);
            this.totalTxt.Name = "totalTxt";
            this.totalTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalTxt.Size = new System.Drawing.Size(36, 17);
            this.totalTxt.TabIndex = 14;
            this.totalTxt.Text = "0.00";
            this.totalTxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 565);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "TOTAL AMOUNT:";
            // 
            // givingItemsDateTimePicker
            // 
            this.givingItemsDateTimePicker.Enabled = false;
            this.givingItemsDateTimePicker.Location = new System.Drawing.Point(112, 59);
            this.givingItemsDateTimePicker.Name = "givingItemsDateTimePicker";
            this.givingItemsDateTimePicker.Size = new System.Drawing.Size(228, 22);
            this.givingItemsDateTimePicker.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date Offered";
            // 
            // giverNameTxt
            // 
            this.giverNameTxt.Enabled = false;
            this.giverNameTxt.Location = new System.Drawing.Point(112, 21);
            this.giverNameTxt.Name = "giverNameTxt";
            this.giverNameTxt.Size = new System.Drawing.Size(228, 22);
            this.giverNameTxt.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Offering Details";
            // 
            // deleteGivingItemBtn
            // 
            this.deleteGivingItemBtn.Location = new System.Drawing.Point(247, 88);
            this.deleteGivingItemBtn.Name = "deleteGivingItemBtn";
            this.deleteGivingItemBtn.Size = new System.Drawing.Size(70, 34);
            this.deleteGivingItemBtn.TabIndex = 8;
            this.deleteGivingItemBtn.Text = "Delete";
            this.deleteGivingItemBtn.UseVisualStyleBackColor = true;
            this.deleteGivingItemBtn.Click += new System.EventHandler(this.DeleteGivingItemBtn_Click);
            // 
            // updateGivingItemBtn
            // 
            this.updateGivingItemBtn.Location = new System.Drawing.Point(186, 88);
            this.updateGivingItemBtn.Name = "updateGivingItemBtn";
            this.updateGivingItemBtn.Size = new System.Drawing.Size(55, 34);
            this.updateGivingItemBtn.TabIndex = 7;
            this.updateGivingItemBtn.Text = "Edit";
            this.updateGivingItemBtn.UseVisualStyleBackColor = true;
            this.updateGivingItemBtn.Click += new System.EventHandler(this.UpdateGivingItemBtn_Click);
            // 
            // addGivingItemBtn
            // 
            this.addGivingItemBtn.Location = new System.Drawing.Point(124, 88);
            this.addGivingItemBtn.Name = "addGivingItemBtn";
            this.addGivingItemBtn.Size = new System.Drawing.Size(56, 34);
            this.addGivingItemBtn.TabIndex = 6;
            this.addGivingItemBtn.Text = "Add";
            this.addGivingItemBtn.UseVisualStyleBackColor = true;
            this.addGivingItemBtn.Click += new System.EventHandler(this.AddGivingItemBtn_Click);
            // 
            // givingItemsDataGridView
            // 
            this.givingItemsDataGridView.AllowUserToAddRows = false;
            this.givingItemsDataGridView.AllowUserToDeleteRows = false;
            this.givingItemsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.givingItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.givingItemsDataGridView.Location = new System.Drawing.Point(14, 128);
            this.givingItemsDataGridView.MultiSelect = false;
            this.givingItemsDataGridView.Name = "givingItemsDataGridView";
            this.givingItemsDataGridView.ReadOnly = true;
            this.givingItemsDataGridView.RowHeadersWidth = 51;
            this.givingItemsDataGridView.RowTemplate.Height = 24;
            this.givingItemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.givingItemsDataGridView.Size = new System.Drawing.Size(336, 348);
            this.givingItemsDataGridView.TabIndex = 5;
            // 
            // GivingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 591);
            this.Controls.Add(this.splitContainer1);
            this.Name = "GivingFrm";
            this.Text = "Offerings";
            this.Load += new System.EventHandler(this.GivingFrm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.givingDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.givingItemsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddGivingBtn;
        private System.Windows.Forms.DataGridView givingDataGridView;
        private System.Windows.Forms.DateTimePicker givingDateDateTimePicker;
        private System.Windows.Forms.Button deleteGivingItemBtn;
        private System.Windows.Forms.Button updateGivingItemBtn;
        private System.Windows.Forms.Button addGivingItemBtn;
        private System.Windows.Forms.DataGridView givingItemsDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox giverNameTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker givingItemsDateTimePicker;
        private System.Windows.Forms.Label totalTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalOfferingTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox servicesCmbBx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
    }
}