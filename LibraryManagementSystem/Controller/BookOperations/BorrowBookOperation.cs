using LibraryManagementSystem.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Controller.BookOperations
{
    internal class BorrowBookOperation : IBookOperation
    {
        BooksController booksController;
        MembersController membersController;
        AccessDbController dbController;

        public string ISBN { get; set; }
        public int MemberId { get; set; }
        public DateTime ReturnTime { get; set; }

        internal IBookOperation IBookOperation
        {
            get => default;
            set
            {
            }
        }

        public BorrowBookOperation(string isbn, int MemberId, DateTime returnTime)
        {
            booksController = new BooksController();
            membersController = new MembersController();
            dbController = AccessDbController.GetInstance();
            ISBN = isbn;
            this.MemberId = MemberId;
            ReturnTime = returnTime;
        }
        public int Execute()
        {
            Book book = booksController.SearchByISBN(ISBN);
            User member = membersController.GetById(MemberId);
            Model.BorrowedBook borrowedBook = new Model.BorrowedBook
            {
                MemberID = member.UserID,
                BookID = book.BookID,
                BorrowedDate = DateTime.Now,
                DurationToReturn = ReturnTime
            };
            if (book.AvailabilityStatus)
            {
                if (book.Count <= 1)
                    book.AvailabilityStatus = false;
                 book.Count--;
                booksController.UpdateBook(ISBN, book);

                return AddBorrowedBook(borrowedBook);
            }
            return 0;
        }
        public int AddBorrowedBook(Model.BorrowedBook book)
        {
            string query = "INSERT INTO BorrowRecords (MemberID,BookID,BorrowDate,DurationToReturn) VALUES (@MemberID, @BookID, @BorrowDate,@DurationToReturn)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MemberID", book.MemberID),
        new SqlParameter("@BookID", book.BookID),
                new SqlParameter("@BorrowDate", book.BorrowedDate),
                new SqlParameter("@DurationToReturn", book.DurationToReturn),
            };


            return dbController.ExecuteNonQuery(query, parameters);
        }

    }
}
