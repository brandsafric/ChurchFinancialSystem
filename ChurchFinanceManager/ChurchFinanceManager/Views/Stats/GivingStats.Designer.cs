namespace ChurchFinanceManager
{
    partial class GivingStatsFrm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.displayChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateRangeCmbBx = new System.Windows.Forms.ComboBox();
            this.periodCmbBx = new System.Windows.Forms.ComboBox();
            this.totalTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.givingTypesCmbBx = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.displayChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayChart
            // 
            chartArea1.Name = "ChartArea1";
            this.displayChart.ChartAreas.Add(chartArea1);
            this.displayChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.displayChart.Legends.Add(legend1);
            this.displayChart.Location = new System.Drawing.Point(0, 0);
            this.displayChart.Name = "displayChart";
            this.displayChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.displayChart.Series.Add(series1);
            this.displayChart.Size = new System.Drawing.Size(729, 330);
            this.displayChart.TabIndex = 0;
            this.displayChart.Text = "chart";
            this.displayChart.Click += new System.EventHandler(this.Chart1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.totalTxt);
            this.splitContainer1.Panel1.Controls.Add(this.givingTypesCmbBx);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.periodCmbBx);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.dateRangeCmbBx);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.displayChart);
            this.splitContainer1.Size = new System.Drawing.Size(729, 450);
            this.splitContainer1.SplitterDistance = 116;
            this.splitContainer1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Range";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Periodicity";
            // 
            // dateRangeCmbBx
            // 
            this.dateRangeCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dateRangeCmbBx.FormattingEnabled = true;
            this.dateRangeCmbBx.Location = new System.Drawing.Point(131, 45);
            this.dateRangeCmbBx.Name = "dateRangeCmbBx";
            this.dateRangeCmbBx.Size = new System.Drawing.Size(222, 24);
            this.dateRangeCmbBx.TabIndex = 1;
            this.dateRangeCmbBx.SelectedIndexChanged += new System.EventHandler(this.DateRangeCmbBx_SelectedIndexChanged);
            // 
            // periodCmbBx
            // 
            this.periodCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.periodCmbBx.FormattingEnabled = true;
            this.periodCmbBx.Items.AddRange(new object[] {
            "Yearly",
            "Monthly"});
            this.periodCmbBx.Location = new System.Drawing.Point(131, 15);
            this.periodCmbBx.Name = "periodCmbBx";
            this.periodCmbBx.Size = new System.Drawing.Size(222, 24);
            this.periodCmbBx.TabIndex = 0;
            this.periodCmbBx.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // totalTxt
            // 
            this.totalTxt.Location = new System.Drawing.Point(579, 12);
            this.totalTxt.Name = "totalTxt";
            this.totalTxt.ReadOnly = true;
            this.totalTxt.Size = new System.Drawing.Size(138, 22);
            this.totalTxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Offerings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Offering Type";
            // 
            // givingTypesCmbBx
            // 
            this.givingTypesCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.givingTypesCmbBx.FormattingEnabled = true;
            this.givingTypesCmbBx.Location = new System.Drawing.Point(131, 75);
            this.givingTypesCmbBx.Name = "givingTypesCmbBx";
            this.givingTypesCmbBx.Size = new System.Drawing.Size(222, 24);
            this.givingTypesCmbBx.TabIndex = 4;
            this.givingTypesCmbBx.SelectedIndexChanged += new System.EventHandler(this.GivingTypesCmbBx_SelectedIndexChanged);
            // 
            // GivingStatsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "GivingStatsFrm";
            this.Text = "GivingStats";
            this.Load += new System.EventHandler(this.GivingStatsFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayChart)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart displayChart;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dateRangeCmbBx;
        private System.Windows.Forms.ComboBox periodCmbBx;
        private System.Windows.Forms.TextBox totalTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox givingTypesCmbBx;
    }
}