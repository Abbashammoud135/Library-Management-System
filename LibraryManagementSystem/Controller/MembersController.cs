using LibraryManagementSystem.Model;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using User = LibraryManagementSystem.Model.User;

namespace LibraryManagementSystem.Controller
{
    internal class MembersController
    {
        private AccessDbController _accessDb;
        private HelperController _helper;
        public MembersController() {
            _accessDb = AccessDbController.GetInstance();
            _helper= new HelperController();
        }

        //Operations on Members
        public List<User> GetAllMembers()
        {
            string query = "SELECT * FROM Members";
            return _helper.ConvertDataTableToListOfMembers(_accessDb.ExecuteQuery(query));
        }
        public User GetById(int id)
        {
            string query = "SELECT * FROM Members WHERE MemberID=@id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", id)
            };
            return _helper.ConvertDataTableToUser(_accessDb.ExecuteQuery(query, parameters));
        }
        public User GetByEmail(string email)
        {
            string query = "SELECT * FROM Members WHERE Email=@Email";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Email", email)
            };
            return _helper.ConvertDataTableToUser(_accessDb.ExecuteQuery(query, parameters));
        }

        public int AddMember(User user)
        {

            string checkEmailQuery = "SELECT COUNT(*) AS EmailCount FROM Members WHERE Email = @Email";
            SqlParameter[] checkEmailParams = new SqlParameter[]
            {
        new SqlParameter("@Email", user.Email)
            };
            DataTable result = _accessDb.ExecuteQuery(checkEmailQuery, checkEmailParams);
            // If the email already exists in the database, return 0
            if (result.Rows.Count > 0 && Convert.ToInt32(result.Rows[0]["EmailCount"]) > 0)
            {
                return 0;
            }
            // If the email does not exist in the database, insert the new member
            string query = "INSERT INTO Members (Name, Email, DateJoined, HashPassword,Salt) VALUES (@Name, @Email, @DateJoined, @HashPassword,@Salt)";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@Name", user.Name),
        new SqlParameter("@Email", user.Email),
        new SqlParameter("@DateJoined", DateTime.Now), 
        new SqlParameter("@HashPassword", user.HashPassword),
        new SqlParameter("@Salt", user.Salt)
            };

           
            return _accessDb.ExecuteNonQuery(query, parameters);
    }
        public int DeleteMember(int id)
        {
            string query = "DELETE FROM Members WHERE MemberID=@id";
            // If the member has borrowed books or has returned books, return 0,-1 respectively
            Dictionary<int, Book> borrowedBooks = BorrowedBooksForUser(id);
            if (borrowedBooks.Count > 0)
            {
                return 0;
            }
            Dictionary<BorrowedBook, string> returnBooks = ReturnedBooksForUser(id);
            if (returnBooks.Count > 0)
            {
                return -1;
            }
            SqlParameter[] parameters = new SqlParameter[]
         {
             new SqlParameter("@id", id),
         };
            return _accessDb.ExecuteNonQuery(query,parameters);
        }   
        public int DeleteFromBorrowRecordsThisMember(int id)
        {
            string query = "DELETE FROM BorrowRecords WHERE MemberID=@id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", id)
            };
            return _accessDb.ExecuteNonQuery(query, parameters);
        }
        public Book GetBookById(int id)
        {
            string query = "SELECT * FROM Books WHERE BookID=@id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", id)
            };
            return _helper.ConvertDataTableToBook(_accessDb.ExecuteQuery(query, parameters));
        }
        public Dictionary<int, Book> BorrowedBooksForUser(int id)
        {
            string query = "SELECT * FROM BorrowRecords WHERE MemberID=@id AND ReturnDate is Null";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@id", id)
            };

            List<BorrowedBook> borrowedBooks = _helper.ConvertDataTableToListOfBorrowedBooks(_accessDb.ExecuteQuery(query, parameters));
            Dictionary<int, Book> borrowedBooksDict = new Dictionary<int, Book>();

            foreach (BorrowedBook borrowedBook in borrowedBooks)
            {
                Book book = GetBookById(borrowedBook.BookID);
                borrowedBooksDict.Add(borrowedBook.BorrowedID, book); // Add BorrowID and corresponding Book to the dictionary
            }

            return borrowedBooksDict;
        }
      
        public Dictionary<BorrowedBook,string> ReturnedBooksForUser(int id)
        {
            string query = "SELECT * FROM BorrowRecords WHERE MemberID=@id AND ReturnDate IS NOT NULL";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@id", id)
            };

            List<BorrowedBook> books= _helper.ConvertDataTableToListOfBorrowedBooks(_accessDb.ExecuteQuery(query, parameters));
            Dictionary< BorrowedBook,string> borrowedBooksDict = new Dictionary<BorrowedBook, string>();
            foreach (BorrowedBook book in books)
                borrowedBooksDict.Add(book,BookName(book.BookID));
            return borrowedBooksDict;
        }
        public string BookName(int id)
        {
            string query = "SELECT Title FROM Books WHERE BookID=@id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", id)
            };
            return _accessDb.ExecuteQuery(query, parameters).Rows[0]["Title"].ToString();
        }
        public List<string> GetNotifications(int id)
        {
            string query = "SELECT NotificationMessages FROM Members WHERE MemberID=@id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", id)
            };
            DataTable result = _accessDb.ExecuteQuery(query, parameters);
            if (result.Rows.Count > 0)
            {
                string notificationsJson = result.Rows[0]["NotificationMessages"].ToString();
                if (string.IsNullOrWhiteSpace(notificationsJson))
                {
                    return new List<string>();
                }
                return JsonSerializer.Deserialize<List<string>>(notificationsJson);
            }
            return new List<string>();}
        public int UpdateMember(int id, User user)
        {

            string query = "UPDATE Members SET Name = @Name, Email = @Email, HashPassword = @Password,Salt=@Salt,NotificationMessages=@m WHERE MemberID = @MemberID";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@Name", user.Name),        
        new SqlParameter("@Email", user.Email),      
        new SqlParameter("@Password", user.HashPassword), 
        new SqlParameter("@MemberID",id),
        new SqlParameter("@Salt", user.Salt),
        new SqlParameter("@m",  serializeNotificationMessages(user.NotificationMessages))

            };

            // Execute the query
            return _accessDb.ExecuteNonQuery(query, parameters);
        }
        public string serializeNotificationMessages(List<string> messages)
        {
            return JsonSerializer.Serialize(messages);
        }
        public int numberOfMembers()
        {
            string query = "SELECT COUNT(*) AS MemberCount FROM Members";
            return Convert.ToInt32(_accessDb.ExecuteQuery(query).Rows[0]["MemberCount"]);
        }


    }
}
