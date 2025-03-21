using LibraryManagementSystem.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Controller.BookOperations
{
    internal class ReturnBookOperation : IBookOperation
    {
        BooksController booksController;
        MembersController membersController;
        AccessDbController dbController;
        HelperController _helper;
        public int BorrowId {  get; set; }
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

        public ReturnBookOperation(string isbn, int MemberId, DateTime returnTime, int borrowId)
        {
            booksController = new BooksController();
            membersController = new MembersController();
            dbController = AccessDbController.GetInstance();
            ISBN = isbn;
            this.MemberId = MemberId;
            ReturnTime = returnTime;
            BorrowId = borrowId;
            _helper=new HelperController();
        }
        //rj3 book then as=1 and count++,brj3 1 eza overdue then 7ut message nbho ,0 eza rj3o 3al w2et
        public int Execute()
        {
            string query = "Update Books set AvailabilityStatus=@AS,Count=Count+1  where ISBN=@isbn";
            SqlParameter[] parameters = new SqlParameter[]{
                new SqlParameter("@AS",true),
                new SqlParameter("@isbn",ISBN)

            };

            int linesEffected= dbController.ExecuteNonQuery(query, parameters);
            int returnValue = 0;
            if (linesEffected > 0)
            {
                Model.BorrowedBook borrow= GetById(BorrowId);
                if(borrow.DurationToReturn <= ReturnTime)
                    returnValue = 1;
            }
            //DeleteBorrowedBook(); ma tmhee krml ybyn date of return, 3mol hon update 3al database !!!!!!!!!
            UpdateBorrowedBook();
            return returnValue;
        }
        public void DeleteBorrowedBook()
        {
            string query = "Delete from BorrowRecords where BorrowID=@id";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@id", BorrowId),
            };
            int x= dbController.ExecuteNonQuery(query, parameters);
        }
        public void UpdateBorrowedBook()
        {
            string query = "Update BorrowRecords set ReturnDate=@dor where BorrowID=@id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@dor", DateTime.Now),
                new SqlParameter("@id", BorrowId),
            };
            int x = dbController.ExecuteNonQuery(query, parameters);
        }
        public Model.BorrowedBook GetById(int id)
        {
            string query = "SELECT * FROM BorrowRecords WHERE borrowID=@id";
            SqlParameter[] parameters = new SqlParameter[]
           {
            new SqlParameter("@id", BorrowId),
           };
            return _helper.ConvertDataTableToBorrowedBook(dbController.ExecuteQuery(query,parameters));
        }
    }
}
