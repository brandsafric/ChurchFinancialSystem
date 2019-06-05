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

        GivingTypesFrm givingTypesFrm;
        GivingFrm givingFrm;
        ServicesFrm servicesFrm;
        MembersFrm frmMembers;
        FamiliesFrm frmFamilies;
        UsersFrm frmUsers;

        //Stats
        GivingStatsFrm frmGivingStats;
        public frmDashboard()
        {
            if(Session.singleton == null)
            {
                MessageBox.Show("Cannot locate session", "Fatal error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(frmDashboard_Closing);
            this.currentSession = Session.singleton;
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
           if(givingTypesFrm == null)
            {

                givingTypesFrm = new GivingTypesFrm();
                givingTypesFrm.MdiParent = this;
                givingTypesFrm.FormClosed += GivingTypesFrm_FormClosed;
                givingTypesFrm.Show();
            }
            else
            {
                givingTypesFrm.Activate();
            }
        }

        private void GivingTypesFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            givingTypesFrm = null;
        }

        private void offeringsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (givingFrm == null)
            {

                givingFrm = new GivingFrm(currentSession);
                givingFrm.MdiParent = this;
                givingFrm.FormClosed += GivingFrm_FormClosed;
                givingFrm.Show();
            }
            else
            {
                givingFrm.Activate();
            }
        }

        private void GivingFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            givingFrm = null;
        }

        private void ServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (servicesFrm == null)
            {

                servicesFrm = new ServicesFrm();
                servicesFrm.MdiParent = this;
                servicesFrm.FormClosed += ServicesFrm_FormClosed;
                servicesFrm.Show();
            }
            else
            {
                servicesFrm.Activate();
            }
        }

        private void ServicesFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            servicesFrm = null;
        }

        private void MembersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frmMembers == null)
            {

                frmMembers = new MembersFrm();
                frmMembers.MdiParent = this;
                frmMembers.FormClosed += FrmMembers_FormClosed; ;
                frmMembers.Show();
            }
            else
            {
                frmMembers.Activate();
            }

        }

        private void FrmMembers_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMembers = null;
        }

        private void FamiliesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmFamilies == null)
            {

                frmFamilies = new FamiliesFrm();
                frmFamilies.MdiParent = this;
                frmFamilies.FormClosed += FrmFamilies_FormClosed;
                frmFamilies.Show();
            }
            else
            {
                frmFamilies.Activate();
            }

        }

        private void FrmFamilies_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmFamilies = null;
        }

        private void UsersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (frmUsers == null)
            {

                frmUsers = new UsersFrm();
                frmUsers.MdiParent = this;
                frmUsers.FormClosed += FrmUsers_FormClosed;
                frmUsers.Show();
            }
            else
            {
                frmUsers.Activate();
            }
        }

        private void FrmUsers_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmUsers = null;
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            sessionIdLbl.Text = $"Session No.:{currentSession.id}";
            userLbl.Text = $"User:{currentSession.user.name}";
            ManagerRoles();
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        RolesController rc = new RolesController();
        public void ManagerRoles()
        {
            membersToolStripMenuItem1.Visible = (currentSession.user.haveRole(rc.GetRoleByTag("members")));
            familiesToolStripMenuItem.Visible = (currentSession.user.haveRole(rc.GetRoleByTag("families")));
            offeringTypesToolStripMenuItem.Visible = (currentSession.user.haveRole(rc.GetRoleByTag("givingTypes")));
            offeringsToolStripMenuItem.Visible = (currentSession.user.haveRole(rc.GetRoleByTag("givings")));
            servicesToolStripMenuItem.Visible = (currentSession.user.haveRole(rc.GetRoleByTag("services")));
            usersToolStripMenuItem.Visible = (currentSession.user.haveRole(rc.GetRoleByTag("users")));
            statisticsToolStripMenuItem.Visible = (currentSession.user.haveRole(rc.GetRoleByTag("statistics")));
        }

        private void AccountDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserDetailsFrm userDetailsFrm = new UserDetailsFrm(currentSession.user);
            userDetailsFrm.ShowDialog();
        }

        private void EditAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminAddUpdateUserFrm adminAddUpdateUserFrm = new AdminAddUpdateUserFrm(true, currentSession.user);
            adminAddUpdateUserFrm.FormClosing += AdminAddUpdateUserFrm_FormClosing;
            adminAddUpdateUserFrm.ShowDialog();
        }

        private void AdminAddUpdateUserFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            currentSession.user = new User(currentSession.user.id);
            userLbl.Text = $"User:{currentSession.user.name}";

        }

        private void ReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportsFrm reportsFrm = new ReportsFrm();
            reportsFrm.ShowDialog();
        }

        private void OfferingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frmGivingStats == null)
            {

                frmGivingStats = new GivingStatsFrm();
                frmGivingStats.MdiParent = this;
                frmGivingStats.FormClosed += FrmUsers_FormClosed;
                frmGivingStats.Show();
            }
            else
            {
                frmGivingStats.Activate();
            }
        }

        private void StatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
