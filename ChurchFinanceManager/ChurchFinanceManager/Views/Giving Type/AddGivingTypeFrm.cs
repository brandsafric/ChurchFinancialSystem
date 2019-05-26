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
    public partial class AddGivingTypeFrm : Form
    {
        public AddGivingTypeFrm()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            GivingType gt = new GivingType(titleTxt.Text, isRegularChkBx.Checked, isActiveChkBx.Checked);
            this.Close();
           
        }

     
    }
}
