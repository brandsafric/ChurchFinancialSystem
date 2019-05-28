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
    public partial class UsersFrm : Form
    {
        List<User> users = new List<User>();
        public UsersFrm()
        {
            InitializeComponent();
        }
        void LoadForm()
        {
            UsersController uc = new UsersController();
            users = uc.ShowAll();
            usersDataGridView.Rows.Clear();
            usersDataGridView.Columns.Clear();
            usersDataGridView.Refresh();
            //setup
            //columns
            usersDataGridView.Columns.Add("userId", "ID");
            usersDataGridView.Columns.Add("name", "Name");
            usersDataGridView.Columns.Add("username", "Username");

            usersDataGridView.Columns["userId"].Visible = false;
            //rows
            if (users.Count > 0)
            {
                foreach (User user in users)
                {
                    usersDataGridView.Rows.Add(
                        user.id,
                        user.name,
                        user.username
                        );
                    if (user.isAdmin)
                        usersDataGridView.Rows[usersDataGridView.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
            else
            {
                MessageBox.Show("No users are currently registered in the system. Please add a user!", "No User Found!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void AddUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminAddUpdateUserFrm adminAddUpdateUserFrm = new AdminAddUpdateUserFrm(false);
            adminAddUpdateUserFrm.FormClosing += new FormClosingEventHandler(this.UsersUpdated);
            adminAddUpdateUserFrm.ShowDialog();
        }

        private void UsersFrm_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        private void UsersUpdated(object sender, FormClosingEventArgs e)
        {
            LoadForm();
        }
        private void EditUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usersDataGridView.Rows.Count == 0) return;
            if (usersDataGridView.SelectedRows.Count == 0) return;
            User user = new User(Convert.ToInt32(usersDataGridView.SelectedRows[0].Cells["userId"].Value));
            AdminAddUpdateUserFrm adminAddUpdateUserFrm = new AdminAddUpdateUserFrm(true, user);
            adminAddUpdateUserFrm.FormClosing += new FormClosingEventHandler(this.UsersUpdated);
            adminAddUpdateUserFrm.ShowDialog();
        }

        private void DeleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usersDataGridView.Rows.Count == 0) return;
            if (usersDataGridView.SelectedRows.Count == 0) return;
            if (
                MessageBox.Show(
                "Are you sure you want to delete this user? \n\n NOTE: We do not encourage deleting users as this may affect the system as a whole.",
                "Critical Message!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
                ) == DialogResult.No) return;
            new UsersController().Delete(Convert.ToInt32(usersDataGridView.SelectedRows[0].Cells["userId"].Value));
            LoadForm();
        }
    }
}
