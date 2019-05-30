using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Forms;

namespace ChurchFinanceManager
{
    public partial class RolesFrm : Form
    {
        User user;
        List<Role> allRoles = new List<Role>();
        public RolesFrm(User user)
        {
            this.user = user;
            InitializeComponent();
            if(user == null) {
                MessageBox.Show("No user have been loaded!", "Fatal Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); return;
            }
            nameTxt.Text = user.name;
            userNameTxt.Text = user.username;

            LoadRoles();
        }

        private void RolesFrm_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadRoles()
        {
            rolesChkLstBx.Items.Clear();
            
            RolesController rc = new RolesController();
             allRoles = rc.ShowAll();
            if(allRoles.Count == 0) { MessageBox.Show("No roles have been found!", "Fatal Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();return;
            }
            foreach (Role r in allRoles)
            {
                rolesChkLstBx.Items.Add(new { Text = $"{r.title}", Value = r.id },
                    (user.haveRole(r)));
            }
            rolesChkLstBx.DisplayMember = "Text";
            rolesChkLstBx.ValueMember = "Value";
            if (user.isAdmin)
            {
                rolesChkLstBx.Enabled = false;
                adminNotificationLbl.Visible = true;
            }
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            if (user.isAdmin) this.Close();
            ApplyModifications();
            this.Close();
        }

        public void ApplyModifications()
        {
            if(allRoles.Count != rolesChkLstBx.Items.Count)
            {
                MessageBox.Show("Roles listed and roles saved are not the same!", "Fatal Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); return;
            }
            UserRolesController urc = new UserRolesController();
            for (int i = 0; i < rolesChkLstBx.Items.Count; i++)
            {
                CheckState st = rolesChkLstBx.GetItemCheckState(i);
                if (st == CheckState.Checked)
                {
                    if (user.haveRole(allRoles[i]))continue;
                    user.AddRole(allRoles[i]);
                    
                }
                else
                {
                    if (!user.haveRole(allRoles[i])) continue;
                    user.DeleteRole(allRoles[i]);
                }
            }
        }
    }
}
