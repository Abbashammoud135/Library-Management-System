using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Data; // Add this using directive

namespace LibraryManagementSystem.Controller
{
    internal class AdminController
    {
        private readonly AccessDbController dbController;

        public AdminController()
        {
            this.dbController = AccessDbController.GetInstance();
        }

        public int AddNotificationForAdmin(string message)
        {
            string query = "UPDATE Admins SET Notifications = @Message WHERE AdminID = @Id";
            string[] notifications = getAdminNotifications();
            notifications = notifications.Append(message).ToArray();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Message", JsonSerializer.Serialize(notifications)),
                new SqlParameter("@Id", 1)
            };
            return dbController.ExecuteNonQuery(query, parameters);
        }
        public string[] getAdminNotifications()
        {
            string query = "SELECT Notifications FROM Admins WHERE AdminID = @Id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", 1)
            };
            DataTable result = dbController.ExecuteQuery(query, parameters);
            // Rest of the code remains unchanged
            if (result.Rows.Count > 0)
            {
                string notificationsJson = result.Rows[0]["Notifications"].ToString();
                if(string.IsNullOrWhiteSpace(notificationsJson))
                {
                    return Array.Empty<string>();
                }
                return JsonSerializer.Deserialize<string[]>(notificationsJson);
            }
            return Array.Empty<string>();
        }
        public int RemoveNotificationForAdmin(string message)
        {
            string query = "UPDATE Admins SET Notifications = @Message WHERE AdminID = @Id";
            string[] notifications = getAdminNotifications();
            notifications = notifications.Where(x => x != message).ToArray();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Message", JsonSerializer.Serialize(notifications)),
                new SqlParameter("@Id", 1)
            };
            return dbController.ExecuteNonQuery(query, parameters);
        }
    }
}
