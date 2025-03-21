using LibraryManagementSystem.Controller;
using LibraryManagementSystem.Model;

namespace LibraryManagementSystem.View
{
    partial class ViewBooks
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
        //public Panel CreateBookPanel(Book book)
        //{
        //    Panel bookPanel = new Panel
        //    {
        //        BackColor = SystemColors.ButtonFace,
        //        Name = $"BookPanel{book.ISBN}",
        //        Size = new Size(197, 254),
        //        Margin = new Padding(10)
        //    };

        //    PictureBox pictureBox2 = new PictureBox
        //    {
        //        Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..", "Assests", "edit.png")),

        //        Location = new Point(35, 196),
        //        Name = $"{book.ISBN}",
        //        Size = new Size(47, 38),
        //        SizeMode = PictureBoxSizeMode.Zoom
        //    };
        //    pictureBox2.Click += editButton_Click;
        //    PictureBox pictureBox3 = new PictureBox
        //    {
        //        Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..", "Assests", "delete.png")),

        //        Location = new Point(120, 196),
        //        Name = $"{book.ISBN}",
        //        Size = new Size(39, 38),
        //        SizeMode = PictureBoxSizeMode.Zoom
        //    };
        //    pictureBox3.Click += deleteButton_Click;


        //    Label titleLabel = new Label
        //    {
        //        AutoSize = true,
        //        Location = new Point(10, 151),
        //        Name = $"TitleLabel{book.ISBN}",
        //        MaximumSize = new Size(180, 0),
        //        Text = book.Title
        //    };

        //    PictureBox bookImage = new PictureBox
        //    {
        //        Location = new Point(22, 14),
        //        Name = $"BookImage{book.ISBN}",
        //        Size = new Size(152, 127),
        //        SizeMode = PictureBoxSizeMode.StretchImage,
        //        Image = Image.FromFile(book.ImageUrl)
        //    };

        //    // Add controls to the panel
        //    bookPanel.Controls.Add(pictureBox2);
        //    bookPanel.Controls.Add(pictureBox3);
        //    //bookPanel.Controls.Add(authorLabel);
        //    bookPanel.Controls.Add(titleLabel);
        //    bookPanel.Controls.Add(bookImage);
        //    return bookPanel;
        //}


