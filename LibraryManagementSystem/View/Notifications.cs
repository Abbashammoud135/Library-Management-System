using LibraryManagementSystem.Controller;
using LibraryManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.View
{
    public partial class Notifications : UserControl
    {
        AdminController adminController;
        BooksController bookController;
        public Notifications()
        {
            InitializeComponent();
            adminController = new AdminController();
            bookController = new BooksController();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Notifications_Load(object sender, EventArgs e)
        {
            string[] notifications = adminController.getAdminNotifications();
            dataGridView1.DataSource = notifications.Select(x => new { Notification = x }).ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string input = row.Cells[0].Value.ToString();
                string pattern = @"ISBN:\s+(\S+)";

                Match match = Regex.Match(input, pattern);
                string isbn="";
                if (match.Success)
                {
                    isbn = match.Groups[1].Value; // Extract ISBN
                    //MessageBox.Show($"Extracted ISBN: {isbn}");
                }
                else
                {
                    MessageBox.Show("No ISBN found.");
                }
               Book book= bookController.SearchByISBN(isbn);
                if (book != null)
                {
                    EditBooks editBooks = new EditBooks(isbn);
                    editBooks.Dock = DockStyle.Fill;
                    this.Parent.Controls.Add(editBooks);
                    this.Parent.Controls.Remove(this);
                    adminController.RemoveNotificationForAdmin(input);
                }
                else
                {
                    MessageBox.Show("Book not found.");
                }
            }
        }
    }
}
