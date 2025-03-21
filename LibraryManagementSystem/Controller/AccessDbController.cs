using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LibraryManagementSystem.Controller
{
    internal class AccessDbController
    {
        //singleton design pattern

        private static AccessDbController? _instance;
        private readonly string connectionString;
        private AccessDbController() {
            connectionString = "Server=DESKTOP-SN59TA4\\SQLEXPRESS;Database=LibraryManagementSystem;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
        }

        public static AccessDbController GetInstance()
        {
                if (_instance == null)
                    _instance = new AccessDbController();
                return _instance; 
        }

        // Method to execute a query and return the result as a DataTable
        public DataTable ExecuteQuery(string query, SqlParameter[]? parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable result = new DataTable();
                adapter.Fill(result);
                return result;
            }
        }

        // Method to execute a non-query command (e.g., INSERT, UPDATE, DELETE)
        public int ExecuteNonQuery(string query, SqlParameter[]? parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                return command.ExecuteNonQuery();
            }
        }

        }
}
