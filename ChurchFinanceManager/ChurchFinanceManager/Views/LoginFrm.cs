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
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
            
            var pos = this.PointToScreen(label4.Location);
            pos = pictureBox1.PointToClient(pos);
            label4.Parent = pictureBox1;
            label4.Location = pos;
            label4.BackColor = Color.Transparent;
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            CheckCredentials(usernameTxt.Text, passwordTxt.Text);
        }

        void CheckCredentials(string username,string password)
        {
            if (String.IsNullOrEmpty(usernameTxt.Text) || String.IsNullOrEmpty(passwordTxt.Text)) {
                MessageBox.Show("Username and password are required for logging in", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
             }


            UsersController uc = new UsersController();
            if (!uc.IsCorrectCredentials(username, password))
            {
                MessageBox.Show("Invalid credentials! Please check username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoginUser(username);
            
            
          
              
        }
        void LoginUser(string username)
        {
            Session session = null;
            User user = new UsersController().Show(username);
            if(user == null)
            {
                MessageBox.Show("User not found!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Session lastSession = new SessionsController().GetLastLoginByUser(user);
            if(lastSession != null)
            {
                if (!lastSession.hasEndedProperly())
                {
                    DialogResult result = MessageBox.Show("Last session did not end properly, Do you want to continue with your last session?", "Unended Session Detected", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                        session = lastSession;
                    
                }
            }

            if(session == null)
                session = new Session(user);
            if (session == null)
            {
                MessageBox.Show("Session not found!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            session.user = user;
            usernameTxt.Text = "";
            passwordTxt.Text = "";
            frmDashboard dashboard = new frmDashboard();
            dashboard.Show();
            dashboard.WindowState = FormWindowState.Maximized;
            dashboard.FormClosing += new FormClosingEventHandler(this.LoggedOut);
            this.Visible = false;


        }
        void LoggedOut(object sender,FormClosingEventArgs e)
        {
            if (!e.Cancel)
            this.Visible = true;
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {
        }
    }
}
