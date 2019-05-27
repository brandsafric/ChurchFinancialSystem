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
    public partial class AddUpdateMemberFrm : Form
    {
        private bool isUpdate;
        private Member member;
        public AddUpdateMemberFrm(bool isUpdate,Member member = null)
        {
            this.isUpdate = isUpdate;
            this.member = member ?? null;
            InitializeComponent();
            this.Text = isUpdate ? "Edit Member" : "Add Member";
            this.AddUpdateMemberBtn.Text = isUpdate?"Submit":"Add Member";
            this.AcceptButton = AddUpdateMemberBtn;
        }

        private void AddMemberBtn_Click(object sender, EventArgs e)
        {
            if (isUpdate)
                member.Update(
                firstNameTxt.Text,
                middleNameTxt.Text,
                lastNameTxt.Text,
                birthdayDateTimePicker.Value,
                cityTxt.Text,
                isRegularChkBx.Checked);
            else
                new Member(
                    firstNameTxt.Text,
                    middleNameTxt.Text,
                    lastNameTxt.Text,
                    birthdayDateTimePicker.Value,
                    cityTxt.Text,
                    isRegularChkBx.Checked
                    );
            this.Close();
        }

        private void AddMember_Load(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                firstNameTxt.Text = member.firstName;
                middleNameTxt.Text = member.middleName;
                lastNameTxt.Text = member.lastName;
                birthdayDateTimePicker.Value = member.birthday;
                cityTxt.Text = member.city;
                isRegularChkBx.Checked = member.isRegular;
            }
        }
    }
}
