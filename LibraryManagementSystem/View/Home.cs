﻿using LibraryManagementSystem.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 6;

            if (panel2.Width >= 575)
            {
                timer1.Stop();

                Login lForm = new Login();
                lForm.Show();
                this.Hide();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
