using LibraryManagementSystem.Controller;
using LibraryManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.View
{
    public partial class ViewMember : UserControl
    {
        MembersController _membersController;
        LoginController _loginController;
        public ViewMember()
        {
            InitializeComponent();
            _membersController = new MembersController();
            _loginController = new LoginController();
        }
        public void UpdateView()
        {
            ViewMembersAsList.DataSource = _membersController.GetAllMembers().Select(m => new
            {
                m.UserID,
                m.Name,
                m.Email,
                m.HashPassword,
                m.Salt
            }).ToList(); ;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PasswordtxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewMembersAsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewMembers_Load(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void ViewMembersAsList_SelectionChanged(object sender, EventArgs e)
        {
            //if (ViewMembersAsList.SelectedRows.Count > 0)
            //{
            //    var selectedRow = ViewMembersAsList.SelectedRows[0];
            //    if (selectedRow.DataBoundItem is User selectedMember)
            //    {
            //        NametxtBox.Text = selectedMember.Name;
            //        EmailtxtBox.Text = selectedMember.Email;
            //        PasswordtxtBox.Text = "selected";
            //    }
            //}

        }

        private void Update_Click(object sender, EventArgs e)
        {
            User user = new User();
            user = _membersController.GetByEmail(EmailtxtBox.Text);

            if (NametxtBox.Text != "" && EmailtxtBox.Text != "" && PasswordtxtBox.Text != "")
            {
                if (user != null)
                {
                    if(PasswordtxtBox.Text.Length < 8)
                    {
                        Error.Text = "Password must be at least 8 char long";
                        Error.ForeColor = Color.Red;
                        return;
                    }
                    Error.Text = "";
                    user.Name = NametxtBox.Text;
                    user.Email = EmailtxtBox.Text;
                    user.Salt = _loginController.GenerateSalt();

                    user.HashPassword = _loginController.HashPassword(PasswordtxtBox.Text+user.Salt);
                    _membersController.UpdateMember(user.UserID, user);
                    UpdateView();
                    Error.Text = "Member Updated Successfully";

                    Error.ForeColor = Color.Green;
                }
                else
                {
                    Error.Text = "Member not found,Can't update";
                    Error.ForeColor = Color.Red;
                }
            }
            else
            {
                Error.Text = "Please fill all the fields";
                Error.ForeColor = Color.Red;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (EmailtxtBox.Text == "")
            {
                Error.Text = "Please select a member,Or at least give his email";
                Error.ForeColor = Color.Red;
                return;
            }
            User user = new User();
            user = _membersController.GetByEmail(EmailtxtBox.Text);
            if (user != null)
            {
                int x = _membersController.DeleteMember(user.UserID);
                if (x > 0)
                {
                   
                    Error.Text = "Member Deleted Successfully";
                    Error.ForeColor = Color.Green;
                }
                else if(x== 0)
                {
                    Error.Text = "Member has borrowed books, can't delete.";
                    Error.ForeColor = Color.Red;
                }
                else
                {
                    DialogResult result = MessageBox.Show(
                 "This member has returned books records. Are you sure you want to delete this member and all data for him?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
               );

                    if (result == DialogResult.Yes)
                    {
                        _membersController.DeleteFromBorrowRecordsThisMember(user.UserID);
                        _membersController.DeleteMember(user.UserID);
                        Error.Text="Member and all related data have been deleted successfully.";
                        Error.ForeColor = Color.Green;
                    }
                    else
                    {
                        Error.Text = "Member has borrowed books, can't delete.";
                        Error.ForeColor = Color.Red;
                    }

                }
            }
            else
            {
                Error.Text = "Member not found,Can't delete";
                Error.ForeColor = Color.Red;
            }
            UpdateView();
        }

        private void Error_Click(object sender, EventArgs e)
        {

        }

        private void ViewMembersAsList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ViewMembersAsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = ViewMembersAsList.Rows[e.RowIndex];
                NametxtBox.Text = row.Cells[1].Value.ToString();
                EmailtxtBox.Text = row.Cells[2].Value.ToString();
                PasswordtxtBox.Text = "";


            }
        }
    }
}
