using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    public class Book
    {
        public int BookID { get; set; } // Primary key
        public string? Title { get; set; } // NVARCHAR(255)
        public string? Author { get; set; } // NVARCHAR(255)
        public string? ISBN { get; set; } // NVARCHAR(13) (Unique)
        public string? ImageUrl {  get; set; }
        public bool AvailabilityStatus { get; set; } 
        public int Count { get; set; }

        internal User User
        {
            get => default;
            set
            {
            }
        }

        internal Controller.HelperController HelperController
        {
            get => default;
            set
            {
            }
        }
    }
}
