using LibraryManagementSystem.Controller;
using LibraryManagementSystem.Model;
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
    public partial class ReturnedBooksForAMember : UserControl
    {
        MembersController _membersController;
        public ReturnedBooksForAMember()
        {
            InitializeComponent();
            _membersController = new MembersController();
        }

        private void ReturnedBooksForAMember_Load(object sender, EventArgs e)
        {
            Dictionary<BorrowedBook, string> books= _membersController.ReturnedBooksForUser(UserSession.user.UserID);
            var dataSource = books.Select(b => new
            {
                Name = b.Value,
                BorrowedDate = b.Key.BorrowedDate,
                DurationToReturn = b.Key.DurationToReturn,
                ReturnedDate = b.Key.ReturnedDate
            }).ToList();

            dataGridView1.DataSource = dataSource;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
