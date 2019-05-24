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
    public partial class EditGivingTypeFrm : Form
    {
        GivingType givingType;
        public EditGivingTypeFrm(GivingType givingType)
        {
            InitializeComponent();
            this.givingType = givingType;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to update " + givingType.title + "?",
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

                givingType.Update(
                    titleTxt.Text,
                    isRegularChkBx.Checked,
                    isActiveChkBx.Checked);
                MessageBox.Show("Giving Type Update Success", "Update Giving Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void EditGivingTypeFrm_Load(object sender, EventArgs e)
        {
            titleTxt.Text = givingType.title;
            isRegularChkBx.Checked = givingType.isRegular;
            isActiveChkBx.Checked = givingType.isActive;

        }
    }
}
