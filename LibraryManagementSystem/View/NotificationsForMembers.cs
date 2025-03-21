using LibraryManagementSystem.Controller;
using LibraryManagementSystem.Sessions;
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
    public partial class NotificationsForMembers : UserControl
    {
        MembersController _membersController;
        public NotificationsForMembers()
        {
            InitializeComponent();
            _membersController = new MembersController();
        }
        private void NotificationsForMembers_Load_1(object sender, EventArgs e)
        {

            List<string> notifications = _membersController.GetNotifications(UserSession.user.UserID);
            dataGridView1.DataSource = notifications.Select(x => new { Notification = x }).ToList();
        }
    }
}