        private void InitializeComponent()
        {
            ViewBooksAsList = new DataGridView();
            Update = new Button();
            panel1 = new Panel();
            ErrorMessage = new Label();
            label1 = new Label();
            Counter = new NumericUpDown();
            Error = new Label();
            label2 = new Label();
            ISBNChange = new Label();
            panel3 = new Panel();
            BookImage = new PictureBox();
            panel2 = new Panel();
            panel4 = new Panel();
            AuthortextBox = new TextBox();
            TitletxtBox = new TextBox();
            ISBN = new Label();
            Author = new Label();
            Title = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)ViewBooksAsList).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Counter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BookImage).BeginInit();
            SuspendLayout();
            // 
            // ViewBooksAsList
            // 
            ViewBooksAsList.AllowUserToAddRows = false;
            ViewBooksAsList.AllowUserToDeleteRows = false;
            ViewBooksAsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewBooksAsList.Cursor = Cursors.Hand;
            ViewBooksAsList.Location = new Point(88, 38);
            ViewBooksAsList.Name = "ViewBooksAsList";
            ViewBooksAsList.ReadOnly = true;
            ViewBooksAsList.Size = new Size(769, 357);
            ViewBooksAsList.TabIndex = 0;
            ViewBooksAsList.AllowUserToDeleteRowsChanged += ViewBooksAsList_AllowUserToDeleteRowsChanged;
            ViewBooksAsList.CellClick += ViewBooksAsList_CellClick;
            ViewBooksAsList.CellContentClick += dataGridView1_CellContentClick;
            ViewBooksAsList.SelectionChanged += ViewBooksAsList_SelectionChanged;
            // 
            // Update
            // 
            Update.BackColor = Color.AliceBlue;
            Update.Image = Properties.Resources.blue_gradient;
            Update.Location = new Point(787, 444);
            Update.Name = "Update";
            Update.Size = new Size(150, 43);
            Update.TabIndex = 1;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = false;
            Update.Click += Update_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 162, 162);
            panel1.Controls.Add(ErrorMessage);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Counter);
            panel1.Controls.Add(Error);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(ISBNChange);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(BookImage);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(AuthortextBox);
            panel1.Controls.Add(TitletxtBox);
            panel1.Controls.Add(ISBN);
            panel1.Controls.Add(Author);
            panel1.Controls.Add(Title);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(ViewBooksAsList);
            panel1.Controls.Add(Update);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1014, 604);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // ErrorMessage
            // 
            ErrorMessage.AutoSize = true;
            ErrorMessage.Location = new Point(38, 575);
            ErrorMessage.Name = "ErrorMessage";
            ErrorMessage.Size = new Size(0, 15);
            ErrorMessage.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(261, 555);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 29;
            label1.Text = "Count";
            // 
            // Counter
            // 
            Counter.Location = new Point(261, 573);
            Counter.Name = "Counter";
            Counter.Size = new Size(120, 23);
            Counter.TabIndex = 28;
            Counter.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // Error
            // 
            Error.AutoSize = true;
            Error.BackColor = Color.Wheat;
            Error.ForeColor = Color.FromArgb(192, 0, 0);
            Error.Location = new Point(338, 581);
            Error.Name = "Error";
            Error.Size = new Size(0, 15);
            Error.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(192, 0, 0);
            label2.Location = new Point(338, 581);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 26;
            // 
            // ISBNChange
            // 
            ISBNChange.AutoSize = true;
            ISBNChange.Location = new Point(261, 525);
            ISBNChange.Name = "ISBNChange";
            ISBNChange.Size = new Size(0, 15);
            ISBNChange.TabIndex = 25;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Location = new Point(261, 540);
            panel3.Name = "panel3";
            panel3.Size = new Size(443, 5);
            panel3.TabIndex = 23;
            // 
            // BookImage
            // 
            BookImage.Location = new Point(38, 416);
            BookImage.Name = "BookImage";
            BookImage.Size = new Size(172, 152);
            BookImage.SizeMode = PictureBoxSizeMode.Zoom;
            BookImage.TabIndex = 24;
            BookImage.TabStop = false;
            BookImage.Click += BookImage_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Location = new Point(261, 490);
            panel2.Name = "panel2";
            panel2.Size = new Size(443, 5);
            panel2.TabIndex = 22;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Location = new Point(261, 432);
            panel4.Name = "panel4";
            panel4.Size = new Size(443, 5);
            panel4.TabIndex = 21;
            // 
            // AuthortextBox
            // 
            AuthortextBox.BackColor = Color.FromArgb(128, 162, 162);
            AuthortextBox.BorderStyle = BorderStyle.None;
            AuthortextBox.Location = new Point(261, 472);
            AuthortextBox.Name = "AuthortextBox";
            AuthortextBox.Size = new Size(443, 16);
            AuthortextBox.TabIndex = 20;
            // 
            // TitletxtBox
            // 
            TitletxtBox.BackColor = Color.FromArgb(128, 162, 162);
            TitletxtBox.BorderStyle = BorderStyle.None;
            TitletxtBox.Location = new Point(261, 416);
            TitletxtBox.Name = "TitletxtBox";
            TitletxtBox.Size = new Size(443, 16);
            TitletxtBox.TabIndex = 19;
            // 
            // ISBN
            // 
            ISBN.AutoSize = true;
            ISBN.Location = new Point(261, 507);
            ISBN.Name = "ISBN";
            ISBN.Size = new Size(32, 15);
            ISBN.TabIndex = 17;
            ISBN.Text = "ISBN";
            ISBN.Click += ISBN_Click;
            // 
            // Author
            // 
            Author.AutoSize = true;
            Author.Location = new Point(261, 454);
            Author.Name = "Author";
            Author.Size = new Size(44, 15);
            Author.TabIndex = 16;
            Author.Text = "Author";
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(261, 398);
            Title.Name = "Title";
            Title.Size = new Size(30, 15);
            Title.TabIndex = 15;
            Title.Text = "Title";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Image = Properties.Resources.blue_gradient;
            button1.Location = new Point(787, 512);
            button1.Name = "button1";
            button1.Size = new Size(150, 43);
            button1.TabIndex = 2;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ViewBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLight;
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ViewBooks";
            Size = new Size(1016, 607);
            Load += ViewBooks_Load;
            ((System.ComponentModel.ISupportInitialize)ViewBooksAsList).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Counter).EndInit();
            ((System.ComponentModel.ISupportInitialize)BookImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ViewBooksAsList;
        private Button Update;
        private Panel panel1;
        private Button button1;
        private Label Error;
        private Label label2;
        private Label ISBNChange;
        private Panel panel3;
        private PictureBox BookImage;
        private Panel panel2;
        private Panel panel4;
        private TextBox AuthortextBox;
        private TextBox TitletxtBox;
        private Label ISBN;
        private Label Author;
        private Label Title;
        private NumericUpDown Counter;
        private Label label1;
        private Label ErrorMessage;
    }
}