﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChurchFinanceManager
{
    public partial class MembersFrm : Form
    {
        List<Member> members = new List<Member>();
        public MembersFrm()
        {
            InitializeComponent();
            Console.WriteLine("Open Members");
       
        }

        private void FrmMembers_Load(object sender, EventArgs e)
        {
            LoadMembers();
        }


        public void LoadMembers()
        {
            MembersController membersController = new MembersController();
            members = membersController.ShowAll();
            membersDataGridView.Rows.Clear();
            membersDataGridView.Columns.Clear();
            membersDataGridView.Refresh();
            //setup
                //columns
                membersDataGridView.Columns.Add("memberId", "ID");
                membersDataGridView.Columns.Add("firstName", "First Name");
                membersDataGridView.Columns.Add("middleName", "Middle Name");
                membersDataGridView.Columns.Add("lastName", "Last Name");
                membersDataGridView.Columns.Add("birthday", "Birthday");
                membersDataGridView.Columns.Add("age", "Age");
                membersDataGridView.Columns.Add("city", "City");
                membersDataGridView.Columns.Add("isRegular", "Regular Member");

                membersDataGridView.Columns["memberId"].Visible = false;
                //rows
                if (members.Count > 0) {
                    foreach (Member member in members) {
                    

                        membersDataGridView.Rows.Add(
                            member.id,
                            member.firstName,
                            member.middleName,
                            member.lastName,
                            member.birthday.ToString("MMMM dd, yyyy"),
                            member.GetAge(),
                            member.city,
                            (member.isRegular?"Yes":"No"));
                    }
                }
                else {
                    MessageBox.Show("No members are currently registered in the system. Please add a member!", "No Member Found!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

        }
        
        private void addMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdateMemberFrm addMember = new AddUpdateMemberFrm(false);
            addMember.FormClosing += new FormClosingEventHandler(this.MemberUpdated); 
            addMember.ShowDialog();
        }
        private void MemberUpdated(object sender, FormClosingEventArgs e)
        {
            LoadMembers();
        }
        
        private void editMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (membersDataGridView.Rows.Count == 0) return;
            int id = Convert.ToInt32(membersDataGridView.SelectedRows[0].Cells["memberId"].Value);
            Member member = new MembersController().Show(id);
            AddUpdateMemberFrm editMember = new AddUpdateMemberFrm(true,member);
            editMember.FormClosing += new FormClosingEventHandler(this.MemberUpdated); 
            editMember.ShowDialog();

        }

        private void deleteMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (membersDataGridView.Rows.Count == 0) return;
            int id = Convert.ToInt32(membersDataGridView.SelectedRows[0].Cells["memberId"].Value);

            MembersController membersController = new MembersController();

            Member member = membersController.Show(id);

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete Member:" + member.firstName + "\n NOTE: this action cannot be undone!",
                "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            else if (dialogResult == DialogResult.Yes)
            {
                member.Delete();
                MessageBox.Show("Member Deleted from records!", "Member Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMembers();
            }
            
        }
        
    }
}
