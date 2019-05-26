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
    public partial class AddGivingItemFrm : Form
    {
        Giving giving;
        public AddGivingItemFrm(Giving g)
        {  
            this.giving = g;
            Console.WriteLine(g.member.FullName());
            InitializeComponent();
        }

        private void AddGivingItemFrm_Load(object sender, EventArgs e)
        {
            LoadItems();
        }
        void LoadItems()
        {
            List<GivingType> givingTypes = new List<GivingType>();
            GivingTypesController gtc = new GivingTypesController();
            givingTypes = gtc.ShowUnused(giving);
            if (givingTypes.Count > 0)
            {
                Dictionary<GivingType, string> givingTypesLibrary = new Dictionary<GivingType, string>();
                foreach (GivingType givingType in givingTypes)
                {
                    givingTypesLibrary.Add(givingType, givingType.title);
                }
                givingTypesCmbBx.DataSource = new BindingSource(givingTypesLibrary, null);
                givingTypesCmbBx.DisplayMember = "Value";
                givingTypesCmbBx.ValueMember = "Key";
                givingTypesCmbBx.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No offering types available! All offering types have been already used or no registered offering type found.", "Offering Not Available", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }


        private void AddOfferingBtn_Click(object sender, EventArgs e)
        {
            double parsed;
            if(!double.TryParse(amountTxt.Text,out parsed))
            {
                MessageBox.Show("Invalid amount input! Amount must be a numerical data", "Invalid Input");
                amountTxt.Focus();
                amountTxt.SelectionStart = 0;
                amountTxt.SelectionLength = amountTxt.Text.Length;
                return;
            }
                  
            GivingItem gi = new GivingItem(giving, (GivingType)givingTypesCmbBx.SelectedValue, Convert.ToDouble(amountTxt.Text));
            this.Close();
        }

    }
}
