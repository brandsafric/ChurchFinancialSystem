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
    public partial class EditGivingFrm : Form
    {
        Giving giving;
        public EditGivingFrm(Giving giving)
        {
            this.giving = giving;
            InitializeComponent();
        }

        private void UpdateOfferingBtn_Click(object sender, EventArgs e)
        {
            if(giving == null)
            {
                MessageBox.Show("Offering is null!", "Null Offering", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            giving.Update((Member)membersCmbBx.SelectedValue, givingDateDateTimePicker.Value);
            this.Close();
        }

        public void LoadForm()
        {
            List<Member> members = new List<Member>();
            MembersController mc = new MembersController();
            members = mc.ShowAll();
            if (members.Count > 0)
            {
                int selectedIndex = 0;
                int index = 0;
                Dictionary<Member, string> membersLibrary = new Dictionary<Member, string>();
                foreach (Member member in members)
                {
                    membersLibrary.Add(member, member.firstName + " " + member.lastName);
                    if(giving.member.memberId == member.memberId)
                    {
                        selectedIndex = index;
                    }
                    index++;
                }
                membersCmbBx.DataSource = new BindingSource(membersLibrary, null);
                membersCmbBx.DisplayMember = "Value";
                membersCmbBx.ValueMember = "Key";
                membersCmbBx.SelectedIndex = selectedIndex;
            }

            givingDateDateTimePicker.Value = giving.givingDate;


        }

        private void EditGivingFrm_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
    }
}
