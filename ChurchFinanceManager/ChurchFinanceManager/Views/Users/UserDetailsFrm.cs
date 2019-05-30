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
    public partial class UserDetailsFrm : Form
    {
        User user;
        public UserDetailsFrm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void UserDetailsFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void LoadData()
        {
            nameTxt.Text = user.name;
            usernameTxt.Text = user.username;
            loginCountTxt.Text = user.GetAllSessions().Count.ToString();
            lastLoginTxt.Text = user.GetLastSession().start.ToString("MM/dd/yyyy hh:mm tt");

        }
    }
}
