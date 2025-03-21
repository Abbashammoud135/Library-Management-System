using LibraryManagementSystem.Controller;
using LibraryManagementSystem.Model;
using Microsoft.IdentityModel.Tokens;
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
    public partial class AddNewBook : UserControl
    {
        BooksController bookController;
        public AddNewBook()
        {
            bookController = new BooksController();
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private bool IsValidISBN(string isbn)
        {
            if(string.IsNullOrEmpty(isbn))
                return false;
            
            string cleanISBN = isbn.Replace("-", "");
            return cleanISBN.Length == 13;
        }
        private void AddBookButton_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Title = TitleBox.Text;
            book.Author = AuthorBox.Text;
            book.ISBN = ISBNBox.Text;
            if (book.Title == "" || book.Author == "" || book.ISBN == "" || BookImage.Image == null)
            {

                MessageBox.Show("Please fill all the fields ");
            }
            else
            {
                if(!IsValidISBN(book.ISBN))
                {
                    Error.Text = "ISBN must be 13 digits";
                    Error.ForeColor = Color.Red;
                    return;
                }
                //Ensure that the ISBN is unique
                if (bookController.CheckISBNIfUnique(book))
                {

                    book.ImageUrl = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..", "Assests", "Books", "images", book.ISBN + ".jpg");

                    BookImage.Image.Save(book.ImageUrl, System.Drawing.Imaging.ImageFormat.Jpeg);
                    //File.Copy(image, book.ImageUrl);
                    //MessageBox.Show("Book added successfully " + book.ImageUrl);
                    if (bookController.AddBook(book) > 0)
                    {
                        TitleBox.Text = "";
                        AuthorBox.Text = "";
                        ISBNBox.Text = "";
                        BookImage.Image = null;
                        Error.Text = "Book added successfully";
                        Error.ForeColor = Color.Green;
                    }
                    else
                    {
                        //MessageBox.Show("Can't add this book");
                        Error.Text = "Can't add this book";
                        Error.ForeColor = Color.Red;

                    }

                }
                else
                {
                    //MessageBox.Show("Book with this ISBN already exists, change the ISBN entered")
                    //;
                    Error.Text = "Book with this ISBN already exists, change the ISBN";
                    Error.ForeColor = Color.Red;
                }
            }


        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ImageUploader_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                BookImage.Image = Image.FromFile(filePath);
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void BookImage_Click(object sender, EventArgs e)
        {

        }

        private void AddNewBook_Load(object sender, EventArgs e)
        {
            Error.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ISBNBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
