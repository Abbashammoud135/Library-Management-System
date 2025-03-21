using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    internal class BorrowedBook
    {
       public int BorrowedID { get; set; }
        public int MemberID { get; set; }
        public int BookID { get; set; }
        public DateTime BorrowedDate { get; set; }
        public DateTime DurationToReturn { get; set; }
        public DateTime? ReturnedDate { get; set; }

        internal Controller.HelperController HelperController
        {
            get => default;
            set
            {
            }
        }
    }
}
