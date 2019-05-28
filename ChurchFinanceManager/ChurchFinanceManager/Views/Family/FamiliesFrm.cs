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
    public partial class FamiliesFrm : Form
    {
        List<Family> families = new List<Family>();
        public FamiliesFrm()
        {
            InitializeComponent();
        }

        private void FamiliesFrm_Load(object sender, EventArgs e)
        {
            LoadFamilies();
            LoadFamilyMembers();
        }
        public void LoadFamilies()
        {
            FamiliesController fc = new FamiliesController();
            families = fc.ShowAll();
            //setup
            familiesDataGridView.Rows.Clear();
            familiesDataGridView.Columns.Clear();
            familiesDataGridView.Refresh();
            //columns

            familiesDataGridView.Columns.Add("familyId", "ID");
            familiesDataGridView.Columns.Add("familyName", "Family Name");

            familiesDataGridView.Columns["familyId"].Visible = false;
            //rows
            if (families.Count > 0)
            {
                foreach (Family family in families)
                {


                    familiesDataGridView.Rows.Add(
                        family.id,
                        family.familyName);
                }
            }
            else
            {
                MessageBox.Show("No families are currently registered in the system. Please add a families!", "No Family Found!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        public void LoadFamilyMembers()
        {
            if (familiesDataGridView.Rows.Count <= 0) return;
            if (familiesDataGridView.SelectedRows.Count <= 0) return;
            FamiliesController fc = new FamiliesController();
            List<Member> members = fc.Show((int)familiesDataGridView.SelectedRows[0].Cells["familyId"].Value).Members();
            //setup
            membersDataGridView.Rows.Clear();
            membersDataGridView.Columns.Clear();
            membersDataGridView.Refresh();
            //columns

            membersDataGridView.Columns.Add("memberId", "ID");
            membersDataGridView.Columns.Add("name", "Name");

            membersDataGridView.Columns["memberId"].Visible = false;
            //rows
            if (members.Count > 0)
            {
                foreach (Member member in members)
                {


                    membersDataGridView.Rows.Add(
                        member.id,
                        member.FullName());
                }
            }
            

        }
        private void FamilyUpdated(object sender, FormClosingEventArgs e)
        {
            LoadFamilies();
        }

        private void FamilyMembersUpdated(object sender, FormClosingEventArgs e)
        {
            LoadFamilyMembers();
        }
        
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdateFamily addUpdateFamily = new AddUpdateFamily(false);
            addUpdateFamily.FormClosing += new FormClosingEventHandler(this.FamilyUpdated);

            addUpdateFamily.ShowDialog();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (familiesDataGridView.Rows.Count <= 0) return;
            if (familiesDataGridView.SelectedRows.Count <= 0) return;
            AddUpdateFamily addUpdateFamily = new AddUpdateFamily(true,new FamiliesController().Show((int)familiesDataGridView.SelectedRows[0].Cells["familyId"].Value));
            addUpdateFamily.FormClosing += new FormClosingEventHandler(this.FamilyUpdated);

            addUpdateFamily.ShowDialog();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (familiesDataGridView.Rows.Count <= 0) return;
            if (familiesDataGridView.SelectedRows.Count <= 0) return;
            if(MessageBox.Show("Are you sure you want to delete family?","Delete Action Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            new FamiliesController().Delete((int)familiesDataGridView.SelectedRows[0].Cells["familyId"].Value);
            LoadFamilies();
        }

        private void BtnAddMember_Click(object sender, EventArgs e)
        {
            FamiliesController fc = new FamiliesController();
            if (familiesDataGridView.Rows.Count <= 0) return;
            if (familiesDataGridView.SelectedRows.Count <= 0) return;
            AddFamilyMemberFrm addFamilyMember = new AddFamilyMemberFrm(fc.Show((int)familiesDataGridView.SelectedRows[0].Cells["familyId"].Value));
            addFamilyMember.FormClosing += new FormClosingEventHandler(this.FamilyMembersUpdated);

            addFamilyMember.ShowDialog();

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (familiesDataGridView.Rows.Count <= 0) return;
            if (familiesDataGridView.SelectedRows.Count <= 0) return;

            if (membersDataGridView.Rows.Count <= 0) return;
            if (membersDataGridView.SelectedRows.Count <= 0) return;


            FamiliesController fc = new FamiliesController();
            MembersController mc = new MembersController();
            Family family = fc.Show((int)familiesDataGridView.SelectedRows[0].Cells["familyId"].Value);
            Member member = mc.Show((int)membersDataGridView.SelectedRows[0].Cells["memberId"].Value);
            if (MessageBox.Show($"Delete member:{member.firstName} from family:{family.familyName}?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
                family.DeleteMember(member);
            LoadFamilyMembers();
        }
        
        private void FamiliesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (familiesDataGridView.Rows.Count <= 0) return;
            if (familiesDataGridView.SelectedRows.Count <= 0) return;

            LoadFamilyMembers();
        }

    }
}
