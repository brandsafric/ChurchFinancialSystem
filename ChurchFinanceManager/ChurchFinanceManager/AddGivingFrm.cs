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
    public partial class AddGivingFrm : Form
    {
        public AddGivingFrm()
        {
            InitializeComponent();
        }

        private void AddGivingFrm_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        public void LoadForm(){
            List<Member> members = new List<Member>();
            MembersController mc = new MembersController();
            members = mc.ShowAll();
            if (members.Count > 0)
            {
                Dictionary<Member, string> membersLibrary = new Dictionary<Member, string>();
                foreach (Member member in members)
                {
                    membersLibrary.Add(member, member.firstName + " " + member.lastName);
                }
                membersCmbBx.DataSource = new BindingSource(membersLibrary, null);
                membersCmbBx.DisplayMember = "Value";
                membersCmbBx.ValueMember = "Key";
                membersCmbBx.SelectedIndex = 0;
            }
            
            
        }

        private void AddOfferingBtn_Click(object sender, EventArgs e)
        {
            GivingsController gc = new GivingsController();
            gc.AddGiving((Member)membersCmbBx.SelectedValue, givingDateDateTimePicker.Value) ;
            this.Close();
            
        }
    }
}
