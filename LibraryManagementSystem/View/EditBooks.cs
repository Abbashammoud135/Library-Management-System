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
    public partial class EditBooks : UserControl
    {
        public string isbn;
        private readonly BooksController bookController;
        private Book book = null;
        public EditBooks(string isbn)
        {
            InitializeComponent();
            this.isbn = isbn;
            bookController = new BooksController();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Uploadbtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                BookImage.Image = Image.FromFile(filePath);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void EditBooks_Load(object sender, EventArgs e)
        {
            book = bookController.SearchByISBN(isbn);
            TitletxtBox.Text = book.Title;
            AuthortextBox.Text = book.Author;
            label1.Text = book.ISBN;
            Counter.Value = book.Count;
            BookImage.Image = Image.FromFile(book.ImageUrl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (book != null)
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..", "Assests", "Books", "images", book.ISBN + ".jpg");

                if (BookImage.Image != null && TitletxtBox.Text! != "" && AuthortextBox.Text != "")
                {
                    Error.Text = "";
                    book.Title = TitletxtBox.Text;
                    book.Author = AuthortextBox.Text;
                    book.ISBN = label1.Text;
                    book.ImageUrl = path;
                    book.Count = (int)Counter.Value;
                    bookController.UpdateBook(isbn, book);
                    Error.Text = "Book Updated Successfully";
                    Error.ForeColor = Color.Green;
                }
                else
                {
                    Error.Text = "Please fill all the fields";
                    Error.ForeColor = Color.Red;
                }
            }
        }

        private void TitletxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ISBN_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Counter_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
