using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Controller.BookOperations
{
    internal interface IBookOperation
    {
        string ISBN { get; set; }
        int MemberId { get; set; }
        DateTime ReturnTime { get; set; }
        int Execute();

    }
}
