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
    public partial class EditMemberFrm : Form
    {
        Member member;
        public EditMemberFrm(Member member)
        {
            InitializeComponent();
            this.member = member;
        }

        private void EditMember_Load(object sender, EventArgs e)
        {
            firstNameTxt.Text = member.firstName;
            middleNameTxt.Text = member.middleName;
            lastNameTxt.Text = member.lastName;
            birthdayDateTimePicker.Value = member.birthday;
            cityTxt.Text = member.city;
            isRegularChkBx.Checked = member.isRegular;
        }

        private void UpdateMemberBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to update " + member.firstName + " information?", 
                "Update Confirmation", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.No)
            {
                this.Close();
                return;
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                return;
            }
            else if (dialogResult == DialogResult.Yes)
            {
                
                member.Update(
                    firstNameTxt.Text,
                    middleNameTxt.Text,
                    lastNameTxt.Text,
                    cityTxt.Text,
                    birthdayDateTimePicker.Value,
                    isRegularChkBx.Checked);
                MessageBox.Show("Member Update Success", "Update Member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            
        }

        
    }
}
