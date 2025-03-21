using FontAwesome.WPF;
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
    public partial class AdminDashboard : Form
    {
        private List<Book> books;
        private BooksController bookController;
        private MembersController membersController;
        public AdminDashboard()
        {
            InitializeComponent();
            bookController = new BooksController();
            membersController = new MembersController();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void setLabelsInfo()
        {
            label11.Text = bookController.NumberOfBooks().ToString() + " Books Available";
            label12.Text = membersController.numberOfMembers().ToString() + " Members";
            label13.Text = bookController.NumberOfBorrowedBooks().ToString() + " Books Borrowed";
            label21.Text = bookController.numberOfAuthors().ToString() + " Authors";
        }
        private void Admin_Load(object sender, EventArgs e)
        {

            tableLayoutPanel1.Hide();
            toggleView.Hide();
            ViewAllBooks1.Hide();
            ViewAllBooks.Hide();
            ButtonsPanel.Controls.Clear();
            ButtonsPanel.Controls.Add(Statistics);
            setLabelsInfo();
            //ReturnToPicBooks.Show();


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SetDefaultSizeAndLocation();
            ButtonsPanel.Hide();
            tableLayoutPanel1.Hide();
            ViewAllBooks1.Hide();
            ViewAllBooks.Show();
            toggleView.Hide();
            BorrowedBooks borrowedBooks = new BorrowedBooks();
            ViewAllBooks.Controls.Clear();
            ViewAllBooks.Controls.Add(borrowedBooks);
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewBook addNewBook = new AddNewBook();
            //addNewBook.Show();
            ViewAllBooks1.Hide();
            ViewAllBooks.Hide();

            ButtonsPanel.Controls.Clear();
            tableLayoutPanel1.Hide();
            ButtonsPanel.Show();
            toggleView.Hide();
            addNewBook.Dock = DockStyle.Fill;
            ButtonsPanel.Controls.Add(addNewBook);
            //addNewBooksToolStripMenuItem.Enabled = false;

        }

        private void ButtonsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        public void show_ButtonPanel()
        {
            ButtonsPanel.Controls.Clear();
            ButtonsPanel.Show();
            ViewAllBooks1.Hide();
            ViewAllBooks.Hide();
            tableLayoutPanel1.Hide();
            toggleView.Hide();
        }
        public void hide_ButtonPanel()
        {

            UpdateBookPanel();
            ButtonsPanel.Hide();
            tableLayoutPanel1.Show();
            toggleView.Show();


        }
        private void editButton_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                string isbn = pictureBox.Name;
                EditBooks editBooks = new EditBooks(isbn);
                show_ButtonPanel();
                ButtonsPanel.Controls.Add(ReturnToPicBooks);
                ButtonsPanel.Controls.Add(editBooks);
            }
            UpdateBookPanel();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                string isbn = pictureBox.Name;
                int x = bookController.DeleteBook(isbn);
                if (x > 0)
                {
                    MessageBox.Show("Book deleted successfully");
                }
                else if (x == 0)
                {
                    MessageBox.Show("Book has been borrowed, can't delete");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Book has been borrowed and returned, do you want to delete this book and all the informations related to this book?", "Confirmation", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        bookController.deleteFromBorrowRecordsThisBook(isbn);
                        bookController.DeleteBook(isbn);
                        MessageBox.Show("Book and all related data have been deleted successfully.");
                    }

                }
            }
            UpdateBookPanel();

        }
        public void UpdateBookPanel()
        {
            // Get all books
            if (Search.Text == "")
                books = bookController.GetAllBooks();
            else
                books = bookController.Search(Search.Text);

            // Clear existing controls
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.RowCount = 0;

            // Calculate new row count dynamically
            tableLayoutPanel1.RowCount = (int)Math.Ceiling((double)books.Count / tableLayoutPanel1.ColumnCount);

            // Add only necessary rows
            for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }

            // Add book panels
            //MessageBox.Show(books.Count.ToString());
            for (int i = 0; i < books.Count; i++)
            {
                Panel bookPanel = CreateBookPanel(books[i]);
                tableLayoutPanel1.Controls.Add(bookPanel);
            }

            // Set RowCount again to match the actual number of rows used
        }
        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toggleView.Show();
            ViewAllBooks1.Hide();
            ViewAllBooks.Hide();
            Search.Text = "";

            //ViewBooks viewBooks = new ViewBooks();
            //viewBooks.Show();

            ButtonsPanel.Hide();
            tableLayoutPanel1.Show();

            //viewBooks.Dock = DockStyle.Fill;
            //ButtonsPanel.Controls.Add(viewBooks);
            UpdateBookPanel();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Background_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ButtonsPanel.Controls.Clear();
            tableLayoutPanel1.Hide();
            toggleView.Hide();
            ViewAllBooks1.Hide();
            ViewAllBooks.Hide();
            ButtonsPanel.Controls.Add(Statistics);
            ButtonsPanel.Show();
            setLabelsInfo();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tableLayoutPanel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void LogOutTXT_Click(object sender, EventArgs e)
        {

        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewMember addNewMember = new AddNewMember();
            ButtonsPanel.Controls.Clear();
            tableLayoutPanel1.Hide();
            toggleView.Hide();
            ViewAllBooks1.Hide();
            ViewAllBooks.Hide();
            ButtonsPanel.Show();
            addNewMember.Dock = DockStyle.Fill;
            ButtonsPanel.Controls.Add(addNewMember);
        }

        private void Pictures_Click(object sender, EventArgs e)
        {
            ButtonsPanel.Hide();
            ViewAllBooks1.Hide();
            UpdateBookPanel();
            tableLayoutPanel1.Show();

        }
        //private void SetDefaultSizeAndLocation()
        //{
        //    ViewAllBooks.Size = new Size(1011, 605);
        //    ViewAllBooks.Location = new Point(450,53);
        //}

        //private void SetCustomSizeAndLocation()
        //{
        //    ViewAllBooks.Size = new Size(1011, 605);
        //    ViewAllBooks.Location = new Point(533, 53);
        //}

        private void List_Click(object sender, EventArgs e)
        {
            ButtonsPanel.Hide();
            tableLayoutPanel1.Hide();
            ViewAllBooks.Hide();
            ViewAllBooks1.Show();
            toggleView.Show();
            ViewBooks viewBooks = new ViewBooks(Search.Text);
            ViewAllBooks1.Controls.Clear();
            ViewAllBooks1.Controls.Add(viewBooks);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toggleView_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            hide_ButtonPanel();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void viewStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SetDefaultSizeAndLocation();
            ButtonsPanel.Hide();
            tableLayoutPanel1.Hide();
            ViewAllBooks1.Hide();
            ViewAllBooks.Show();
            toggleView.Hide();
            ViewAllBooks.Controls.Clear();

            ViewMember viewMembers = new ViewMember();

            ViewAllBooks.Controls.Add(viewMembers);
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

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SetDefaultSizeAndLocation();
            ButtonsPanel.Hide();
            tableLayoutPanel1.Hide();
            ViewAllBooks1.Hide();
            ViewAllBooks.Show();
            toggleView.Hide();
            ReturnedBooks borrowedBooks = new ReturnedBooks();
            ViewAllBooks.Controls.Clear();
            ViewAllBooks.Controls.Add(borrowedBooks);
        }

        private void AdminStyled_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //SetDefaultSizeAndLocation();

            ButtonsPanel.Hide();
            tableLayoutPanel1.Hide();
            ViewAllBooks1.Hide();
            ViewAllBooks.Show();
            toggleView.Hide();
            ViewAllBooks.Controls.Clear();
            Notifications notifications = new Notifications();
            ViewAllBooks.Controls.Add(notifications);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (tableLayoutPanel1.Visible)
                UpdateBookPanel();
            else
                List_Click(sender, e);
        }

        private void searchtxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewAllBooks_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
