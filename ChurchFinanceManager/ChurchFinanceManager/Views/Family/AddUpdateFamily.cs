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
    public partial class AddUpdateFamily : Form
    {
        bool isUpdate;
        Family family;

        public AddUpdateFamily(bool isUpdate, Family family  = null)
        {
            if (isUpdate && family == null) this.Close();
            this.isUpdate = isUpdate;
            this.family = family;
            InitializeComponent();
            submitBtn.Text = isUpdate ? "Submit" : "Create";
            this.Text = isUpdate ? "Update Family" : "Create New Family";
            this.AcceptButton = submitBtn;
            familyNameTxt.Text = isUpdate ? family.familyName : "";
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(familyNameTxt.Text)) return;

            if (isUpdate)
                family.Update(familyNameTxt.Text);
            else
                new Family(familyNameTxt.Text);

            this.Close();
        }
    }
}
