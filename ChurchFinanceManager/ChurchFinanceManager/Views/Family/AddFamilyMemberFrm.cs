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
    public partial class AddFamilyMemberFrm : Form
    {
        public Family family;
        public AddFamilyMemberFrm(Family family)
        {
            this.family = family;
            InitializeComponent();
        }

        private void AddFamilyMemberFrm_Load(object sender, EventArgs e)
        {
            //loads memebers
            MembersController mc = new MembersController();
            List<Member> members = mc.ShowAllMembersNotInFamily();

            if (members.Count > 0)
            {
                List<KeyValuePair<int, string>> membersLibrary = new List<KeyValuePair<int, string>>();
                foreach (Member member in members)
                {
                    membersLibrary.Add(new KeyValuePair<int, string>(member.id, member.firstName + " " + member.lastName));
                }
                membersCmbBx.DataSource = membersLibrary.ToList<KeyValuePair<int, string>>();//new BindingSource(membersLibrary, null);
                membersCmbBx.DisplayMember = "Value";
                membersCmbBx.ValueMember = "Key";
             
                    membersCmbBx.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No members found! No member are currently registered or every member has already been registered to a family",
                    "Members Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            Member member = null;
            if (String.IsNullOrWhiteSpace(membersCmbBx.Text)) return;
            if (membersCmbBx.SelectedValue != null)
                member = new MembersController().Show((int)membersCmbBx.SelectedValue);
            if (member == null)
            {
                if (MessageBox.Show("Member does not exist. Do you want to add this member?", "Member was not found", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    == DialogResult.Yes
                        )
                    member = new Member(membersCmbBx.Text, "", "", DateTime.Now, "", true);
                else return;
            }
            family.AddMember(member);
            this.Close();
        }
    }
}
