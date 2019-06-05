using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChurchFinanceManager
{
    public partial class ReportsFrm : Form
    {
        public ReportsFrm()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FinanceSet.GivingItems' table. You can move, or remove it, as needed

            
            this.GivingItemsTableAdapter.Fill(this.FinanceSet.GivingItems);

            this.reportViewer2.RefreshReport();
        }
    }
}
