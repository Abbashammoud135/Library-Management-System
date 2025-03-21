using LibraryManagementSystem.Controller;
using LibraryManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.View
{
    public partial class AddNewMember : UserControl
    {
        private LoginController userController;
        private MembersController membersController;
        public AddNewMember()
        {
            InitializeComponent();
            userController = new LoginController();
            membersController = new MembersController();

        }
        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }
        private bool IsValidPassword(string password)
        {
            return password.Length >= 8;
        }
        private void AddMember_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = Nametxt.Text;
            string salt = userController.GenerateSalt();
            user.Salt = salt;
            user.HashPassword = userController.HashPassword(Passwordtxt.Text + salt);
            user.Email = Emailtxt.Text;
            if (user.Name == "" || user.Email == "" || Passwordtxt.Text == "")
            {
                Error.Text = "Please fill all the fields";
                Error.ForeColor = Color.Red;
            }
            else
            {
                if(user.Email == "" || !IsValidEmail(user.Email))
                {
                    Error.Text = "Please enter a valid email";
                    Error.ForeColor = Color.Red;
                    return;
                }
                if (!IsValidPassword(Passwordtxt.Text))
                {
                    Error.Text = "Password must be at least 8 char long";
                    Error.ForeColor = Color.Red;
                    return;
                }
                //Ensure that the email is unique
                if (membersController.AddMember(user) > 0)
                {
                    Error.Text = "Member Added Successfully";
                    Error.ForeColor = Color.Green;
                }
                else
                {
                    Error.Text = "Member Already Exists,Try another email";
                    Error.ForeColor = Color.Red;
                }
            }

        }

        private void AddNewMember_Load(object sender, EventArgs e)
        {

        }

        private void Emailtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
