using LibraryManagementSystem.Model;
using LibraryManagementSystem.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryManagementSystem.Sessions
{
    internal class UserSession
    {
        public static User? user=new User ();
        private UserSession() { }
        private static UserSession instance;
        public static UserSession GetInstance()
        {
            if(instance == null)
                instance = new UserSession();
            return instance;
        }
        public static void ResetSession()
        {
           user = null;
        }

        internal UserSession UserSession1
        {
            get => default;
            set
            {
            }
        }
    }
}
