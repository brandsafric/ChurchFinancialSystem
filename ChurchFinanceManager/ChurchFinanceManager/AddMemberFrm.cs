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
    public partial class AddMemberFrm : Form
    {
        public AddMemberFrm()
        {
            InitializeComponent();
        }

        private void AddMemberBtn_Click(object sender, EventArgs e)
        {
            MembersController membersController = new MembersController();
            membersController.AddMember(
                firstNameTxt.Text,
                middleNameTxt.Text,
                lastNameTxt.Text,
                cityTxt.Text,
                birthdayDateTimePicker.Value,
                isRegularChkBx.Checked);
            this.Close();
        }

        private void AddMember_Load(object sender, EventArgs e)
        {
           
        }
    }
}
