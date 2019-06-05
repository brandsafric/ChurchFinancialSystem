using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChurchFinanceManager
{
    public partial class AddUpdateGivingItemFrm : Form
    {
        Giving giving;
        GivingItem givingItem;
        bool isUpdate;
        public AddUpdateGivingItemFrm(bool isUpdate,Giving g,GivingItem gi = null)
        {  
            this.giving = g;
            this.givingItem = gi;
            this.isUpdate = isUpdate;
            Console.WriteLine(g.member.FullName());
            InitializeComponent();
            this.Text = isUpdate ? "Update Offering Item" : "Add Offering Item";
            this.AddOfferingBtn.Text = isUpdate ? "Update Item" : "Add Item";
            this.AcceptButton = AddOfferingBtn;
        }

        private void AddGivingItemFrm_Load(object sender, EventArgs e)
        {
            LoadItems();
        }
        void LoadItems()
        {
            List<GivingType> givingTypes = new List<GivingType>();
            GivingTypesController gtc = new GivingTypesController();
            givingTypes = isUpdate? gtc.ShowUnusedExcept(giving,givingItem.givingType):gtc.ShowUnused(giving);
            if (givingTypes.Count > 0)
            {
                Dictionary<int, string> givingTypesLibrary = new Dictionary<int, string>();
                foreach (GivingType givingType in givingTypes)
                {
                    givingTypesLibrary.Add(givingType.id, givingType.title);
                }
                givingTypesCmbBx.DataSource = new BindingSource(givingTypesLibrary, null);
                givingTypesCmbBx.DisplayMember = "Value";
                givingTypesCmbBx.ValueMember = "Key";
                if(isUpdate)
                givingTypesCmbBx.SelectedValue = givingItem.givingType.id;
                else
                givingTypesCmbBx.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No offering types available! All offering types have been already used or no registered offering type found.", "Offering Not Available", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            if (isUpdate) {
                amountTxt.Text = givingItem.amount.ToString();
                noteTxt.Text = givingItem.note;
            }
        }


        private void AddOfferingBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(amountTxt.Text) || givingTypesCmbBx.SelectedIndex < 0) return;
            double parsed;
            if(!double.TryParse(amountTxt.Text,out parsed))
            {
                MessageBox.Show("Invalid amount input! Amount must be a numerical data", "Invalid Input");
                amountTxt.Focus();
                amountTxt.SelectionStart = 0;
                amountTxt.SelectionLength = amountTxt.Text.Length;
                return;
            }
            if (isUpdate)
                givingItem.Update(giving, new GivingTypesController().Show((int)givingTypesCmbBx.SelectedValue), Convert.ToDouble(amountTxt.Text),noteTxt.Text);
             else
                new GivingItem(giving, new GivingTypesController().Show((int)givingTypesCmbBx.SelectedValue), Convert.ToDouble(amountTxt.Text), noteTxt.Text);

            this.Close();
        }

    }
}
