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
    public partial class GivingFrm : Form
    {
        List<Giving> givings = new List<Giving>();
        public GivingFrm()
        {
            InitializeComponent();
        }

        private void GivingFrm_Load(object sender, EventArgs e)
        {
            LoadGivings();
        }

        #region Givings
        public void LoadGivings() {
            GivingsController givingsController = new GivingsController();
            givings = givingsController.ViewGivings();
            givingDataGridView.Rows.Clear();
            givingDataGridView.Columns.Clear();
            givingDataGridView.Refresh();
            //setup
            //columns
            givingDataGridView.Columns.Add("givingId", "ID");
            givingDataGridView.Columns.Add("memberName", "Member Name");
            givingDataGridView.Columns.Add("givingDate", "Date Offered");
            givingDataGridView.Columns.Add("entryDate", "Entry Date");

            givingDataGridView.Columns["givingId"].Visible = false;
            //rows
            double total = 0;
            if (givings.Count > 0)
            {
                foreach (Giving giving in givings)
                {
                    givingDataGridView.Rows.Add(
                        giving.givingId,
                        giving.member.fullName(),
                        giving.givingDate.ToString("MMMM dd, yyyy"),
                        giving.entryDate.ToString("MMMM dd, yyyy")
                        );
                    total += giving.totalAmount();
                }
                givingDataGridView.ClearSelection();
                givingDataGridView.Rows[givings.Count - 1].Selected = true;
                LoadGivingItems(givings[givings.Count - 1]);

            }
            else
            {
                MessageBox.Show("No offering are currently registered in the system. Please add an offering!", "No Offering Found!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            totalOfferingTxt.Text = total.ToString("C",CultureInfo.CurrentCulture);
        }

        private void GivingUpdated(object sender, FormClosingEventArgs e)
        {
            LoadGivings();
        }

        private void AddGivingBtn_Click(object sender, EventArgs e)
        {
            AddGivingFrm addGivingFrm = new AddGivingFrm();
            addGivingFrm.FormClosing += new FormClosingEventHandler(this.GivingUpdated);
            addGivingFrm.ShowDialog();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (givingDataGridView.Rows.Count == 0)
                return;
            GivingsController gc = new GivingsController();
            Giving giving = gc.ViewGiving(Convert.ToInt32(givingDataGridView.SelectedRows[0].Cells["givingId"].Value));
            EditGivingFrm editGivingFrm = new EditGivingFrm(giving);
            editGivingFrm.FormClosing += new FormClosingEventHandler(this.GivingUpdated);
            editGivingFrm.ShowDialog();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (givingDataGridView.Rows.Count == 0)
                return;
            int id = Convert.ToInt32(givingDataGridView.SelectedRows[0].Cells["givingId"].Value);

            GivingsController gc = new GivingsController();

            Giving giving = gc.ViewGiving(id);

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete Oferring of " + giving.member.firstName + "\n NOTE: this action cannot be undone!",
                "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            else if (dialogResult == DialogResult.Yes)
            {
                giving.Delete();
                MessageBox.Show("Offering Type Deleted from records!", "Offering Type Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGivings();
            }
        }
        #endregion

        #region GivingItems
        Giving selectedGiving;
        private void LoadGivingItems(Giving g)
        {
            selectedGiving = g;
            giverNameTxt.Text = g.member.fullName();
            givingItemsDateTimePicker.Value = g.givingDate;
            List<GivingItem> givingItems = g.givingItems();
            givingItemsDataGridView.Rows.Clear();
            givingItemsDataGridView.Columns.Clear();
            givingItemsDataGridView.Refresh();
            //setup
            //columns
            givingItemsDataGridView.Columns.Add("givingItemId", "ID");
            givingItemsDataGridView.Columns.Add("givingType", "Offering Type");
            givingItemsDataGridView.Columns.Add("amount", "Amount");

            givingItemsDataGridView.Columns["givingItemId"].Visible = false;
            //rows
            if (givingItems.Count > 0)
            {
                foreach (GivingItem givingItem in givingItems)
                {
                    givingItemsDataGridView.Rows.Add(
                        givingItem.givingItemId,
                        givingItem.givingType.title,
                        givingItem.amount
                        );
                }
                givingItemsDataGridView.ClearSelection();
                givingItemsDataGridView.Rows[givingItems.Count - 1].Selected = true;
                
            }
            
            totalTxt.Text =  g.totalAmount().ToString("C", CultureInfo.CurrentCulture);
            GivingsController givingsController = new GivingsController();
            givings = givingsController.ViewGivings();
            double total = 0;
            foreach(Giving giving in givings)
            {
                total += giving.totalAmount();
            }

            totalOfferingTxt.Text = total.ToString("C", CultureInfo.CurrentCulture);

        }
        private void GivingDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GivingsController gc = new GivingsController();
            Giving g = gc.ViewGiving((int)givingDataGridView.SelectedRows[0].Cells["givingId"].Value);
            if (g != null)
                LoadGivingItems(g);
        }

        #endregion

        private void AddGivingItemBtn_Click(object sender, EventArgs e)
        {
            if (selectedGiving == null) return;
            AddGivingItemFrm addGivingItemFrm = new AddGivingItemFrm(selectedGiving);
            addGivingItemFrm.FormClosing += new FormClosingEventHandler(delegate{ this.LoadGivingItems(selectedGiving); });
            addGivingItemFrm.ShowDialog();
        }

        private void UpdateGivingItemBtn_Click(object sender, EventArgs e)
        {
            if (givingItemsDataGridView.Rows.Count == 0)
                return;
            GivingItemsController gic = new GivingItemsController();
            GivingItem g = gic.ViewGivingItem((int)givingItemsDataGridView.SelectedRows[0].Cells["givingItemId"].Value);
            EditGivingItemFrm editGivingItemFrm = new EditGivingItemFrm(selectedGiving, g);
            editGivingItemFrm.FormClosing += new FormClosingEventHandler(delegate { this.LoadGivingItems(selectedGiving); });
            editGivingItemFrm.ShowDialog();
        }

        private void DeleteGivingItemBtn_Click(object sender, EventArgs e)
        {
            if (givingItemsDataGridView.Rows.Count == 0)
                return;
            GivingItemsController gic = new GivingItemsController();
            GivingItem g = gic.ViewGivingItem((int)givingItemsDataGridView.SelectedRows[0].Cells["givingItemId"].Value);
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete Oferring  Item: " + g.givingType.title + "\n NOTE: this action cannot be undone!",
               "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            else if (dialogResult == DialogResult.Yes)
            {
                g.Delete();
                MessageBox.Show("Offering item Deleted from records!", "Offering Item Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGivingItems(selectedGiving);
            }
            
            
        }
    }
}
