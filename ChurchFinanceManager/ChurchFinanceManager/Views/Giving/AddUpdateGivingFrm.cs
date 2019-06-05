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
    public partial class AddUpdateGivingFrm : Form
    {

        private bool IsUpdate;

        private Giving currentGiving;

        private Service addedService;

        private Session currentSession;

        private DateTime addedDate;

        public AddUpdateGivingFrm(bool isUpdate, Giving giving = null, Service service = null, DateTime? date = null, Session session = null)
        {
            this.addedDate = date ?? DateTime.Now;
            this.IsUpdate = isUpdate;
            this.currentGiving = giving;
            this.addedService = service;
            this.currentSession = session;

            InitializeComponent();
            LoadForm();

        }

        public void LoadForm()
        {   //loads UI for Update or Add
            this.Text = IsUpdate ? "Edit Offering" : "Add Offering";
            this.submitBtn.Text = IsUpdate ? "Submit" : "Create";
            this.AcceptButton = submitBtn;

            //loads memebers
            MembersController mc = new MembersController();
            List<Member> members = mc.ShowAll();

            if (members.Count > 0)
            {
                List<KeyValuePair<int, string>> membersLibrary = new List<KeyValuePair<int, string>>();
                foreach (Member member in members)
                {
                    membersLibrary.Add(new KeyValuePair<int, string>(member.id, member.firstName + " " + member.lastName));
                }
                membersCmbBx.DataSource = membersLibrary.ToList<KeyValuePair<int, string>>();//new BindingSource(membersLibrary, null);
                membersCmbBx.DisplayMember = "Value";
                membersCmbBx.ValueMember = "Key";
                if (IsUpdate)
                    membersCmbBx.SelectedValue = currentGiving.member.id;
                else
                    membersCmbBx.SelectedIndex = 0;
            }

            //loads services

            ServicesController sc = new ServicesController();
            List<Service> services = sc.ShowAll();
            if (services.Count > 0)
            {
                List<KeyValuePair<int, string>> servicesLibrary = new List<KeyValuePair<int, string>>();
                foreach (Service service in services)
                {
                    servicesLibrary.Add(new KeyValuePair<int, string>(service.id, service.name));
                }
                serviceCmbBox.DataSource = servicesLibrary.ToList<KeyValuePair<int, string>>();//new BindingSource(membersLibrary, null);
                serviceCmbBox.DisplayMember = "Value";
                serviceCmbBox.ValueMember = "Key";
                if (IsUpdate)
                    serviceCmbBox.SelectedValue = currentGiving.service.id;
                else
                    serviceCmbBox.SelectedValue = addedService.id;
            }

            //load date
            givingDateDateTimePicker.Value = IsUpdate ? currentGiving.givingDate : addedDate;
        }

        private void AddOfferingBtn_Click(object sender, EventArgs e)
        {
            Member member = null;
            if (String.IsNullOrWhiteSpace(membersCmbBx.Text)) return;
            if(membersCmbBx.SelectedValue !=null)
              member = new MembersController().Show((int)membersCmbBx.SelectedValue);

            if (member == null)
            {
                if (MessageBox.Show("Member does not exist. Do you want to add this member?", "Member was not found", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    == DialogResult.Yes
                        )
                    member = new Member(membersCmbBx.Text, "", "", DateTime.Now, "", true);
                else return;
            }
            if (IsUpdate)
                currentGiving.Update(
                     member,
                     givingDateDateTimePicker.Value,
                     new ServicesController().Show((int)serviceCmbBox.SelectedValue)
                     );
            else
                new Giving(
                    member,
                    givingDateDateTimePicker.Value,
                    new ServicesController().Show((int)serviceCmbBox.SelectedValue),
                    currentSession);

            this.Close();

        }

        private void AddUpdateGivingFrm_Load(object sender, EventArgs e)
        {

        }

        private void GivingDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
