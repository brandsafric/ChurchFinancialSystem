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
    public partial class FamiliesFrm : Form
    {
        List<Family> families = new List<Family>();
        public FamiliesFrm()
        {
            InitializeComponent();
        }

        private void FamiliesFrm_Load(object sender, EventArgs e)
        {
            LoadFamilies();
        }
        public void LoadFamilies()
        {
            FamiliesController fc = new FamiliesController();
            families = fc.ShowAll();
            //setup
            familiesDataGridView.Rows.Clear();
            familiesDataGridView.Columns.Clear();
            familiesDataGridView.Refresh();
            //columns

            familiesDataGridView.Columns.Add("familyId", "ID");
            familiesDataGridView.Columns.Add("familyName", "Family Name");

            familiesDataGridView.Columns["familyId"].Visible = false;
            //rows
            if (families.Count > 0)
            {
                foreach (Family family in families)
                {


                    familiesDataGridView.Rows.Add(
                        family.id,
                        family.familyName);
                }
            }
            else
            {
                MessageBox.Show("No families are currently registered in the system. Please add a families!", "No Family Found!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }
        private void FamilyUpdated(object sender, FormClosingEventArgs e)
        {
            LoadFamilies();
        }

        private void SplitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ToolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdateFamily addUpdateFamily = new AddUpdateFamily(false);
            addUpdateFamily.FormClosing += new FormClosingEventHandler(this.FamilyUpdated);

            addUpdateFamily.ShowDialog();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (familiesDataGridView.Rows.Count <= 0) return;
            if (familiesDataGridView.SelectedRows.Count <= 0) return;
            AddUpdateFamily addUpdateFamily = new AddUpdateFamily(true,new FamiliesController().Show((int)familiesDataGridView.SelectedRows[0].Cells["familyId"].Value));
            addUpdateFamily.FormClosing += new FormClosingEventHandler(this.FamilyUpdated);

            addUpdateFamily.ShowDialog();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (familiesDataGridView.Rows.Count <= 0) return;
            if (familiesDataGridView.SelectedRows.Count <= 0) return;
            if(MessageBox.Show("Are you sure you want to delete family?","Delete Action Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            new FamiliesController().Delete((int)familiesDataGridView.SelectedRows[0].Cells["familyId"].Value);
            LoadFamilies();
        }
    }
}
