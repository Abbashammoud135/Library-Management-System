using LibraryManagementSystem.Model;
using LibraryManagementSystem.Sessions;
using System.Windows.Forms;

namespace LibraryManagementSystem.View
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public Panel CreateBookPanel(Book book)
        {
            Panel bookPanel = new Panel
            {
                BackColor = SystemColors.ButtonFace,
                Name = $"BookPanel{book.ISBN}",
                Size = new Size(197, 254),
                Margin = new Padding(10)
            };

            PictureBox pictureBox2 = new PictureBox
            {
                Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..", "Assests", "edit.png")),

                Location = new Point(35, 196),
                Name = $"{book.ISBN}",
                Size = new Size(47, 38),
                SizeMode = PictureBoxSizeMode.Zoom
            };
            pictureBox2.Click += editButton_Click;
            PictureBox pictureBox3 = new PictureBox
            {
                Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..", "Assests", "delete.png")),

                Location = new Point(120, 196),
                Name = $"{book.ISBN}",
                Size = new Size(39, 38),
                SizeMode = PictureBoxSizeMode.Zoom
            };
            pictureBox3.Click += deleteButton_Click;


            Label titleLabel = new Label
            {
                AutoSize = true,
                Location = new Point(10, 151),
                Name = $"TitleLabel{book.ISBN}",
                MaximumSize = new Size(180, 0),
                Text = book.Title
            };

            PictureBox bookImage = new PictureBox
            {
                Location = new Point(22, 14),
                Name = $"BookImage{book.ISBN}",
                Size = new Size(152, 127),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = Image.FromFile(book.ImageUrl)
            };

            // Add controls to the panel
            bookPanel.Controls.Add(pictureBox2);
            bookPanel.Controls.Add(pictureBox3);
            //bookPanel.Controls.Add(authorLabel);
            bookPanel.Controls.Add(titleLabel);
            bookPanel.Controls.Add(bookImage);
            return bookPanel;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            WelcomeAdmin = new Label();
            menuStrip1 = new MenuStrip();
            booksToolStripMenuItem = new ToolStripMenuItem();
            addNewBooksToolStripMenuItem = new ToolStripMenuItem();
            viewBooksToolStripMenuItem = new ToolStripMenuItem();
            studentsToolStripMenuItem = new ToolStripMenuItem();
            addStudentToolStripMenuItem = new ToolStripMenuItem();
            viewStudentsToolStripMenuItem = new ToolStripMenuItem();
            issueBooksToolStripMenuItem = new ToolStripMenuItem();
            returnBooksToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            ButtonsPanel = new Panel();
            ReturnToPicBooks = new PictureBox();
            Statistics = new TableLayoutPanel();
            panel11 = new Panel();
            label11 = new Label();
            pictureBox11 = new PictureBox();
            panel12 = new Panel();
            label12 = new Label();
            pictureBox12 = new PictureBox();
            panel13 = new Panel();
            label13 = new Label();
            pictureBox13 = new PictureBox();
            panel21 = new Panel();
            label21 = new Label();
            pictureBox21 = new PictureBox();
            panel22 = new Panel();
            label22 = new Label();
            pictureBox22 = new PictureBox();
            panel23 = new Panel();
            label23 = new Label();
            pictureBox23 = new PictureBox();
            panel31 = new Panel();
            label31 = new Label();
            pictureBox31 = new PictureBox();
            panel32 = new Panel();
            label32 = new Label();
            pictureBox32 = new PictureBox();
            label32title = new Label();
            panel33 = new Panel();
            label33 = new Label();
            pictureBox33 = new PictureBox();
            Background = new PictureBox();
            PanelLogOut = new Panel();
            LogOutTXT = new Label();
            PicLogOut = new PictureBox();
            AdminStyled = new Label();
            Exit = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            Pictures = new PictureBox();
            List = new PictureBox();
            toggleView = new Panel();
            label1 = new Label();
            Search = new TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            ViewAllBooks1 = new Panel();
            ViewAllBooks = new Panel();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            ButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ReturnToPicBooks).BeginInit();
            Statistics.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).BeginInit();
            panel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox22).BeginInit();
            panel23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox23).BeginInit();
            panel31.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox31).BeginInit();
            panel32.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox32).BeginInit();
            panel33.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox33).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Background).BeginInit();
            PanelLogOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicLogOut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pictures).BeginInit();
            ((System.ComponentModel.ISupportInitialize)List).BeginInit();
            toggleView.SuspendLayout();
            SuspendLayout();
            // 
            // WelcomeAdmin
            // 
            WelcomeAdmin.AutoSize = true;
            WelcomeAdmin.BackColor = Color.FromArgb(154, 188, 188);
            WelcomeAdmin.Font = new Font("Times New Roman", 12F);
            WelcomeAdmin.Location = new Point(1013, 28);
            WelcomeAdmin.Name = "WelcomeAdmin";
            WelcomeAdmin.Size = new Size(118, 19);
            WelcomeAdmin.TabIndex = 0;
            WelcomeAdmin.Text = "Welcome, Admin!";
            WelcomeAdmin.Click += label1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            menuStrip1.BackColor = Color.FromArgb(154, 188, 188);
            menuStrip1.BackgroundImageLayout = ImageLayout.Stretch;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(0, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { booksToolStripMenuItem, studentsToolStripMenuItem, issueBooksToolStripMenuItem, returnBooksToolStripMenuItem, toolStripMenuItem1, aboutToolStripMenuItem });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            menuStrip1.Location = new Point(1, 190);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(0);
            menuStrip1.Size = new Size(214, 326);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.BackColor = Color.OldLace;
            booksToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            booksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewBooksToolStripMenuItem, viewBooksToolStripMenuItem });
            booksToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            booksToolStripMenuItem.Image = (Image)resources.GetObject("booksToolStripMenuItem.Image");
            booksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            booksToolStripMenuItem.ImageTransparentColor = Color.FromArgb(0, 0, 0, 0);
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Padding = new Padding(0);
            booksToolStripMenuItem.Size = new Size(213, 54);
            booksToolStripMenuItem.Text = "Books";
            booksToolStripMenuItem.Click += booksToolStripMenuItem_Click;
            // 
            // addNewBooksToolStripMenuItem
            // 
            addNewBooksToolStripMenuItem.Image = (Image)resources.GetObject("addNewBooksToolStripMenuItem.Image");
            addNewBooksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addNewBooksToolStripMenuItem.Name = "addNewBooksToolStripMenuItem";
            addNewBooksToolStripMenuItem.Size = new Size(220, 56);
            addNewBooksToolStripMenuItem.Text = "Add New Books";
            addNewBooksToolStripMenuItem.Click += addNewBooksToolStripMenuItem_Click;
            // 
            // viewBooksToolStripMenuItem
            // 
            viewBooksToolStripMenuItem.Image = (Image)resources.GetObject("viewBooksToolStripMenuItem.Image");
            viewBooksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            viewBooksToolStripMenuItem.Name = "viewBooksToolStripMenuItem";
            viewBooksToolStripMenuItem.Size = new Size(220, 56);
            viewBooksToolStripMenuItem.Text = "View Books";
            viewBooksToolStripMenuItem.Click += viewBooksToolStripMenuItem_Click;
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.BackColor = Color.FromArgb(154, 188, 188);
            studentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addStudentToolStripMenuItem, viewStudentsToolStripMenuItem });
            studentsToolStripMenuItem.Image = (Image)resources.GetObject("studentsToolStripMenuItem.Image");
            studentsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new Size(213, 54);
            studentsToolStripMenuItem.Text = "Members";
            // 
            // addStudentToolStripMenuItem
            // 
            addStudentToolStripMenuItem.Image = (Image)resources.GetObject("addStudentToolStripMenuItem.Image");
            addStudentToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            addStudentToolStripMenuItem.Size = new Size(213, 56);
            addStudentToolStripMenuItem.Text = "Add Member";
            addStudentToolStripMenuItem.Click += addStudentToolStripMenuItem_Click;
            // 
            // viewStudentsToolStripMenuItem
            // 
            viewStudentsToolStripMenuItem.Image = (Image)resources.GetObject("viewStudentsToolStripMenuItem.Image");
            viewStudentsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            viewStudentsToolStripMenuItem.Name = "viewStudentsToolStripMenuItem";
            viewStudentsToolStripMenuItem.Size = new Size(213, 56);
            viewStudentsToolStripMenuItem.Text = "View Members";
            viewStudentsToolStripMenuItem.Click += viewStudentsToolStripMenuItem_Click;
            // 
            // issueBooksToolStripMenuItem
            // 
            issueBooksToolStripMenuItem.BackColor = Color.OldLace;
            issueBooksToolStripMenuItem.Image = (Image)resources.GetObject("issueBooksToolStripMenuItem.Image");
            issueBooksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            issueBooksToolStripMenuItem.Name = "issueBooksToolStripMenuItem";
            issueBooksToolStripMenuItem.Size = new Size(213, 54);
            issueBooksToolStripMenuItem.Text = "Borrrowed Books";
            issueBooksToolStripMenuItem.Click += issueBooksToolStripMenuItem_Click;
            // 
            // returnBooksToolStripMenuItem
            // 
            returnBooksToolStripMenuItem.BackColor = Color.FromArgb(154, 188, 188);
            returnBooksToolStripMenuItem.Image = (Image)resources.GetObject("returnBooksToolStripMenuItem.Image");
            returnBooksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            returnBooksToolStripMenuItem.Name = "returnBooksToolStripMenuItem";
            returnBooksToolStripMenuItem.Size = new Size(213, 54);
            returnBooksToolStripMenuItem.Text = "Returned Books";
            returnBooksToolStripMenuItem.Click += returnBooksToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.BackColor = Color.OldLace;
            toolStripMenuItem1.Image = Properties.Resources.icons8_book_philosophy_50;
            toolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(213, 54);
            toolStripMenuItem1.Text = "Notifications";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.BackColor = Color.FromArgb(154, 188, 188);
            aboutToolStripMenuItem.Image = (Image)resources.GetObject("aboutToolStripMenuItem.Image");
            aboutToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.RightToLeft = RightToLeft.No;
            aboutToolStripMenuItem.Size = new Size(213, 54);
            aboutToolStripMenuItem.Text = "About  And  Statistics";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // ButtonsPanel
            // 
            ButtonsPanel.BackColor = Color.FromArgb(154, 188, 188);
            ButtonsPanel.Controls.Add(ReturnToPicBooks);
            ButtonsPanel.Controls.Add(Statistics);
            ButtonsPanel.Location = new Point(682, 58);
            ButtonsPanel.Margin = new Padding(3, 2, 3, 2);
            ButtonsPanel.Name = "ButtonsPanel";
            ButtonsPanel.Size = new Size(761, 506);
            ButtonsPanel.TabIndex = 2;
            ButtonsPanel.Paint += ButtonsPanel_Paint;
            // 
            // ReturnToPicBooks
            // 
            ReturnToPicBooks.Image = (Image)resources.GetObject("ReturnToPicBooks.Image");
            ReturnToPicBooks.Location = new Point(20, 13);
            ReturnToPicBooks.Name = "ReturnToPicBooks";
            ReturnToPicBooks.Size = new Size(42, 24);
            ReturnToPicBooks.SizeMode = PictureBoxSizeMode.Zoom;
            ReturnToPicBooks.TabIndex = 10;
            ReturnToPicBooks.TabStop = false;
            ReturnToPicBooks.Click += pictureBox2_Click;
            // 
            // Statistics
            // 
            Statistics.AutoSize = true;
            Statistics.ColumnCount = 3;
            Statistics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            Statistics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            Statistics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            Statistics.Controls.Add(panel11, 0, 0);
            Statistics.Controls.Add(panel12, 1, 0);
            Statistics.Controls.Add(panel13, 2, 0);
            Statistics.Controls.Add(panel21, 0, 1);
            Statistics.Controls.Add(panel22, 1, 1);
            Statistics.Controls.Add(panel23, 2, 1);
            Statistics.Controls.Add(panel31, 0, 2);
            Statistics.Controls.Add(panel32, 1, 2);
            Statistics.Controls.Add(panel33, 2, 2);
            Statistics.Location = new Point(156, 43);
            Statistics.Name = "Statistics";
            Statistics.RowCount = 3;
            Statistics.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            Statistics.RowStyles.Add(new RowStyle(SizeType.Percent, 34F));
            Statistics.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            Statistics.Size = new Size(491, 422);
            Statistics.TabIndex = 0;
            // 
            // panel11
            // 
            panel11.Controls.Add(label11);
            panel11.Controls.Add(pictureBox11);
            panel11.Location = new Point(3, 3);
            panel11.Name = "panel11";
            panel11.Size = new Size(156, 132);
            panel11.TabIndex = 0;
            panel11.Paint += panel11_Paint;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F);
            label11.Location = new Point(10, 94);
            label11.Name = "label11";
            label11.Size = new Size(136, 19);
            label11.TabIndex = 1;
            label11.Text = "##+ Books Available";
            label11.Click += label11_Click;
            // 
            // pictureBox11
            // 
            pictureBox11.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(27, 24);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(101, 50);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 0;
            pictureBox11.TabStop = false;
            // 
            // panel12
            // 
            panel12.Controls.Add(label12);
            panel12.Controls.Add(pictureBox12);
            panel12.Location = new Point(165, 3);
            panel12.Name = "panel12";
            panel12.Size = new Size(160, 132);
            panel12.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F);
            label12.Location = new Point(32, 94);
            label12.Name = "label12";
            label12.Size = new Size(96, 19);
            label12.TabIndex = 1;
            label12.Text = "##+ Members";
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(30, 24);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(100, 50);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 0;
            pictureBox12.TabStop = false;
            // 
            // panel13
            // 
            panel13.Controls.Add(label13);
            panel13.Controls.Add(pictureBox13);
            panel13.Location = new Point(331, 3);
            panel13.Name = "panel13";
            panel13.Size = new Size(156, 132);
            panel13.TabIndex = 2;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 12F);
            label13.Location = new Point(6, 94);
            label13.Name = "label13";
            label13.Size = new Size(144, 19);
            label13.TabIndex = 1;
            label13.Text = "##+ Borrowed Books";
            // 
            // pictureBox13
            // 
            pictureBox13.Image = (Image)resources.GetObject("pictureBox13.Image");
            pictureBox13.Location = new Point(28, 24);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(100, 50);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 0;
            pictureBox13.TabStop = false;
            // 
            // panel21
            // 
            panel21.Controls.Add(label21);
            panel21.Controls.Add(pictureBox21);
            panel21.Location = new Point(3, 142);
            panel21.Name = "panel21";
            panel21.Size = new Size(156, 137);
            panel21.TabIndex = 3;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Times New Roman", 12F);
            label21.Location = new Point(35, 94);
            label21.Name = "label21";
            label21.Size = new Size(85, 19);
            label21.TabIndex = 1;
            label21.Text = "##+ Authors";
            // 
            // pictureBox21
            // 
            pictureBox21.Image = (Image)resources.GetObject("pictureBox21.Image");
            pictureBox21.Location = new Point(28, 24);
            pictureBox21.Name = "pictureBox21";
            pictureBox21.Size = new Size(100, 50);
            pictureBox21.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox21.TabIndex = 0;
            pictureBox21.TabStop = false;
            // 
            // panel22
            // 
            panel22.Controls.Add(label22);
            panel22.Controls.Add(pictureBox22);
            panel22.Location = new Point(165, 142);
            panel22.Name = "panel22";
            panel22.Size = new Size(160, 137);
            panel22.TabIndex = 4;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Times New Roman", 12F);
            label22.Location = new Point(44, 94);
            label22.Name = "label22";
            label22.Size = new Size(63, 19);
            label22.TabIndex = 1;
            label22.Text = "5+ Years";
            // 
            // pictureBox22
            // 
            pictureBox22.Image = (Image)resources.GetObject("pictureBox22.Image");
            pictureBox22.Location = new Point(30, 24);
            pictureBox22.Name = "pictureBox22";
            pictureBox22.Size = new Size(100, 50);
            pictureBox22.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox22.TabIndex = 0;
            pictureBox22.TabStop = false;
            // 
            // panel23
            // 
            panel23.Controls.Add(label23);
            panel23.Controls.Add(pictureBox23);
            panel23.Location = new Point(331, 142);
            panel23.Name = "panel23";
            panel23.Size = new Size(156, 137);
            panel23.TabIndex = 5;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Times New Roman", 12F);
            label23.Location = new Point(37, 94);
            label23.Name = "label23";
            label23.Size = new Size(81, 19);
            label23.TabIndex = 1;
            label23.Text = "15+ Genres";
            // 
            // pictureBox23
            // 
            pictureBox23.Image = (Image)resources.GetObject("pictureBox23.Image");
            pictureBox23.Location = new Point(28, 24);
            pictureBox23.Name = "pictureBox23";
            pictureBox23.Size = new Size(100, 50);
            pictureBox23.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox23.TabIndex = 0;
            pictureBox23.TabStop = false;
            // 
            // panel31
            // 
            panel31.Controls.Add(label31);
            panel31.Controls.Add(pictureBox31);
            panel31.Location = new Point(3, 285);
            panel31.Name = "panel31";
            panel31.Size = new Size(156, 132);
            panel31.TabIndex = 6;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Times New Roman", 10F);
            label31.Location = new Point(40, 113);
            label31.Name = "label31";
            label31.Size = new Size(75, 16);
            label31.TabIndex = 1;
            label31.Text = "The Shining";
            // 
            // pictureBox31
            // 
            pictureBox31.Image = (Image)resources.GetObject("pictureBox31.Image");
            pictureBox31.Location = new Point(33, 23);
            pictureBox31.Name = "pictureBox31";
            pictureBox31.Size = new Size(94, 89);
            pictureBox31.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox31.TabIndex = 0;
            pictureBox31.TabStop = false;
            // 
            // panel32
            // 
            panel32.Controls.Add(label32);
            panel32.Controls.Add(pictureBox32);
            panel32.Controls.Add(label32title);
            panel32.Location = new Point(165, 285);
            panel32.Name = "panel32";
            panel32.Size = new Size(160, 132);
            panel32.TabIndex = 7;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Times New Roman", 10F);
            label32.Location = new Point(21, 113);
            label32.Name = "label32";
            label32.Size = new Size(118, 16);
            label32.TabIndex = 1;
            label32.Text = "Pride And Prejudice";
            // 
            // pictureBox32
            // 
            pictureBox32.Image = (Image)resources.GetObject("pictureBox32.Image");
            pictureBox32.Location = new Point(33, 23);
            pictureBox32.Name = "pictureBox32";
            pictureBox32.Size = new Size(94, 89);
            pictureBox32.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox32.TabIndex = 0;
            pictureBox32.TabStop = false;
            // 
            // label32title
            // 
            label32title.AutoSize = true;
            label32title.Font = new Font("Times New Roman", 12F);
            label32title.Location = new Point(13, 0);
            label32title.Name = "label32title";
            label32title.Size = new Size(127, 19);
            label32title.TabIndex = 0;
            label32title.Text = "Members Favorites";
            // 
            // panel33
            // 
            panel33.Controls.Add(label33);
            panel33.Controls.Add(pictureBox33);
            panel33.Location = new Point(331, 285);
            panel33.Name = "panel33";
            panel33.Size = new Size(156, 132);
            panel33.TabIndex = 8;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Times New Roman", 10F);
            label33.Location = new Point(43, 113);
            label33.Name = "label33";
            label33.Size = new Size(70, 16);
            label33.TabIndex = 1;
            label33.Text = "The Hobbit";
            // 
            // pictureBox33
            // 
            pictureBox33.Image = (Image)resources.GetObject("pictureBox33.Image");
            pictureBox33.Location = new Point(33, 23);
            pictureBox33.Name = "pictureBox33";
            pictureBox33.Size = new Size(94, 89);
            pictureBox33.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox33.TabIndex = 0;
            pictureBox33.TabStop = false;
            // 
            // Background
            // 
            Background.Image = (Image)resources.GetObject("Background.Image");
            Background.Location = new Point(225, 0);
            Background.Name = "Background";
            Background.Size = new Size(1380, 674);
            Background.SizeMode = PictureBoxSizeMode.StretchImage;
            Background.TabIndex = 3;
            Background.TabStop = false;
            Background.Click += Background_Click;
            // 
            // PanelLogOut
            // 
            PanelLogOut.BackColor = Color.OldLace;
            PanelLogOut.Controls.Add(LogOutTXT);
            PanelLogOut.Controls.Add(PicLogOut);
            PanelLogOut.Location = new Point(1, 601);
            PanelLogOut.Name = "PanelLogOut";
            PanelLogOut.Size = new Size(214, 56);
            PanelLogOut.TabIndex = 4;
            PanelLogOut.Click += PanelLogOut_Click;
            PanelLogOut.Paint += PanelLogOut_Paint;
            // 
            // LogOutTXT
            // 
            LogOutTXT.AutoSize = true;
            LogOutTXT.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOutTXT.Location = new Point(86, 17);
            LogOutTXT.Name = "LogOutTXT";
            LogOutTXT.Size = new Size(64, 19);
            LogOutTXT.TabIndex = 1;
            LogOutTXT.Text = "Log Out";
            LogOutTXT.Click += LogOutTXT_Click;
            // 
            // PicLogOut
            // 
            PicLogOut.Image = (Image)resources.GetObject("PicLogOut.Image");
            PicLogOut.Location = new Point(42, 2);
            PicLogOut.Name = "PicLogOut";
            PicLogOut.Size = new Size(38, 50);
            PicLogOut.SizeMode = PictureBoxSizeMode.CenterImage;
            PicLogOut.TabIndex = 0;
            PicLogOut.TabStop = false;
            // 
            // AdminStyled
            // 
            AdminStyled.AutoSize = true;
            AdminStyled.Font = new Font("Kunstler Script", 48F, FontStyle.Italic, GraphicsUnit.Point, 0);
            AdminStyled.Location = new Point(22, 83);
            AdminStyled.Name = "AdminStyled";
            AdminStyled.Size = new Size(169, 69);
            AdminStyled.TabIndex = 5;
            AdminStyled.Text = "Admin";
            AdminStyled.Click += AdminStyled_Click;
            // 
            // Exit
            // 
            Exit.BackColor = Color.FromArgb(154, 188, 188);
            Exit.Image = (Image)resources.GetObject("Exit.Image");
            Exit.Location = new Point(1509, 12);
            Exit.Name = "Exit";
            Exit.Size = new Size(35, 35);
            Exit.SizeMode = PictureBoxSizeMode.Zoom;
            Exit.TabIndex = 6;
            Exit.TabStop = false;
            Exit.Click += Exit_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.BackColor = Color.FromArgb(128, 162, 162);
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 254F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 242F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 260F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 232F));
            tableLayoutPanel1.Location = new Point(553, 53);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Size = new Size(988, 600);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(17, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 187);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Pictures
            // 
            Pictures.Image = (Image)resources.GetObject("Pictures.Image");
            Pictures.Location = new Point(56, 218);
            Pictures.Name = "Pictures";
            Pictures.Size = new Size(48, 50);
            Pictures.SizeMode = PictureBoxSizeMode.Zoom;
            Pictures.TabIndex = 8;
            Pictures.TabStop = false;
            Pictures.Click += Pictures_Click;
            // 
            // List
            // 
            List.BackgroundImage = (Image)resources.GetObject("List.BackgroundImage");
            List.BackgroundImageLayout = ImageLayout.Zoom;
            List.Location = new Point(158, 218);
            List.Name = "List";
            List.Size = new Size(65, 50);
            List.TabIndex = 9;
            List.TabStop = false;
            List.Click += List_Click;
            // 
            // toggleView
            // 
            toggleView.BackColor = Color.FromArgb(128, 162, 162);
            toggleView.Controls.Add(label1);
            toggleView.Controls.Add(Search);
            toggleView.Controls.Add(pictureBox1);
            toggleView.Controls.Add(List);
            toggleView.Controls.Add(Pictures);
            toggleView.Location = new Point(237, 190);
            toggleView.Name = "toggleView";
            toggleView.Size = new Size(289, 333);
            toggleView.TabIndex = 10;
            toggleView.Paint += toggleView_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 284);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 11;
            label1.Text = "Search";
            // 
            // Search
            // 
            Search.Location = new Point(17, 302);
            Search.Name = "Search";
            Search.Size = new Size(252, 23);
            Search.TabIndex = 10;
            Search.TextChanged += textBox1_TextChanged;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // ViewAllBooks1
            // 
            ViewAllBooks1.BackColor = Color.FromArgb(128, 162, 162);
            ViewAllBooks1.Location = new Point(532, 53);
            ViewAllBooks1.Name = "ViewAllBooks1";
            ViewAllBooks1.Size = new Size(1012, 605);
            ViewAllBooks1.TabIndex = 11;
            ViewAllBooks1.Paint += panel1_Paint;
            // 
            // ViewAllBooks
            // 
            ViewAllBooks.BackColor = Color.FromArgb(128, 162, 162);
            ViewAllBooks.Location = new Point(431, 50);
            ViewAllBooks.Name = "ViewAllBooks";
            ViewAllBooks.Size = new Size(1011, 605);
            ViewAllBooks.TabIndex = 12;
            ViewAllBooks.Paint += ViewAllBooks_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(5, 28);
            label2.Name = "label2";
            label2.Size = new Size(210, 55);
            label2.TabIndex = 13;
            label2.Text = "Welcome";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(154, 188, 188);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1556, 663);
            Controls.Add(toggleView);
            Controls.Add(Exit);
            Controls.Add(WelcomeAdmin);
            Controls.Add(PanelLogOut);
            Controls.Add(ButtonsPanel);
            Controls.Add(menuStrip1);
            Controls.Add(AdminStyled);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(ViewAllBooks1);
            Controls.Add(ViewAllBooks);
            Controls.Add(Background);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += Admin_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ButtonsPanel.ResumeLayout(false);
            ButtonsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ReturnToPicBooks).EndInit();
            Statistics.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).EndInit();
            panel22.ResumeLayout(false);
            panel22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox22).EndInit();
            panel23.ResumeLayout(false);
            panel23.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox23).EndInit();
            panel31.ResumeLayout(false);
            panel31.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox31).EndInit();
            panel32.ResumeLayout(false);
            panel32.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox32).EndInit();
            panel33.ResumeLayout(false);
            panel33.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox33).EndInit();
            ((System.ComponentModel.ISupportInitialize)Background).EndInit();
            PanelLogOut.ResumeLayout(false);
            PanelLogOut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicLogOut).EndInit();
            ((System.ComponentModel.ISupportInitialize)Exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pictures).EndInit();
            ((System.ComponentModel.ISupportInitialize)List).EndInit();
            toggleView.ResumeLayout(false);
            toggleView.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label WelcomeAdmin;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem addNewBooksToolStripMenuItem;
        private ToolStripMenuItem viewBooksToolStripMenuItem;
        private ToolStripMenuItem studentsToolStripMenuItem;
        private ToolStripMenuItem addStudentToolStripMenuItem;
        private ToolStripMenuItem viewStudentsToolStripMenuItem;
        private ToolStripMenuItem issueBooksToolStripMenuItem;
        private ToolStripMenuItem returnBooksToolStripMenuItem;
        private Panel ButtonsPanel;
        private PictureBox Background;
        private Panel PanelLogOut;
        private PictureBox PicLogOut;
        private Label LogOutTXT;
        private Label AdminStyled;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private PictureBox Exit;
        private TableLayoutPanel Statistics;
        private Panel panel11;
        private Label label11;
        private PictureBox pictureBox11;
        private Panel panel12;
        private PictureBox pictureBox12;
        private Label label12;
        private Panel panel13;
        private Label label13;
        private PictureBox pictureBox13;
        private Panel panel21;
        private PictureBox pictureBox21;
        private Label label21;
        private Panel panel22;
        private Label label22;
        private PictureBox pictureBox22;
        private Panel panel23;
        private Label label23;
        private PictureBox pictureBox23;
        private Panel panel31;
        private PictureBox pictureBox32;
        private Panel panel32;
        private Label label32title;
        private Panel panel33;
        private Label label32;
        private Label label31;
        private PictureBox pictureBox31;
        private Label label33;
        private PictureBox pictureBox33;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private PictureBox Pictures;
        private PictureBox List;
        private Panel toggleView;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private PictureBox ReturnToPicBooks;
        private Panel ViewAllBooks1;
        private ToolStripMenuItem toolStripMenuItem1;
        private Label label1;
        private TextBox Search;
        private Panel ViewAllBooks;
        private Label label2;
    }
}