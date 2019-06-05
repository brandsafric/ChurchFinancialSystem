namespace ChurchFinanceManager
{
    partial class ReportsFrm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FinanceSet = new ChurchFinanceManager.FinanceSet();
            this.GivingItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GivingItemsTableAdapter = new ChurchFinanceManager.FinanceSetTableAdapters.GivingItemsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.FinanceSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GivingItemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Givings";
            reportDataSource1.Value = this.GivingItemsBindingSource;
            reportDataSource2.Name = "MonthlyOffering";
            reportDataSource2.Value = this.GivingItemsBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "ChurchFinanceManager.testReport.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(800, 450);
            this.reportViewer2.TabIndex = 0;
            // 
            // FinanceSet
            // 
            this.FinanceSet.DataSetName = "FinanceSet";
            this.FinanceSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GivingItemsBindingSource
            // 
            this.GivingItemsBindingSource.DataMember = "GivingItems";
            this.GivingItemsBindingSource.DataSource = this.FinanceSet;
            // 
            // GivingItemsTableAdapter
            // 
            this.GivingItemsTableAdapter.ClearBeforeFill = true;
            // 
            // ReportsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer2);
            this.Name = "ReportsFrm";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FinanceSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GivingItemsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource GivingItemsBindingSource;
        private FinanceSet FinanceSet;
        private FinanceSetTableAdapters.GivingItemsTableAdapter GivingItemsTableAdapter;
    }
}