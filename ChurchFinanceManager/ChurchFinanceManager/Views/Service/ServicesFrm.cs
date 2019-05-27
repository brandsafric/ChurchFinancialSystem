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
    public partial class ServicesFrm : Form
    {
        public ServicesFrm()
        {
            InitializeComponent();
        }

        private void EditServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (servicesDataGridView.Rows.Count == 0) return;

            Service s = new ServicesController().Show((int)servicesDataGridView.SelectedRows[0].Cells["serviceId"].Value);

            AddUpdateServiceFrm addFrm = new AddUpdateServiceFrm(true,s);
            addFrm.FormClosing += new FormClosingEventHandler(this.ServicesUpdated);

            addFrm.ShowDialog();


        }

        private void DeleteServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (servicesDataGridView.Rows.Count == 0) return;
            if(MessageBox.Show("Are you sure you want to delete this service?","Confirm Delete Action",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.OK)
             new ServicesController().Show((int)servicesDataGridView.SelectedRows[0].Cells["serviceId"].Value).Delete();
      
            LoadForm();
        }

        private void AddServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AddUpdateServiceFrm addFrm = new AddUpdateServiceFrm(false);
            addFrm.FormClosing += new FormClosingEventHandler(this.ServicesUpdated);

            addFrm.ShowDialog();
        }

        private void ServicesFrm_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        public void LoadForm()
        {
            ServicesController sc = new ServicesController();
            List<Service> services = sc.ShowAll();
            servicesDataGridView.Rows.Clear();
            servicesDataGridView.Columns.Clear();
            servicesDataGridView.Refresh();
            //setup
            //columns
            servicesDataGridView.Columns.Add("serviceId", "ID");
            servicesDataGridView.Columns.Add("name", "Service Name");
            servicesDataGridView.Columns.Add("day", "Service Day");

            servicesDataGridView.Columns["serviceId"].Visible = false;
            //rows
            if (services.Count > 0)
            {
                foreach (Service service in services)
                {


                    servicesDataGridView.Rows.Add(
                        service.id,
                        service.name,
                        service.DayFullName()
                        );
                }
            }
            else
            {
                MessageBox.Show("No servicse are currently registered in the system. Please add a service!", "No Service Found!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void ServicesUpdated(object sender, FormClosingEventArgs e)
        {
            LoadForm();
        }
    }
}
