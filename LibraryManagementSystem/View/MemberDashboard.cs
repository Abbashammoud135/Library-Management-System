using LibraryManagementSystem.Controller;
using LibraryManagementSystem.Controller.BookOperations;
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
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryManagementSystem.View
{
    public partial class MemberDashboard : Form
    {
        private BooksController bookController;
        private MembersController membersController;
        private UserSession userSession;
        private AdminController adminController;
        private List<Book> books;
        public MemberDashboard()
        {
            InitializeComponent();
            bookController = new BooksController();
            membersController = new MembersController();
            userSession = UserSession.GetInstance();
            adminController = new AdminController();
            books = new List<Book>();
        }

        private void completeBooksDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchPanel.Hide();
            NotificationsForMembers notifications = new NotificationsForMembers();
            tableLayoutPanel1.Hide();
            MainPanel.Show();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(notifications);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void setLabelsInfo()
        {
            label11.Text = bookController.NumberOfBooks().ToString() + " Books Available";
            label12.Text = membersController.numberOfMembers().ToString() + " Members";
            label13.Text = bookController.NumberOfBorrowedBooks().ToString() + " Books Borrowed";
            label21.Text = bookController.numberOfAuthors().ToString() + " Authors";
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchPanel.Hide();
            tableLayoutPanel1.Hide();
            MainPanel.Show();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(Statistics);
            setLabelsInfo();
        }

        private void MemberDashboard_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.Hide();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(Statistics);
            SearchPanel.Hide();
            setLabelsInfo();
            MemberStyled.Text = UserSession.user.Name;
        }
        public void UpdateBookPanel()
        {
            if (searchtxtBox.Text == "")
                books = bookController.GetAllBooks();
            else
                books = bookController.Search(searchtxtBox.Text);

            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.RowCount = 0;

            tableLayoutPanel1.RowCount = (int)Math.Ceiling((double)books.Count / tableLayoutPanel1.ColumnCount);

            // Add only necessary rows
            for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }

            // Add book panels
            for (int i = 0; i < books.Count; i++)
            {
                Panel bookPanel = CreateBookPanel(books[i]);
                tableLayoutPanel1.Controls.Add(bookPanel);
            }
        }
        public void UpdateBorrowedBooksPanel()
        {
            Dictionary<int, Book> books = membersController.BorrowedBooksForUser(UserSession.user.UserID);
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.RowCount = 0;
            tableLayoutPanel1.RowCount = (int)Math.Ceiling((double)books.Count / tableLayoutPanel1.ColumnCount);
            // Add only necessary rows
            for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }
            foreach (var kvp in books)
            {
                Panel bookPanel = CreateBorrowedBookPanel(kvp.Value, kvp.Key);
                tableLayoutPanel1.Controls.Add(bookPanel);
            }

        }
        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchtxtBox.Text = "";
            MainPanel.Controls.Clear();
            SearchPanel.Show();
            MainPanel.Hide();
            tableLayoutPanel1.Show();
            UpdateBookPanel();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void BorrowBook_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                string isbn = button.Name;
                Book book = bookController.SearchByISBN(isbn);
                if (book != null)
                {
                    if (book.AvailabilityStatus)
                    {
                        BookOperationFactoryController bookOperationFactory = new BookOperationFactoryController();
                        IBookOperation borrowBookOperation = bookOperationFactory.HandleBookoperation(isbn, UserSession.user.UserID, DateTime.Now.AddDays(7), "borrow");
                        int result = borrowBookOperation.Execute();
                        if (result > 0)
                        {
                            MessageBox.Show("Book Borrowed Successfully");
                            UpdateBookPanel();
                        }
                    }
                    else
                    {
                        DialogResult answer = MessageBox.Show("Book is not available. Do you want to order this book?", "Book Unavailable", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (answer == DialogResult.Yes)
                        {
                            MessageBox.Show("We'll let the admin know that you want this book, we will notify you when it is available");
                            string message = "Member :" + UserSession.user.Name + " wants to borrow book with ISBN: " + isbn + " Please add this book";
                            adminController.AddNotificationForAdmin(message);
                        }


                    }
                }
            }
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchPanel.Hide();
            MainPanel.Controls.Clear();
            MainPanel.Hide();
            tableLayoutPanel1.Show();
            UpdateBorrowedBooksPanel();

        }
        //  ,brj3 1 eza overdue then 7ut message nbho ,0 eza rj3o 3al w2et
        private void ReturnBook_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                string isbn = button.Name;
                Book book = bookController.SearchByISBN(isbn);
                if (book != null)
                {
                    BookOperationFactoryController bookOperationFactory = new BookOperationFactoryController();
                    IBookOperation returnBookOperation = bookOperationFactory.HandleBookoperation(isbn, UserSession.user.UserID, DateTime.Now, "return", (int)button.Tag);
                    //MessageBox.Show($"BorrowId: {button.Tag}, book: {book.Title}");
                    int result = returnBookOperation.Execute();

                    UpdateBorrowedBooksPanel();
                    if (result == 1)
                        MessageBox.Show("Book is overdue, you will be charged for this book");
                    else
                        MessageBox.Show("Book returned on time");

                }
            }
        }

        private void MemberStyled_Click(object sender, EventArgs e)
        {

        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchPanel.Hide();
            tableLayoutPanel1.Hide();
            MainPanel.Show();
            MainPanel.Controls.Clear();
            ReturnedBooksForAMember returnedBooks = new ReturnedBooksForAMember();
            returnedBooks.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(returnedBooks);

        }

        private void PanelLogOut_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelLogOut_Click(object sender, EventArgs e)
        {
            UserSession.ResetSession();
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void SearchPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchtxtBox_TextChanged(object sender, EventArgs e)
        {
            UpdateBookPanel();
        }

        private void Background_Click(object sender, EventArgs e)
        {

        }
    }
}
