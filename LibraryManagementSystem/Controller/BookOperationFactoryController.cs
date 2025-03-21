using LibraryManagementSystem.Controller.BookOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Controller
{
    internal class BookOperationFactoryController
    {

        public IBookOperation HandleBookoperation(string ISBN,int memberId, DateTime returntime,string Type,int borrowId=-1)
        {
            if (Type == "borrow")
                return new BorrowBookOperation(ISBN, memberId, returntime);
            if (Type == "return" && borrowId!=-1)
                return new ReturnBookOperation(ISBN, memberId, DateTime.Now,borrowId);
            else
                throw new InvalidOperationException("Invalid operation type");
        }
    }
}
