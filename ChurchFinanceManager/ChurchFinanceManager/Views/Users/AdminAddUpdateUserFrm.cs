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
    public partial class AdminAddUpdateUserFrm : Form
    {
        bool isUpdate;
        User user;
        UsersController uc = new UsersController();
        public AdminAddUpdateUserFrm(bool isUpdate,User user = null)
        {
            this.isUpdate = isUpdate;
            this.user = user;
            if(isUpdate && user == null)
            {
                MessageBox.Show("Failed to load user!", "User Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            InitializeComponent();
            if (isUpdate)
                this.Text = "Update User";
            else
                this.Text = "Add User";
            
        }
       
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(nameTxtBox.Text) ||
                String.IsNullOrWhiteSpace(usernameTxt.Text) ||
                String.IsNullOrWhiteSpace(passwordTxt.Text))
            {
                MessageBox.Show("All fields are required!", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!isUpdate && uc.UsernameExist(usernameTxt.Text))
            {
                MessageBox.Show("Username already taken please choose another one", "Username Exists!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (isUpdate && uc.IsDuplicateUsername(usernameTxt.Text,user))
            {
                MessageBox.Show("Username already exists please choose another one", "Username Exists!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (isUpdate)
                user.Update(nameTxtBox.Text, usernameTxt.Text, passwordTxt.Text);
            else
                new User(nameTxtBox.Text, usernameTxt.Text, passwordTxt.Text);

            this.Close();
        }

        private void PasswordPeekBtn_MouseDown(object sender, EventArgs e)
        {
            passwordTxt.PasswordChar = '\0';
        }

        private void PasswordPeekBtn_MouseUp(object sender, EventArgs e)
        {
            passwordTxt.PasswordChar = '•';
        }

        private void AdminAddUpdateUserFrm_Load(object sender, EventArgs e)
        {
            if (!isUpdate) return;
            nameTxtBox.Text = user.name;
            usernameTxt.Text = user.username;
            passwordTxt.Text = user.password;

        }
    }
}
