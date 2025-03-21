using LibraryManagementSystem.Model;
using System.Data;
using System.Text.Json;



namespace LibraryManagementSystem.Controller
{
    internal class HelperController
    {
        internal BooksController BooksController
        {
            get => default;
            set
            {
            }
        }

        internal MembersController MembersController
        {
            get => default;
            set
            {
            }
        }

        public List<Book> ConvertDataTableToListOfBooks(DataTable dataTable)
        {

            if (dataTable == null || dataTable.Rows.Count == 0)
                return new List<Book>();
            List<Book> books = new List<Book>();

            for (int i = 0; i < dataTable.Rows.Count; i++)
                books.Add(ConvertDataTableToBook(dataTable, i));

            return books;
        }
        public List<User> ConvertDataTableToListOfMembers(DataTable dataTable)
        {

            if (dataTable == null || dataTable.Rows.Count == 0)
                return new List<User>();
            List<User> users = new List<User>();

            for (int i = 0; i < dataTable.Rows.Count; i++)
                users.Add(ConvertDataTableToUser(dataTable,i));

            return users;
        }
        public List<Model.BorrowedBook> ConvertDataTableToListOfBorrowedBooks(DataTable dataTable)
        {

            if (dataTable == null || dataTable.Rows.Count == 0)
                return new List<Model.BorrowedBook>();
            List<Model.BorrowedBook> Borrows = new List<Model.BorrowedBook>();

            for (int i = 0; i < dataTable.Rows.Count; i++)
                Borrows.Add(ConvertDataTableToBorrowedBook(dataTable, i));

            return Borrows;
        }
        public User? ConvertDataTableToUser(DataTable dataTable, int index = 0)
        {
            if (dataTable == null || dataTable.Rows.Count == 0)
                return null;
            return new User
            {
                UserID = Convert.ToInt32(dataTable.Rows[index]["MemberID"]),
                Name = dataTable.Rows[index]["Name"].ToString(),
                Email = dataTable.Rows[index]["Email"].ToString(),
                HashPassword = dataTable.Rows[index]["HashPassword"].ToString(),
                Salt = dataTable.Rows[index]["Salt"].ToString(),
                DateJoined = Convert.ToDateTime(dataTable.Rows[index]["DateJoined"]),
                NotificationMessages = dataTable.Rows[index]["NotificationMessages"] == DBNull.Value
                    ? new List<string>()
                    : JsonSerializer.Deserialize<List<string>>((string)dataTable.Rows[index]["NotificationMessages"]),
            };
        }
        public Book? ConvertDataTableToBook(DataTable dataTable,int index=0)
        {

            if (dataTable == null || dataTable.Rows.Count == 0)
                return null;
            return new Book
                {
                    BookID = Convert.ToInt32(dataTable.Rows[index]["BookID"]),
                    Title = dataTable.Rows[index]["Title"].ToString(),
                    Author = dataTable.Rows[index]["Author"].ToString(),
                    ISBN = dataTable.Rows[index]["ISBN"].ToString(),
                    AvailabilityStatus = (bool)dataTable.Rows[index]["AvailabilityStatus"],
                    ImageUrl = dataTable.Rows[index]["ImageUrl"].ToString(),
                    Count = Convert.ToInt32(dataTable.Rows[index]["Count"])
                };
        }
        public Model.BorrowedBook? ConvertDataTableToBorrowedBook(DataTable dataTable, int index = 0)
        {

            if (dataTable == null || dataTable.Rows.Count == 0)
                return null;
            return new Model.BorrowedBook
            {
                BorrowedID = Convert.ToInt32(dataTable.Rows[index]["BorrowID"]),
                MemberID = Convert.ToInt32(dataTable.Rows[index]["MemberID"]),
                BookID = Convert.ToInt32(dataTable.Rows[index]["BookID"]) ,
                BorrowedDate = Convert.ToDateTime(dataTable.Rows[index]["BorrowDate"]),
                DurationToReturn = Convert.ToDateTime(dataTable.Rows[index]["DurationToReturn"]),
                ReturnedDate = (dataTable.Rows[index]["ReturnDate"] == DBNull.Value)
    ? null
    : Convert.ToDateTime(dataTable.Rows[index]["ReturnDate"]),
            };
        }

    }
}
