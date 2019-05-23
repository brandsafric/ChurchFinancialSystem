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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMembers frmMembers = new frmMembers();
            frmMembers.ShowDialog();
        }

        private void offeringTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GivingTypesFrm givingTypesFrm = new GivingTypesFrm();
            givingTypesFrm.ShowDialog();
        }

 

    }
}
