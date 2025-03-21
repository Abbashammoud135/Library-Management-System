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
    public partial class ViewBooks : UserControl
    {
        BooksController _booksController;
        private string message;
        private List<Book> books;
        public ViewBooks(string message)
        {
            InitializeComponent();
            _booksController = new BooksController();
            this.message = message;
            if(message=="")
            books = _booksController.GetAllBooks();
            else
             books = _booksController.Search(message);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AuthorLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void editButton_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                string isbn = pictureBox.Name;

                MessageBox.Show($"Edit button clicked for ISBN: {isbn}");
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                string isbn = pictureBox.Name;

                MessageBox.Show($"delete button clicked for ISBN: {isbn}");
            }

        }
        public void UpdateBookPanel()
        {
            if (message == "")
                books = _booksController.GetAllBooks();
            else
                books = _booksController.Search(message);
            ViewBooksAsList.Controls.Clear();
            ViewBooksAsList.DataSource = books;
        }

        private void BookPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewBooks_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;


            UpdateBookPanel();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewBooksAsList_AllowUserToDeleteRowsChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BookImage_Click(object sender, EventArgs e)
        {

        }

        private void ViewBooksAsList_SelectionChanged(object sender, EventArgs e)
        {
            if (ViewBooksAsList.SelectedRows.Count > 0)
            {
                var selectedRow = ViewBooksAsList.SelectedRows[0];
                if (selectedRow.DataBoundItem is Book selectedBook)
                {
                    TitletxtBox.Text = selectedBook.Title;
                    AuthortextBox.Text = selectedBook.Author;
                    ISBNChange.Text = selectedBook.ISBN;
                    Counter.Value = selectedBook.Count;
                    BookImage.Image = Image.FromFile(selectedBook.ImageUrl);

                }
            }
        }

        private void ISBN_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            string isbn = ISBNChange.Text;
            if (ISBNChange.Text == "")
            {
                ErrorMessage.Text = "Please enter ISBN";
                ErrorMessage.ForeColor = Color.Red;
            }
            book = _booksController.SearchByISBN(isbn);

            if (book != null)
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..", "Assests", "Books", "images", book.ISBN + ".jpg");

                if (BookImage.Image != null && TitletxtBox.Text! != "" && AuthortextBox.Text != "")
                {
                    Error.Text = "";
                    book.Title = TitletxtBox.Text;
                    book.Author = AuthortextBox.Text;
                    book.Count = (int)Counter.Value;
                    _booksController.UpdateBook(isbn, book);
                    UpdateBookPanel();
                    ErrorMessage.Text = "Book Updated Successfully";

                    ErrorMessage.ForeColor = Color.Green;
                }
                else
                {
                    ErrorMessage.Text = "Please fill all the fields";
                    ErrorMessage.ForeColor = Color.Red;
                }
            }
           
            UpdateBookPanel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isbn = ISBNChange.Text;
            if (ISBNChange.Text == "")
            {
                ErrorMessage.Text = "Please enter ISBN";
                ErrorMessage.ForeColor = Color.Red;
            }
            else
            {
                int x = _booksController.DeleteBook(ISBNChange.Text);
                if(x == 0)
                {
                    ErrorMessage.Text = "Book is borrowed, can't delete";
                    ErrorMessage.ForeColor = Color.Red;
                }
                else if(x==-1)
                {
                    DialogResult result = MessageBox.Show("Book has been borrowed and returned, do you want to delete this book and all the informations related to this book?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        _booksController.deleteFromBorrowRecordsThisBook(isbn);
                        _booksController.DeleteBook(isbn);
                        MessageBox.Show("Book and all related data have been deleted successfully.");
                    }
                }
                else
                {
                    ErrorMessage.Text = "Book Deleted Successfully";
                    ErrorMessage.ForeColor = Color.Green;
                }
                TitletxtBox.Text = "";
                AuthortextBox.Text = "";
                ISBNChange.Text = "";
                Counter.Value = 0;
                BookImage.Image = null;
            }
            UpdateBookPanel();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void ViewBooksAsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            { 
                DataGridViewRow row = ViewBooksAsList.Rows[e.RowIndex];
                TitletxtBox.Text = row.Cells[1].Value.ToString();
                AuthortextBox.Text = row.Cells[2].Value.ToString();
                ISBNChange.Text = row.Cells[3].Value.ToString();
                ErrorMessage.Text = "";
                if (int.TryParse(row.Cells[6].Value?.ToString(), out int countValue))
                {
                    Counter.Value = countValue;
                }
                else
                {
                    Counter.Value = 0; // Default value in case parsing fails
                }

                BookImage.Image = Image.FromFile(row.Cells[4].Value.ToString());

              
               

            }
        }
    }
}
