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
            membersController.Add(
                new Param("firstName", firstNameTxt.Text),
               new Param("middleName", middleNameTxt.Text),
               new Param("lastName", lastNameTxt.Text),
               new Param("city", cityTxt.Text),
               new Param("birthday", birthdayDateTimePicker.Value),
               new Param("isRegular", isRegularChkBx.Checked)
               );
            this.Close();
        }

        private void AddMember_Load(object sender, EventArgs e)
        {
           
        }
    }
}
