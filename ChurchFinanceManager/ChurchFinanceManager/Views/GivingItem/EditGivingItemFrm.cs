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
    public partial class EditGivingItemFrm : Form
    {
        Giving giving;
        GivingItem gi;
        public EditGivingItemFrm(Giving giving, GivingItem gi)
        {
            this.giving = giving;
            this.gi = gi;
            InitializeComponent();
        }

        private void EditOfferingItemFrm_Load(object sender, EventArgs e)
        {
            LoadItems();
        }
        void LoadItems()
        {
            List<GivingType> givingTypes = new List<GivingType>();
            GivingTypesController gtc = new GivingTypesController();
            givingTypes = gtc.ShowAll();
            if (givingTypes.Count > 0)
            {
                int selectedIndex = 0;
                int index = 0;
                Dictionary<GivingType, string> givingTypesLibrary = new Dictionary<GivingType, string>();
                foreach (GivingType givingType in givingTypes)
                {
                    givingTypesLibrary.Add(givingType, givingType.title);
                    if(givingType.givingTypeId == gi.givingItemId)
                    {
                        selectedIndex = index;
                    }
                    index++;
                }
                givingTypesCmbBx.DataSource = new BindingSource(givingTypesLibrary, null);
                givingTypesCmbBx.DisplayMember = "Value";
                givingTypesCmbBx.ValueMember = "Key";
                givingTypesCmbBx.SelectedIndex = selectedIndex;
            }
            amountTxt.Text = gi.amount.ToString();
        }

        private void AddOfferingBtn_Click(object sender, EventArgs e)
        {
            double parsed;
            if (!double.TryParse(amountTxt.Text, out parsed))
            {
                MessageBox.Show("Invalid amount input! Amount must be a numerical data", "Invalid Input");
                amountTxt.Focus();
                amountTxt.SelectionStart = 0;
                amountTxt.SelectionLength = amountTxt.Text.Length;
                return;
            }

            GivingItemsController gc = new GivingItemsController();
            GivingType gt = (GivingType)givingTypesCmbBx.SelectedValue;
            gc.Update(gi.givingItemId,
                new Param("givingId", giving.givingId),
                new Param("givingTypeId", gt.givingTypeId),
                new Param("amount", Convert.ToDouble(amountTxt.Text)));
            this.Close();
        }
    }
}
