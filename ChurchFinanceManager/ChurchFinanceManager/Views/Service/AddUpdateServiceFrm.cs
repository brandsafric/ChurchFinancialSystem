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
    public partial class AddUpdateServiceFrm : Form
    {
        private bool isUpdate;
        Service service;
        public bool IsUpdate { get => isUpdate; set => isUpdate = value; }
        public Service ServiceProperty { get => service;  set => service = value; }

        public AddUpdateServiceFrm(bool isUpdate, Service service = null)
        {
            this.ServiceProperty = service ?? null;
            this.IsUpdate = isUpdate;
            InitializeComponent();
            if (isUpdate && ServiceProperty == null) { 
                MessageBox.Show("Service to be edited did not pass correctly", "Error Occured", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }


        private void AddUpdateServiceFrm_Load(object sender, EventArgs e)
        {
            if (IsUpdate) {

                this.Text = "Update Service";
                SubmitBtn.Text = "Update";
                nameTxt.Text = ServiceProperty.name;
                dayCmbBx.SelectedIndex = ServiceProperty.day;
            }
            else
            {
                this.Text = "Create New Service";
                SubmitBtn.Text = "Create";
            }
            this.AcceptButton = SubmitBtn;

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nameTxt.Text) || dayCmbBx.SelectedIndex < 0)
            return;
            if (isUpdate) {
                this.ServiceProperty.Update(nameTxt.Text, dayCmbBx.SelectedIndex);
            }
            else
            {
                new Service(nameTxt.Text, dayCmbBx.SelectedIndex);
            }
            this.Close();

        }
    }
}
