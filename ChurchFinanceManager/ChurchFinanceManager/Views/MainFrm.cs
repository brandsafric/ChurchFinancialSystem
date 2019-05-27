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
        }

        private void offeringTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GivingTypesFrm givingTypesFrm = new GivingTypesFrm();
            givingTypesFrm.ShowDialog();
        }

        private void offeringsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GivingFrm givingFrm = new GivingFrm();
            givingFrm.ShowDialog();
        }

        private void ServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServicesFrm servicesFrm = new ServicesFrm();
            servicesFrm.ShowDialog();
        }

        private void MembersToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            MembersFrm frmMembers = new MembersFrm();
            frmMembers.ShowDialog();
        }

        private void FamiliesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FamiliesFrm frmFamilies = new FamiliesFrm();
            frmFamilies.ShowDialog();
        }
    }
}
