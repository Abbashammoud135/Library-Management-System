using LibraryManagementSystem.Model;

namespace LibraryManagementSystem.View
{
    partial class MemberDashboard
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
            Panel panel1 = new Panel
            {
                Name = "panel1",
                Size = new Size(262, 287),
                Location = new Point(3, 3),
                TabIndex = 0
            };

            PictureBox pictureBox1 = new PictureBox
            {
                Name = "pictureBox1",
                BackColor = SystemColors.WindowFrame,
                Size = new Size(120, 180),
                Location = new Point((panel1.Width - 100) / 2, 10), // Centering horizontally
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = Image.FromFile(book.ImageUrl)
            };

            Label BookName = new Label
            {
                Name = "BookName",
                AutoSize = true,
                Text = book.Title
            };
            // Centering BookName
            BookName.Location = new Point((panel1.Width - BookName.PreferredWidth) / 2, 190);

            Label label3 = new Label
            {
                Name = "label3",
                AutoSize = true,
                Text = "Author :"
            };

            Label Author = new Label
            {
                Name = "Author",
                AutoSize = true,
                Text = book.Author
            };

            // Calculate the total width of "Author :" + author name
            int totalWidth = label3.PreferredWidth + Author.PreferredWidth;
            int startX = (panel1.Width - totalWidth) / 2;

            label3.Location = new Point(startX, 211);
            Author.Location = new Point(startX + label3.PreferredWidth, 211);

            Button button1 = new Button
            {
                Name = book.ISBN,
                BackColor = Color.Tan,
                FlatStyle = FlatStyle.Popup,
                Size = new Size(223, 32),
                Location = new Point((panel1.Width - 223) / 2, 240), // Centering horizontally
                Text = "Borrow ",
                UseVisualStyleBackColor = false
            };
            button1.Click += BorrowBook_Click;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(BookName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Author);
            panel1.Controls.Add(button1);

