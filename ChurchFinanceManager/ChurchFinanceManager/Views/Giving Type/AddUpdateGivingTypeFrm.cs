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
    public partial class AddUpdateGivingTypeFrm : Form
    {
        bool isUpdate;
        GivingType givingType;
        public AddUpdateGivingTypeFrm(bool isUpdate,GivingType gt = null)
        {
            this.isUpdate = isUpdate;
            this.givingType = gt;
            InitializeComponent();
            this.Text = isUpdate ? "Update Offering Type" : "Add Offering Type";
            this.createBtn.Text = isUpdate ? "Update" : "Create";
            this.AcceptButton = createBtn;
            if (isUpdate)
            {
                titleTxt.Text = gt.title;
                isRegularChkBx.Checked = gt.isRegular;
                isActiveChkBx.Checked = gt.isActive;
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if(isUpdate)
                givingType.Update (titleTxt.Text, isRegularChkBx.Checked, isActiveChkBx.Checked);
                else
                        new GivingType(titleTxt.Text, isRegularChkBx.Checked, isActiveChkBx.Checked);
            this.Close();



        }
            

     
    }
}
