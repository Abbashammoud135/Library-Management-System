using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using LibraryManagementSystem.Controller;
using LibraryManagementSystem.Model;
using static LibraryManagementSystem.Controller.OverdueBooksController;

namespace LibraryManagementSystem
{
    public partial class BorrowedBooks : UserControl
    {
        private readonly NotificationManager _notificationManager;
        MembersController mc = new MembersController();
        List<BorrowedBook> listData;
        BooksController booksController;
        public BorrowedBooks()
        {
            InitializeComponent();

            displayIssuedBooksData();
            _notificationManager = new NotificationManager();
            mc = new MembersController();
            booksController = new BooksController();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayIssuedBooksData();
        }

        private void returnBooks_returnBtn_Click(object sender, EventArgs e)
        {

        }

        public void displayIssuedBooksData()
        {
            BooksController bc = new BooksController();
            listData = bc.GetBorrowedBooks().Where(m => m.ReturnedDate == null).ToList();
           
            dataGridView1.DataSource = listData;
            dataGridView1.AutoGenerateColumns = false;

            // If columns exist, remove the last one
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns.RemoveAt(dataGridView1.Columns.Count - 1);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                returnBooks_issueID.Text = row.Cells[0].Value.ToString();
                returnBooks_name.Text = row.Cells[1].Value.ToString();
                returnBooks_contact.Text = row.Cells[2].Value.ToString();
                returnBooks_email.Text = row.Cells[3].Value.ToString();
                returnBooks_bookTitle.Text = row.Cells[4].Value.ToString();

            }
        }

        public void clearFields()
        {
            returnBooks_issueID.Text = "";
            returnBooks_name.Text = "";
            returnBooks_contact.Text = "";
            returnBooks_email.Text = "";
            returnBooks_bookTitle.Text = "";
        }

        private void returnBooks_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void Notify_Click(object sender, EventArgs e)
        {
            BorrowedBook borrowedBook = SelectedBook();
            if (borrowedBook == null)
                return;
            User member = mc.GetById(borrowedBook.MemberID);
            //MessageBox.Show(member.NotificationMessages.ToString());
            _notificationManager.AddMember(member);


            BaseNotifier notifier = new BaseNotifier();
            if (Email.Checked)
            {
                notifier = new EmailNotifier(notifier);
                Error.Text = "";
            }
            if (OnLogin.Checked)
            {
                notifier = new LoginNotifier(notifier);
                Error.Text = $"Notification will be sent to {member.Name} on Login";

            }
            string name= booksController.GetBookNameHavingBookId(borrowedBook.BookID);
            _notificationManager.NotifyMembers($"You borrowed the book with name= {name} Please return the book ", notifier);


        }

        private BorrowedBook SelectedBook()
        {
            if (returnBooks_issueID.Text == "" || returnBooks_name.Text == "" || returnBooks_contact.Text == "" || returnBooks_email.Text == "" || returnBooks_bookTitle.Text == "")
            {
                MessageBox.Show("Please select a book to return");
                return null;
            }
            return new BorrowedBook
            {
                BorrowedID = Convert.ToInt32(returnBooks_issueID.Text),
                MemberID = Convert.ToInt32(returnBooks_name.Text),
                BookID = Convert.ToInt32(returnBooks_contact.Text),
                BorrowedDate = Convert.ToDateTime(returnBooks_email.Text),
                DurationToReturn = Convert.ToDateTime(returnBooks_bookTitle.Text)
            };

        }

        private void NotifyMethodchk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OnLogin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NotifyAll_Click(object sender, EventArgs e)
        {
            List<BorrowedBook> selectedBooks = listData;
            foreach (BorrowedBook book in selectedBooks)
            {

                _notificationManager.AddMember(mc.GetById(book.MemberID));

            }
            BaseNotifier notifier = new BaseNotifier();
            if (Email.Checked)
            {
                notifier = new EmailNotifier(notifier);
                Error.Text = "";
            }
            if (OnLogin.Checked)
            {
                notifier = new LoginNotifier(notifier);
                Error.Text = $"Notification will be sent to all the members";

            }
            _notificationManager.NotifyMembers("Please return the book", notifier);
            if(selectedBooks.Count == 0)
            
                Error.Text = "No Books to Notify";

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OverdueBooksController obc = new OverdueBooksController();
            List<BorrowedBook> selectedBooks= obc.GetOverDueBooks();
            foreach (BorrowedBook book in selectedBooks)
            {

                _notificationManager.AddMember(mc.GetById(book.MemberID));

            }
            BaseNotifier notifier = new BaseNotifier();
            if (Email.Checked)
            {
                notifier = new EmailNotifier(notifier);
                Error.Text = "";
            }
            if (OnLogin.Checked)
            {
                notifier = new LoginNotifier(notifier);
                Error.Text = $"Members having Overdue Books Will be notified";

            }
            if (selectedBooks.Count == 0)
                Error.Text = "No Overdue Books";
            _notificationManager.NotifyMembers("Please return the overdue books", notifier);

        }
    }
}
