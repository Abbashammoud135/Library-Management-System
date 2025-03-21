using LibraryManagementSystem.Controller;
using LibraryManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.View
{
    public partial class Login : Form
    {
        LoginController login;
        public Login()
        {
            InitializeComponent();
            login = new LoginController();
        }
        private void BackToHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home homeForm = new Home();
            homeForm.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            MemberOrAdmin.SelectedIndex = 0;
        }

        private void UserNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            User loginUser = new User();

            loginUser.Email = UserNameText.Text;
            loginUser.HashPassword = PasswordText.Text;
            loginUser.IsAdmin = ((string?)MemberOrAdmin.SelectedItem == "Admin") ? true : false;
            if(loginUser.Email == "" || PasswordText.Text == "")
            {
                ErrorLabel.Text = "Please fill all the fields";
                return;
            }
            if (login.VerifyCredintials(loginUser))
            {
                this.Hide();
                if (!loginUser.IsAdmin)
                {
                    MemberDashboard MemberhomeForm = new MemberDashboard();
                    MemberhomeForm.Show();
                }
                else
                {
                    AdminDashboard AdminhomeForm = new AdminDashboard();
                    AdminhomeForm.Show();
                }
            }
            else
            {
                ErrorLabel.Text = "Email and password didn't match";
            }
        }

        private void ErrorLabel_Click(object sender, EventArgs e)
        {

        }
        private string ErrorLabel_Message()
        {
            throw new NotImplementedException();
        }

        private void MemberOrAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ErrorLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
