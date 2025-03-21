using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using LibraryManagementSystem.Model;

namespace LibraryManagementSystem.Controller
{
    class Books
    {
        public string? title { get; set; }
        public string? author { get; set; } 
        public string? ISBN { get; set; }
    }
    internal class SendJsonFileToDatabase
    {
        private readonly string filePath;
        private readonly string jsonString;
        private BooksController booksController;

        public SendJsonFileToDatabase()
        {
            filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,@"..\..\..", "Assests", "Books", "books.txt");
            jsonString = File.ReadAllText(filePath);
            booksController=new BooksController();
        }
        public void SaveToDatabase()
        {
            try
            {
                List<Books> books=JsonSerializer.Deserialize<List<Books>>(jsonString) ;

                Book book1 = new Book();
                foreach (var book in books)
                {
                    book1.Title = book.title;
                    book1.Author = book.author;
                    book1.ISBN = book.ISBN;
                    book1.Count = 1;
                    book1.ImageUrl = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..", "Assests", "Books", "images", book.ISBN);
                    book1.ImageUrl += ".jpg";    

                  int x=  booksController.AddBook(book1);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("can't deserialize"+ ex.Message);
            }
           
        }
    }
}
