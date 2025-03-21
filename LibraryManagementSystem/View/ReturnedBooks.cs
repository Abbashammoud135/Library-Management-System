﻿using LibraryManagementSystem.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.View
{
    public partial class ReturnedBooks : UserControl
    {
        public ReturnedBooks()
        {
            InitializeComponent();
            BooksController bc = new BooksController();

           var listData = bc.GetBorrowedBooks().Where(m => m.ReturnedDate != null).ToList();

            dataGridView1.DataSource = listData;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