            return panel1;
        }

        public Panel CreateBorrowedBookPanel(Book book,int borrowId)
        {
            Panel panel1 = new Panel
            {
                Name = "panel1",
                Size = new Size(262, 287),
                Location = new Point(3, 3),
                TabIndex = 0
            };

            PictureBox pictureBox1 = new PictureBox
            {
                Name = "pictureBox1",
                BackColor = SystemColors.WindowFrame,
                Size = new Size(120, 180),
                Location = new Point((panel1.Width - 100) / 2, 10), // Centering horizontally
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = Image.FromFile(book.ImageUrl)
            };

            Label BookName = new Label
            {
                Name = "BookName",
                AutoSize = true,
                Text = book.Title
            };
            // Centering BookName
            BookName.Location = new Point((panel1.Width - BookName.PreferredWidth) / 2, 190);

            Label label3 = new Label
            {
                Name = "label3",
                AutoSize = true,
                Text = "Author :"
            };

            Label Author = new Label
            {
                Name = "Author",
                AutoSize = true,
                Text = book.Author
            };

            // Calculate the total width of "Author :" + author name
            int totalWidth = label3.PreferredWidth + Author.PreferredWidth;
            int startX = (panel1.Width - totalWidth) / 2;

            label3.Location = new Point(startX, 211);
            Author.Location = new Point(startX + label3.PreferredWidth, 211);

            Button button1 = new Button
            {
                Name = book.ISBN,
                BackColor = Color.Tan,
                FlatStyle = FlatStyle.Popup,
                Size = new Size(223, 32),
                Location = new Point((panel1.Width - 223) / 2, 240), // Centering horizontally
                Text = "Return Book",
                UseVisualStyleBackColor = false,
                Tag=borrowId
            };
            button1.Click += ReturnBook_Click;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(BookName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Author);
            panel1.Controls.Add(button1);

            return panel1;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberDashboard));
            MainPanel = new Panel();
            Statistics = new TableLayoutPanel();
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
            panel11 = new Panel();
            label11 = new Label();
            pictureBox11 = new PictureBox();
            Background = new PictureBox();
            PanelLogOut = new Panel();
            LogOutTXT = new Label();
            PicLogOut = new PictureBox();
            menuStrip1 = new MenuStrip();
            booksToolStripMenuItem = new ToolStripMenuItem();
            issueBooksToolStripMenuItem = new ToolStripMenuItem();
            returnBooksToolStripMenuItem = new ToolStripMenuItem();
            completeBooksDetailsToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            MemberStyled = new Label();
            Exit = new PictureBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            SearchPanel = new Panel();
            searchtxtBox = new TextBox();
            label2 = new Label();
            MainPanel.SuspendLayout();
            Statistics.SuspendLayout();
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
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Background).BeginInit();
            PanelLogOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicLogOut).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Exit).BeginInit();
            SearchPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.FromArgb(154, 188, 188);
            MainPanel.Controls.Add(Statistics);
            MainPanel.Location = new Point(630, 93);
            MainPanel.Margin = new Padding(3, 2, 3, 2);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(668, 464);
            MainPanel.TabIndex = 8;
            // 
            // Statistics
            // 
            Statistics.AutoSize = true;
            Statistics.BackColor = Color.FromArgb(154, 188, 188);
            Statistics.ColumnCount = 3;
            Statistics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            Statistics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            Statistics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            Statistics.Controls.Add(panel12, 1, 0);
            Statistics.Controls.Add(panel13, 2, 0);
            Statistics.Controls.Add(panel21, 0, 1);
            Statistics.Controls.Add(panel22, 1, 1);
            Statistics.Controls.Add(panel23, 2, 1);
            Statistics.Controls.Add(panel31, 0, 2);
            Statistics.Controls.Add(panel32, 1, 2);
            Statistics.Controls.Add(panel33, 2, 2);
            Statistics.Controls.Add(panel11, 0, 0);
            Statistics.Location = new Point(15, 0);
            Statistics.Name = "Statistics";
            Statistics.RowCount = 3;
            Statistics.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            Statistics.RowStyles.Add(new RowStyle(SizeType.Percent, 34F));
            Statistics.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            Statistics.Size = new Size(647, 461);
            Statistics.TabIndex = 0;
            // 
            // panel12
            // 
            panel12.Controls.Add(label12);
            panel12.Controls.Add(pictureBox12);
            panel12.Location = new Point(216, 3);
            panel12.Name = "panel12";
            panel12.Size = new Size(174, 132);
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
            panel13.Location = new Point(435, 3);
            panel13.Name = "panel13";
            panel13.Size = new Size(198, 132);
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
            panel21.Location = new Point(3, 155);
            panel21.Name = "panel21";
            panel21.Size = new Size(178, 137);
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
            panel22.Location = new Point(216, 155);
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
            panel23.Location = new Point(435, 155);
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
            panel31.Location = new Point(3, 311);
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
            panel32.Location = new Point(216, 311);
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
            panel33.Location = new Point(435, 311);
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
            // panel11
            // 
            panel11.Controls.Add(label11);
            panel11.Controls.Add(pictureBox11);
            panel11.Location = new Point(3, 3);
            panel11.Name = "panel11";
            panel11.Size = new Size(178, 132);
            panel11.TabIndex = 0;
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
            // 
            // pictureBox11
            // 
            pictureBox11.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(27, 24);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(123, 50);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 0;
            pictureBox11.TabStop = false;
            // 
            // Background
            // 
            Background.Image = Properties.Resources.top_view_books_with_copy_space;
            Background.Location = new Point(272, -1);
            Background.Name = "Background";
            Background.Size = new Size(1341, 666);
            Background.SizeMode = PictureBoxSizeMode.StretchImage;
            Background.TabIndex = 9;
            Background.TabStop = false;
            Background.Click += Background_Click;
            // 
            // PanelLogOut
            // 
            PanelLogOut.BackColor = Color.OldLace;
            PanelLogOut.Controls.Add(LogOutTXT);
            PanelLogOut.Controls.Add(PicLogOut);
            PanelLogOut.Location = new Point(-4, 609);
            PanelLogOut.Name = "PanelLogOut";
            PanelLogOut.Size = new Size(253, 56);
            PanelLogOut.TabIndex = 10;
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
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            menuStrip1.BackColor = Color.FromArgb(154, 188, 188);
            menuStrip1.BackgroundImageLayout = ImageLayout.Stretch;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(0, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { booksToolStripMenuItem, issueBooksToolStripMenuItem, returnBooksToolStripMenuItem, completeBooksDetailsToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            menuStrip1.Location = new Point(0, 223);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(249, 276);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.BackColor = Color.OldLace;
            booksToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            booksToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            booksToolStripMenuItem.Image = (Image)resources.GetObject("booksToolStripMenuItem.Image");
            booksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            booksToolStripMenuItem.ImageTransparentColor = Color.FromArgb(0, 0, 0, 0);
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Size = new Size(243, 54);
            booksToolStripMenuItem.Text = "ViewBooks";
            booksToolStripMenuItem.Click += booksToolStripMenuItem_Click;
            // 
            // issueBooksToolStripMenuItem
            // 
            issueBooksToolStripMenuItem.BackColor = Color.FromArgb(154, 188, 188);
            issueBooksToolStripMenuItem.Image = (Image)resources.GetObject("issueBooksToolStripMenuItem.Image");
            issueBooksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            issueBooksToolStripMenuItem.Name = "issueBooksToolStripMenuItem";
            issueBooksToolStripMenuItem.Size = new Size(243, 54);
            issueBooksToolStripMenuItem.Text = "Borrrowed Books";
            issueBooksToolStripMenuItem.Click += issueBooksToolStripMenuItem_Click;
            // 
            // returnBooksToolStripMenuItem
            // 
            returnBooksToolStripMenuItem.BackColor = Color.OldLace;
            returnBooksToolStripMenuItem.Image = (Image)resources.GetObject("returnBooksToolStripMenuItem.Image");
            returnBooksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            returnBooksToolStripMenuItem.Name = "returnBooksToolStripMenuItem";
            returnBooksToolStripMenuItem.Size = new Size(243, 54);
            returnBooksToolStripMenuItem.Text = "Returned Books";
            returnBooksToolStripMenuItem.Click += returnBooksToolStripMenuItem_Click;
            // 
            // completeBooksDetailsToolStripMenuItem
            // 
            completeBooksDetailsToolStripMenuItem.BackColor = Color.FromArgb(154, 188, 188);
            completeBooksDetailsToolStripMenuItem.Image = (Image)resources.GetObject("completeBooksDetailsToolStripMenuItem.Image");
            completeBooksDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            completeBooksDetailsToolStripMenuItem.Name = "completeBooksDetailsToolStripMenuItem";
            completeBooksDetailsToolStripMenuItem.Size = new Size(243, 54);
            completeBooksDetailsToolStripMenuItem.Text = "Admin Notifications detail";
            completeBooksDetailsToolStripMenuItem.Click += completeBooksDetailsToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.BackColor = Color.OldLace;
            aboutToolStripMenuItem.Image = (Image)resources.GetObject("aboutToolStripMenuItem.Image");
            aboutToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.RightToLeft = RightToLeft.No;
            aboutToolStripMenuItem.Size = new Size(243, 54);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // MemberStyled
            // 
            MemberStyled.AutoSize = true;
            MemberStyled.Font = new Font("Wide Latin", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            MemberStyled.Location = new Point(7, 148);
            MemberStyled.Name = "MemberStyled";
            MemberStyled.Size = new Size(242, 40);
            MemberStyled.TabIndex = 11;
            MemberStyled.Text = "Member";
            MemberStyled.Click += MemberStyled_Click;
            // 
            // Exit
            // 
            Exit.Image = Properties.Resources.X;
            Exit.Location = new Point(1509, 12);
            Exit.Name = "Exit";
            Exit.Size = new Size(35, 35);
            Exit.SizeMode = PictureBoxSizeMode.Zoom;
            Exit.TabIndex = 13;
            Exit.TabStop = false;
            Exit.Click += Exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kunstler Script", 72F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(-23, 30);
            label1.Name = "label1";
            label1.Size = new Size(279, 104);
            label1.TabIndex = 14;
            label1.Text = "Welcome";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.BackColor = Color.FromArgb(154, 188, 188);
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Location = new Point(382, 36);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1108, 615);
            tableLayoutPanel1.TabIndex = 15;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint_1;
            // 
            // SearchPanel
            // 
            SearchPanel.BackColor = Color.FromArgb(154, 188, 188);
            SearchPanel.Controls.Add(searchtxtBox);
            SearchPanel.Controls.Add(label2);
            SearchPanel.Location = new Point(748, 5);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Size = new Size(398, 31);
            SearchPanel.TabIndex = 16;
            SearchPanel.Paint += SearchPanel_Paint;
            // 
            // searchtxtBox
            // 
            searchtxtBox.Location = new Point(54, 4);
            searchtxtBox.Name = "searchtxtBox";
            searchtxtBox.Size = new Size(322, 23);
            searchtxtBox.TabIndex = 1;
            searchtxtBox.TextChanged += searchtxtBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(154, 188, 188);
            label2.Location = new Point(3, 7);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 0;
            label2.Text = "Search:";
            // 
            // MemberDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(154, 188, 188);
            ClientSize = new Size(1556, 663);
            Controls.Add(SearchPanel);
            Controls.Add(MainPanel);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            Controls.Add(Exit);
            Controls.Add(PanelLogOut);
            Controls.Add(Background);
            Controls.Add(MemberStyled);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MemberDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MemberHome";
            Load += MemberDashboard_Load;
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            Statistics.ResumeLayout(false);
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
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)Background).EndInit();
            PanelLogOut.ResumeLayout(false);
            PanelLogOut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicLogOut).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Exit).EndInit();
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel MainPanel;
        private TableLayoutPanel Statistics;
        private Panel panel11;
        private Label label11;
        private PictureBox pictureBox11;
        private Panel panel12;
        private Label label12;
        private PictureBox pictureBox12;
        private Panel panel13;
        private Label label13;
        private PictureBox pictureBox13;
        private Panel panel21;
        private Label label21;
        private PictureBox pictureBox21;
        private Panel panel22;
        private Label label22;
        private PictureBox pictureBox22;
        private Panel panel23;
        private Label label23;
        private PictureBox pictureBox23;
        private Panel panel31;
        private Label label31;
        private PictureBox pictureBox31;
        private Panel panel32;
        private Label label32;
        private PictureBox pictureBox32;
        private Label label32title;
        private Panel panel33;
        private Label label33;
        private PictureBox pictureBox33;
        private Panel PanelLogOut;
        private Label LogOutTXT;
        private PictureBox PicLogOut;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem issueBooksToolStripMenuItem;
        private ToolStripMenuItem returnBooksToolStripMenuItem;
        private ToolStripMenuItem completeBooksDetailsToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private PictureBox Background;
        private Label MemberStyled;
        private PictureBox Exit;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel SearchPanel;
        private TextBox searchtxtBox;
        private Label label2;
    }
}