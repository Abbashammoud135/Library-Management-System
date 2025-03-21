namespace LibraryManagementSystem.View
{
    partial class AddNewBook
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
        private void InitializeComponent()
        {
            TitleBox = new TextBox();
            AuthorBox = new TextBox();
            ISBNBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            AddBookButton = new Button();
            groupBox1 = new GroupBox();
            Error = new Label();
            BookImage = new PictureBox();
            BookImageUploaderbtn = new Button();
            label4 = new Label();
            openFileDialog = new OpenFileDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BookImage).BeginInit();
            SuspendLayout();
            // 
            // TitleBox
            // 
            TitleBox.Location = new Point(97, 33);
            TitleBox.Margin = new Padding(3, 2, 3, 2);
            TitleBox.Name = "TitleBox";
            TitleBox.Size = new Size(382, 25);
            TitleBox.TabIndex = 0;
            // 
            // AuthorBox
            // 
            AuthorBox.Location = new Point(97, 58);
            AuthorBox.Margin = new Padding(3, 2, 3, 2);
            AuthorBox.Name = "AuthorBox";
            AuthorBox.Size = new Size(382, 25);
            AuthorBox.TabIndex = 1;
            AuthorBox.TextChanged += textBox2_TextChanged;
            // 
            // ISBNBox
            // 
            ISBNBox.Location = new Point(97, 83);
            ISBNBox.Margin = new Padding(3, 2, 3, 2);
            ISBNBox.Name = "ISBNBox";
            ISBNBox.Size = new Size(382, 25);
            ISBNBox.TabIndex = 2;
            ISBNBox.TextChanged += ISBNBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 34);
            label1.Name = "label1";
            label1.Size = new Size(39, 19);
            label1.TabIndex = 3;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 61);
            label2.Name = "label2";
            label2.Size = new Size(59, 19);
            label2.TabIndex = 4;
            label2.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 86);
            label3.Name = "label3";
            label3.Size = new Size(45, 19);
            label3.TabIndex = 5;
            label3.Text = "ISBN";
            // 
            // AddBookButton
            // 
            AddBookButton.BackColor = SystemColors.ActiveCaption;
            AddBookButton.Image = Properties.Resources.blue_gradient;
            AddBookButton.Location = new Point(124, 281);
            AddBookButton.Margin = new Padding(3, 2, 3, 2);
            AddBookButton.Name = "AddBookButton";
            AddBookButton.Size = new Size(287, 34);
            AddBookButton.TabIndex = 6;
            AddBookButton.Text = "Add Book";
            AddBookButton.UseVisualStyleBackColor = false;
            AddBookButton.Click += AddBookButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Error);
            groupBox1.Controls.Add(BookImage);
            groupBox1.Controls.Add(BookImageUploaderbtn);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(ISBNBox);
            groupBox1.Controls.Add(AddBookButton);
            groupBox1.Controls.Add(TitleBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(AuthorBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("MS Reference Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(111, 70);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(508, 351);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Books";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Error
            // 
            Error.AutoSize = true;
            Error.Location = new Point(32, 318);
            Error.Name = "Error";
            Error.Size = new Size(46, 19);
            Error.TabIndex = 10;
            Error.Text = "Error";
            // 
            // BookImage
            // 
            BookImage.Location = new Point(190, 140);
            BookImage.Margin = new Padding(3, 2, 3, 2);
            BookImage.Name = "BookImage";
            BookImage.Size = new Size(162, 91);
            BookImage.SizeMode = PictureBoxSizeMode.Zoom;
            BookImage.TabIndex = 9;
            BookImage.TabStop = false;
            BookImage.Click += BookImage_Click;
            // 
            // BookImageUploaderbtn
            // 
            BookImageUploaderbtn.BackColor = SystemColors.InactiveCaption;
            BookImageUploaderbtn.Image = Properties.Resources.grey_gradient;
            BookImageUploaderbtn.Location = new Point(190, 236);
            BookImageUploaderbtn.Margin = new Padding(3, 2, 3, 2);
            BookImageUploaderbtn.Name = "BookImageUploaderbtn";
            BookImageUploaderbtn.Size = new Size(162, 31);
            BookImageUploaderbtn.TabIndex = 8;
            BookImageUploaderbtn.Text = "Upload";
            BookImageUploaderbtn.UseVisualStyleBackColor = false;
            BookImageUploaderbtn.Click += ImageUploader_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(163, 121);
            label4.Name = "label4";
            label4.Size = new Size(204, 19);
            label4.TabIndex = 7;
            label4.Text = "Upload Image of the book";
            label4.Click += label4_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            openFileDialog.FileOk += openFileDialog1_FileOk;
            // 
            // AddNewBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "AddNewBook";
            Size = new Size(761, 506);
            Load += AddNewBook_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BookImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox TitleBox;
        private TextBox AuthorBox;
        private TextBox ISBNBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button AddBookButton;
        private GroupBox groupBox1;
        private Label label4;
        private Button BookImageUploaderbtn;
        private PictureBox BookImage;
        private OpenFileDialog openFileDialog;
        private Label Error;
    }
}