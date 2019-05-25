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
            GivingTypesController givingTypesController = new GivingTypesController();
            givingTypesController.Add(
                new Param("title",titleTxt.Text),
                new Param("isRegular", isRegularChkBx.Checked),
                new Param("isActive", isActiveChkBx.Checked));
            this.Close();
           
        }

     
    }
}
