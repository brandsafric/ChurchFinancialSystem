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
        public Session currentSession;
        public frmDashboard(Session session)
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(frmDashboard_Closing);
            this.currentSession = session;
        }
        #region Logging Out
        void frmDashboard_Closing(object sender, FormClosingEventArgs e)
        {
            DialogResult window = MessageBox.Show(
        "You are about to log out from this session.",
        "Log Out Confirmation",
        MessageBoxButtons.YesNo);

            if (window == DialogResult.No)
                e.Cancel = true;
            else
            LogOut();
        }
        void LogOut()
        {
            currentSession.EndSession();
        }
        #endregion
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
            GivingFrm givingFrm = new GivingFrm(currentSession);
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

        private void UsersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            UsersFrm frmUsers = new UsersFrm();
            frmUsers.ShowDialog();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            sessionIdLbl.Text = $"Session No.:{currentSession.id}";
            userLbl.Text = $"User:{currentSession.user.name}";
        }

    }
}
