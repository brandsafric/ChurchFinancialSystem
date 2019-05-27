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
    public partial class GivingTypesFrm : Form
    {
        List<GivingType> givingTypes;
        public GivingTypesFrm()
        {
            InitializeComponent();
            LoadGivingTypes();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdateGivingTypeFrm form = new AddUpdateGivingTypeFrm(false);
            form.FormClosing += new FormClosingEventHandler(this.GivingTypeUpdated);
            form.ShowDialog();
        }
        private void GivingTypeUpdated(object sender, FormClosingEventArgs e)
        {
            LoadGivingTypes();
        }
        public void LoadGivingTypes() {
            GivingTypesController givingTypesController = new GivingTypesController();
            givingTypes = givingTypesController.ShowAll();
            givingTypesDataGridView.Rows.Clear();
            givingTypesDataGridView.Columns.Clear();
            givingTypesDataGridView.Refresh();
            //setup
            //columns
            givingTypesDataGridView.Columns.Add("givingTypeId", "ID");
            givingTypesDataGridView.Columns.Add("title", "Title");
            givingTypesDataGridView.Columns.Add("isRegular", "Regular Offering Type");
            givingTypesDataGridView.Columns.Add("isActive", "Active");

            givingTypesDataGridView.Columns["givingTypeId"].Visible = false;
            //rows
            if (givingTypes.Count > 0)
            {
                foreach (GivingType givingType in givingTypes)
                {
                    givingTypesDataGridView.Rows.Add(
                        givingType.givingTypeId,
                        givingType.title,
                        (givingType.isRegular ? "Yes" : "No"),
                        (givingType.isActive ? "Yes" : "No"));
                }
            }
            else
            {
                MessageBox.Show("No offering type are currently registered in the system. Please add an offering type!", "No Offering Type Found!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (givingTypesDataGridView.Rows.Count == 0) return;
            int id = Convert.ToInt32(givingTypesDataGridView.SelectedRows[0].Cells["givingTypeId"].Value);
            GivingTypesController givingTypesController = new GivingTypesController();
            GivingType givingType = givingTypesController.Show(id);
            AddUpdateGivingTypeFrm editGivingType = new AddUpdateGivingTypeFrm(true,givingType);
            editGivingType.FormClosing += new FormClosingEventHandler(this.GivingTypeUpdated);
            editGivingType.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (givingTypesDataGridView.Rows.Count == 0) return;
            int id = Convert.ToInt32(givingTypesDataGridView.SelectedRows[0].Cells["givingTypeId"].Value);

            GivingTypesController givingTypesController = new GivingTypesController();

            GivingType givingType = givingTypesController.Show(id);

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete Oferring Type: " + givingType.title + "\n NOTE: this action cannot be undone!",
                "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            else if (dialogResult == DialogResult.Yes)
            {
                givingType.Delete();
                MessageBox.Show("Offering Type Deleted from records!", "Offering Type Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGivingTypes();
            }

        }

        private void GivingTypesFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
