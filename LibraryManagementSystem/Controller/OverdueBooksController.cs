using LibraryManagementSystem.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace LibraryManagementSystem.Controller
{
    // Observer Design Pattern implementation
    internal class OverdueBooksController
    {
        private readonly AccessDbController _accessDb;
        private readonly HelperController _helper;
        public OverdueBooksController()
        {
            _accessDb = AccessDbController.GetInstance();
            _helper = new HelperController();
        }
        public List<BorrowedBook> GetOverDueBooks()
        {
            string query = "SELECT * FROM BorrowRecords WHERE (DurationToReturn < @DueDate) AND (ReturnDate is NULL)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@DueDate", DateTime.Now)
            };
            return _helper.ConvertDataTableToListOfBorrowedBooks(_accessDb.ExecuteQuery(query, parameters));
        }
    }
        internal interface INotificationListener
    {

        void AddMember(User member);
        void RemoveMember(User member);
        void RemoveAllMembers();
        void NotifyMembers(string message, INotifier notifier);
    }

        internal class NotificationManager : INotificationListener
    {
            private MembersController _membersController=new MembersController();
            private readonly List<User> _members = new();

      

        public void AddMember(User member) => _members.Add(member);
            public void RemoveMember(User member) => _members.Remove(member);
            public void RemoveAllMembers() => _members.Clear();

            public void NotifyMembers(string message, INotifier notifier)//call in gui
            {
                foreach (var member in _members)
                {
                   notifier.NotifyMember(member, message);
                }
                RemoveAllMembers();
            }

        }
    //Decorator Design Pattern implementation
    internal interface INotifier
    {

        void NotifyMember(User member, string message);
        }
    internal class BaseNotifier : INotifier
        {
        protected INotifier _baseNotifier;

        

        public virtual void NotifyMember(User member, string message)
            {
                //MessageBox.Show($"Specify Notification Method");
            }
        }
    internal class EmailNotifier : BaseNotifier
        {
            //private readonly INotifier _baseNotifier;

            public EmailNotifier(INotifier baseNotifier) => _baseNotifier = baseNotifier;

            public override void NotifyMember(User member, string message)
            {
                _baseNotifier.NotifyMember(member, message);

                if (!string.IsNullOrEmpty(member.Email))
                {
                    sendEmail(member, message);
                }
            }
            private void sendEmail(User member,string message)
            {
                string recipientEmail = member.Email;
                string subject = "Notification Subject";
                string body = message;

                // Encoding the subject and body to handle spaces and special characters
                string encodedSubject = HttpUtility.UrlEncode(subject);
                string encodedBody = HttpUtility.UrlEncode(body);

                string mailtoLink = $"mailto:{recipientEmail}?subject={encodedSubject}&body={encodedBody}";

                try
                {
                    Process.Start("cmd", $"/C start {mailtoLink}");
                    Thread.Sleep(5000);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error opening email client: " + ex.Message);
                }

                //// Gmail SMTP server information
                //string smtpServer = "smtp.gmail.com";
                //int smtpPort = 587; // SMTP Port for TLS

                //// Sender's email address and credentials
                //string fromEmail = ;  // Replace with your Gmail address
                //string fromPassword = ;  // Replace with your Gmail password (or app-specific password if 2FA enabled)

                //// Create a new MailMessage object
                //MailMessage mail = new MailMessage();
                //mail.From = new MailAddress(fromEmail);
                //mail.To.Add(member.Email);
                //mail.Subject = "Notification: overdue books";
                //mail.Body = message;

                //// Setup SMTP client
                //SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort)
                //{
                //    Credentials = new NetworkCredential(fromEmail, fromPassword),
                //    EnableSsl = true // Enable SSL for secure connection
                //};

                //// Send the email
                //smtpClient.Send(mail);
                //MessageBox.Show("Email sent successfully!");


            }
        }

    internal class LoginNotifier : BaseNotifier
        {
            private MembersController mc = new MembersController();
            //private readonly INotifier _baseNotifier;

            public LoginNotifier(INotifier baseNotifier) => _baseNotifier = baseNotifier;

        public override void NotifyMember(User member, string message)
            {
                _baseNotifier.NotifyMember(member, message);
                member.NotificationMessages.Add($"Hello {member.Name} : " + message);

                mc.UpdateMember(member.UserID, member) ;
            }

        
    }
}