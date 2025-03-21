using LibraryManagementSystem.Model;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace LibraryManagementSystem.Controller
{
    internal class BooksController
    {
        AccessDbController dbController;
        private HelperController _helper;
        public BooksController()
        {
            dbController = AccessDbController.GetInstance();
            _helper = new HelperController();
        }

        internal SendJsonFileToDatabase SendJsonFileToDatabase
        {
            get => default;
            set
            {
            }
        }

        public List<Book> GetAllBooks()
        {
            string query = "SELECT * FROM Books";
            return _helper.ConvertDataTableToListOfBooks(dbController.ExecuteQuery(query));
        }
        public int AddBook(Book book)
        {
            Book data = SearchByISBN(book.ISBN);
            
            if (data == null)
            {
                string query = "INSERT INTO Books (Title, Author, ISBN,ImageUrl) VALUES (@Title, @Author, @ISBN, @ImageUrl)";
                SqlParameter[] parameters = new SqlParameter[]
                {
                new SqlParameter("@Title", book.Title),
                new SqlParameter("@Author", book.Author),
                new SqlParameter("@ISBN", book.ISBN),
                new SqlParameter("@ImageUrl",book.ImageUrl)
                };


                return dbController.ExecuteNonQuery(query, parameters);
            }
            //Console.WriteLine(book.Title);

            return 0;
        }
        public int deleteFromBorrowRecordsThisBook(string isbn)
        {
            int id = SearchByISBN(isbn).BookID;
            string query = "DELETE FROM BorrowRecords WHERE BookId=@id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", id),
            };
            return dbController.ExecuteNonQuery(query, parameters);
        }
        public List<BorrowedBook> getBorrowRecordsForBook(int id)
        {
            string query = "SELECT * FROM BorrowRecords WHERE BookID=@id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", id),
            };
            return _helper.ConvertDataTableToListOfBorrowedBooks(dbController.ExecuteQuery(query, parameters));

        }
        public string GetBookNameHavingBookId(int bookId)
        {
            string query = "SELECT Title FROM Books WHERE BookID=@bookId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@bookId", bookId),
            };
            DataTable result = dbController.ExecuteQuery(query, parameters);
            if (result.Rows.Count > 0)
                return result.Rows[0]["Title"].ToString();
            return ""; 


        }
        public int DeleteBook(string isbn)
        {
            string query = "DELETE FROM Books WHERE ISBN=@isbn";
            // If the Book has been borrowed or returned from BorrowRecords table, return 0,-1 respectively
            Book b= SearchByISBN(isbn);
            List<BorrowedBook> borrowedBooks = getBorrowRecordsForBook(b.BookID); 
            List<BorrowedBook> returnedBook = new List<BorrowedBook>();
            List<BorrowedBook> borrowedBook = new List<BorrowedBook>();
            foreach (var book in borrowedBooks)
            {
                if(book.ReturnedDate==null)
                {
                    borrowedBook.Add(book);
                }
                else
                {
                    returnedBook.Add(book);
                }
            }
           if(borrowedBook.Count > 0)
            {
                return 0;
            }
            if (returnedBook.Count > 0)
            {
                return -1;
            }

            SqlParameter[] parameters = new SqlParameter[]
         {
        new SqlParameter("@isbn", isbn),

         };
            return dbController.ExecuteNonQuery(query, parameters);

        }
        public int UpdateBook(string isbn, Book book)
        {
            string query = "UPDATE Books SET Title = @Title, Author = @Author,AvailabilityStatus=@AvailabilityStatus,ImageUrl = @ImageUrl,Count=@Count WHERE ISBN=@isbn";
            if(book.Count >0)
            {
               book.AvailabilityStatus = true;
            }
            else {
                book.AvailabilityStatus = false;
            }
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@Title", book.Title),
            new SqlParameter("@Author", book.Author),
            new SqlParameter("@AvailabilityStatus",book.AvailabilityStatus),
            new SqlParameter("@ImageUrl", book.ImageUrl),
            new SqlParameter("@Count",book.Count),
             new SqlParameter("@ISBN", isbn),
            
            };

            return dbController.ExecuteNonQuery(query, parameters);
        }

        public List<Book> SearchByTitle(string title)
        {
            string query = "SELECT * FROM Books WHERE Title LIKE @Title";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@Title",  title + "%")
            };

            return _helper.ConvertDataTableToListOfBooks(dbController.ExecuteQuery(query, parameters));
        }
        public List<Book> SearchByAuthor(string author)
        {
            string query = "SELECT * FROM Books WHERE Author LIKE @Author";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@Author",  author + "%")
            };

            return _helper.ConvertDataTableToListOfBooks(dbController.ExecuteQuery(query, parameters));
        }
        //Unique ISBN
        public Book SearchByISBN(string isbn)
        {
            string query = "SELECT * FROM Books WHERE ISBN = @ISBN";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@ISBN", isbn)
            };
            return _helper.ConvertDataTableToBook(dbController.ExecuteQuery(query, parameters));
        }
        public List<Book> SearchLikeISBN(string isbn)
        {
            string query = "SELECT * FROM Books WHERE ISBN Like @ISBN";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@ISBN", isbn+"%")
            };
            return _helper.ConvertDataTableToListOfBooks(dbController.ExecuteQuery(query, parameters));
        }
        public List<Book> Search(string key)
        {
            List<Book> books = new List<Book>();
            HashSet<string> seenIsbns = new HashSet<string>();

            // Search by title
            foreach (var book in SearchByTitle(key))
            {
                if (seenIsbns.Add(book.ISBN))
                {
                    books.Add(book);
                }
            }

            // Search by author
            foreach (var book in SearchByAuthor(key))
            {
                if (seenIsbns.Add(book.ISBN))
                {
                    books.Add(book);
                }
            }

            // Search by ISBN
            foreach (var book in SearchLikeISBN(key))
            {
                if (seenIsbns.Add(book.ISBN))
                {
                    books.Add(book);
                }
            }

            return books;
        }


        public bool CheckISBNIfUnique(Book book)
        {
            Book booktoCheck = SearchByISBN(book.ISBN);
            if (booktoCheck == null || (booktoCheck.Title == book.Title && booktoCheck.Author == book.Author))
                return true;
            return false;
        }
        public List<BorrowedBook> GetBorrowedBooks()
        {
            string query = "SELECT * FROM BorrowRecords";
            return _helper.ConvertDataTableToListOfBorrowedBooks(dbController.ExecuteQuery(query));
        }
        public int NumberOfBooks()
        {
            string query = "SELECT COUNT(*) AS BookCount FROM Books";
            DataTable result = dbController.ExecuteQuery(query);
            if (result.Rows.Count > 0)
                return Convert.ToInt32(result.Rows[0]["BookCount"]);
            return 0;
        }
        public int NumberOfBorrowedBooks()
        {
            string query = "SELECT COUNT(*) AS BorrowedBookCount FROM BorrowRecords";
            DataTable result = dbController.ExecuteQuery(query);
            if (result.Rows.Count > 0)
                return Convert.ToInt32(result.Rows[0]["BorrowedBookCount"]);
            return 0;
        }
        public int numberOfAuthors()
        {
            string query = "SELECT COUNT(DISTINCT Author) AS AuthorCount FROM Books";
            DataTable result = dbController.ExecuteQuery(query);
            if (result.Rows.Count > 0)
                return Convert.ToInt32(result.Rows[0]["AuthorCount"]);
            return 0;
        }
       
    }
}
