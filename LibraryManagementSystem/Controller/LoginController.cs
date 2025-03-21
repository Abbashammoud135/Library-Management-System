using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using LibraryManagementSystem.Model;
using LibraryManagementSystem.Sessions;

namespace LibraryManagementSystem.Controller
{
    internal class LoginController
    {
        AccessDbController _dbController;
        public LoginController() { _dbController = AccessDbController.GetInstance(); }
        public string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }
        public string GenerateSalt(int size=16)
        {
            byte[] salt = new byte[size];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            return Convert.ToBase64String(salt);
        }
        public bool VerifyCredintials(User loginUser)
        {
            string query = (loginUser.IsAdmin)?"SELECT * FROM Admins WHERE Email = @Email": "SELECT * FROM Members WHERE Email = @Email";

            SqlParameter[] parameters = {
        new SqlParameter("@Email", loginUser.Email)
          };

            DataTable result = _dbController.ExecuteQuery(query, parameters);
            if (result.Rows.Count == 0)
            {
                return false;
            }

            string? storedHashPassword = result.Rows[0]["HashPassword"].ToString();
            string? storedSalt = result.Rows[0]["Salt"].ToString();

            string? enteredHashedPassword = HashPassword(loginUser.HashPassword+storedSalt);

            string role = (loginUser.IsAdmin) ? "AdminID" : "MemberID";
            loginUser.UserID = (int)result.Rows[0][role];
            loginUser.Name = result.Rows[0]["Name"].ToString();
            
            if(enteredHashedPassword == storedHashPassword)
            {
                loginUser.HashPassword = storedHashPassword;
                UserSession session = UserSession.GetInstance();
                UserSession.user= loginUser;
                return true;
            }
            return false;
        }

    }
}
