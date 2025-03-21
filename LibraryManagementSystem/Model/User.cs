using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    internal class User
    {
        public int UserID { get; set; } // Primary key
        public string? Name { get; set; } // NVARCHAR(255)
        public string? Email { get; set; } // NVARCHAR(255) (Unique)
        public DateTime DateJoined{ get; set; }
        public string? HashPassword { get; set; }
        public string? Salt { get; set; }
        public bool IsAdmin { get; set; }
        public List<Book> BorrowedBooks { get; set; }
        public List<string> NotificationMessages { get; set; }

        internal Controller.HelperController HelperController
        {
            get => default;
            set
            {
            }
        }
        //public DateTime DateJoined { get; set; }
    }
}
