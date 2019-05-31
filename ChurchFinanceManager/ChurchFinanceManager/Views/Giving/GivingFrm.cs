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
        Session currentSession;
        List<Giving> givings = new List<Giving>();
        List<Service> services = new List<Service>();
        public GivingFrm(Session session)
        {
            currentSession = session;
            InitializeComponent();
        }

        private void GivingFrm_Load(object sender, EventArgs e)
        {
            servicesCmbBx.SelectedIndexChanged -= new System.EventHandler(this.ServicesCmbBx_SelectedIndexChanged);
            ServicesController sc = new ServicesController();
            services = sc.ShowAll();
            if (services.Count > 0)
            {
                UpdateDateTimePicker(services[0]);
                Dictionary<Service, string> serviceLibrary = new Dictionary<Service, string>();
                foreach (Service service in services)
                {
                    serviceLibrary.Add(service, service.name);
                }
                servicesCmbBx.DataSource = new BindingSource(serviceLibrary, null);
                servicesCmbBx.DisplayMember = "Value";
                servicesCmbBx.ValueMember = "Key";
                servicesCmbBx.SelectedIndexChanged += new System.EventHandler(this.ServicesCmbBx_SelectedIndexChanged);

                //servicesCmbBx.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No service registered. Please Create a service type first!.",
                    "Service Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }

            LoadGivings();
        }

        #region Givings
        void ResetGivingTable()
        {
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
        }
        public void LoadGivings() {
            GivingsController givingsController = new GivingsController();
            if ((Service)servicesCmbBx.SelectedValue == null) { return; }
            givings = currentSession.user.isAdmin? givingsController.ShowAllWithinScope((Service)servicesCmbBx.SelectedValue, givingDateDateTimePicker.Value): givingsController.ShowAllWithinScope((Service)servicesCmbBx.SelectedValue, givingDateDateTimePicker.Value,currentSession);
            //givings = givingsController.ShowAll();
            ResetGivingTable();

            //rows
            double total = 0;
            if (givings.Count > 0)
            {
                foreach (Giving giving in givings)
                {
                    givingDataGridView.Rows.Add(
                        giving.id,
                        giving.member.FullName(),
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
                ResetGivingItemsTable();
                //selectedGiving = null;
                //  MessageBox.Show("No offering are currently registered in the system. Please add an offering!", "No Offering Found!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            totalOfferingTxt.Text = total.ToString("C",CultureInfo.CurrentCulture);
        }

        private void GivingUpdated(object sender, FormClosingEventArgs e)
        {
            LoadGivings();
        }

        private void AddGivingBtn_Click(object sender, EventArgs e)
        {
            AddUpdateGivingFrm addGivingFrm = new AddUpdateGivingFrm(false,null,(Service)servicesCmbBx.SelectedValue,givingDateDateTimePicker.Value,currentSession);
            addGivingFrm.FormClosing += new FormClosingEventHandler(this.GivingUpdated);

            addGivingFrm.ShowDialog();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (givingDataGridView.Rows.Count == 0)
                return;
            GivingsController gc = new GivingsController();
            Giving giving = gc.Show(Convert.ToInt32(givingDataGridView.SelectedRows[0].Cells["givingId"].Value));

            AddUpdateGivingFrm addGivingFrm = new AddUpdateGivingFrm(true, giving);
            addGivingFrm.FormClosing += new FormClosingEventHandler(this.GivingUpdated);
            addGivingFrm.ShowDialog();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (givingDataGridView.Rows.Count == 0)
                return;
            int id = Convert.ToInt32(givingDataGridView.SelectedRows[0].Cells["givingId"].Value);

            GivingsController gc = new GivingsController();

            Giving giving = gc.Show(id);

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


        void ResetGivingItemsTable()
        {
            givingItemsDataGridView.Rows.Clear();
            givingItemsDataGridView.Columns.Clear();
            givingItemsDataGridView.Refresh();
            //setup
            //columns
            givingItemsDataGridView.Columns.Add("givingItemId", "ID");
            givingItemsDataGridView.Columns.Add("givingType", "Offering Type");
            givingItemsDataGridView.Columns.Add("amount", "Amount");

            givingItemsDataGridView.Columns["givingItemId"].Visible = false;
        }
        private void LoadGivingItems(Giving g)
        {
            selectedGiving = g;
            giverNameTxt.Text = g.member.FullName();
            givingItemsDateTimePicker.Value = g.givingDate;
            List<GivingItem> givingItems = g.givingItems();
            ResetGivingItemsTable();
            //rows
            if (givingItems.Count > 0)
            {
                foreach (GivingItem givingItem in givingItems)
                {
                    givingItemsDataGridView.Rows.Add(
                        givingItem.id,
                        givingItem.givingType.title,
                        givingItem.amount
                        );
                }
                givingItemsDataGridView.ClearSelection();
                givingItemsDataGridView.Rows[givingItems.Count - 1].Selected = true;
                
            }
            
            totalTxt.Text =  g.totalAmount().ToString("C", CultureInfo.CurrentCulture);
            GivingsController givingsController = new GivingsController();
            givings = givingsController.ShowAll();
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
            Giving g = gc.Show((int)givingDataGridView.SelectedRows[0].Cells["givingId"].Value);
            if (g != null)
                LoadGivingItems(g);
        }

        #endregion

        private void AddGivingItemBtn_Click(object sender, EventArgs e)
        {
            if (selectedGiving == null) return;
            if (givingDataGridView.Rows.Count == 0) return;
            AddUpdateGivingItemFrm addGivingItemFrm = new AddUpdateGivingItemFrm(false,selectedGiving);
            addGivingItemFrm.FormClosing += new FormClosingEventHandler(delegate{ this.LoadGivingItems(selectedGiving); });
            addGivingItemFrm.ShowDialog();
        }

        private void UpdateGivingItemBtn_Click(object sender, EventArgs e)
        {
            if (givingItemsDataGridView.Rows.Count == 0)
                return;
            GivingItemsController gic = new GivingItemsController();
            GivingItem gi = gic.Show(Convert.ToInt32(givingItemsDataGridView.SelectedRows[0].Cells["givingItemId"].Value));
            if (gi == null)
            {
                MessageBox.Show("Failed to get giving item", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AddUpdateGivingItemFrm editGivingItemFrm = new AddUpdateGivingItemFrm(true,selectedGiving,gi);
            editGivingItemFrm.FormClosing += new FormClosingEventHandler(delegate { this.LoadGivingItems(selectedGiving); });
            editGivingItemFrm.ShowDialog();
        }

        private void DeleteGivingItemBtn_Click(object sender, EventArgs e)
        {
            if (givingItemsDataGridView.Rows.Count == 0)
                return;
            GivingItemsController gic = new GivingItemsController();
            GivingItem g = gic.Show((int)givingItemsDataGridView.SelectedRows[0].Cells["givingItemId"].Value);
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

        private void ServicesCmbBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (servicesCmbBx.Items.Count <= 0) return;
            Service s = (Service)servicesCmbBx.SelectedValue;
            UpdateDateTimePicker(s);
            LoadGivings();
            // GetLastServiceDate
        }

        private void UpdateDateTimePicker(Service s)
        {
            if (s == null) return;
            givingDateDateTimePicker.Value = s.GetLastServiceDate();
        }

        private void GivingDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadGivings();
        }

    }
}
