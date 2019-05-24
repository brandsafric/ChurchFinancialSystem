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
            Console.WriteLine(g.member.fullName());
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
            givingTypes = gtc.ViewGivingTypes();
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

            GivingItemsController gc = new GivingItemsController();
            gc.AddGivingItem(giving, (GivingType)givingTypesCmbBx.SelectedValue, Convert.ToDouble(amountTxt.Text));
            this.Close();
        }

    }
}
