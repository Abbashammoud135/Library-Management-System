namespace LibraryManagementSystem.View
{
    partial class EditBooks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label5 = new Label();
            Counter = new NumericUpDown();
            label3 = new Label();
            Error = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            panel3 = new Panel();
            BookImage = new PictureBox();
            panel2 = new Panel();
            panel1 = new Panel();
            AuthortextBox = new TextBox();
            TitletxtBox = new TextBox();
            label4 = new Label();
            ISBN = new Label();
            Author = new Label();
            Title = new Label();
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Counter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BookImage).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(154, 188, 188);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(Counter);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(Error);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(BookImage);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(AuthortextBox);
            groupBox1.Controls.Add(TitletxtBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(ISBN);
            groupBox1.Controls.Add(Author);
            groupBox1.Controls.Add(Title);
            groupBox1.Location = new Point(89, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(572, 474);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Edit Book";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(154, 188, 188);
            label5.Location = new Point(63, 382);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 18;
            // 
            // Counter
            // 
            Counter.Location = new Point(57, 357);
            Counter.Name = "Counter";
            Counter.Size = new Size(120, 23);
            Counter.TabIndex = 17;
            Counter.ValueChanged += Counter_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 339);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 16;
            label3.Text = "Count";
            label3.Click += label3_Click;
            // 
            // Error
            // 
            Error.AutoSize = true;
            Error.BackColor = Color.FromArgb(154, 188, 188);
            Error.ForeColor = Color.FromArgb(192, 0, 0);
            Error.Location = new Point(63, 382);
            Error.Name = "Error";
            Error.Size = new Size(0, 15);
            Error.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(192, 0, 0);
            label2.Location = new Point(65, 366);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 313);
            label1.Name = "label1";
            label1.Size = new Size(10, 15);
            label1.TabIndex = 12;
            label1.Text = " ";
            label1.Click += label1_Click_1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = Properties.Resources.blue_gradient;
            button1.Location = new Point(57, 398);
            button1.Name = "button1";
            button1.Size = new Size(443, 54);
            button1.TabIndex = 11;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Location = new Point(57, 331);
            panel3.Name = "panel3";
            panel3.Size = new Size(443, 5);
            panel3.TabIndex = 9;
            // 
            // BookImage
            // 
            BookImage.Location = new Point(165, 37);
            BookImage.Name = "BookImage";
            BookImage.Size = new Size(172, 152);
            BookImage.SizeMode = PictureBoxSizeMode.Zoom;
            BookImage.TabIndex = 9;
            BookImage.TabStop = false;
            BookImage.Click += pictureBox2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Location = new Point(57, 281);
            panel2.Name = "panel2";
            panel2.Size = new Size(443, 5);
            panel2.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(57, 223);
            panel1.Name = "panel1";
            panel1.Size = new Size(443, 5);
            panel1.TabIndex = 7;
            // 
            // AuthortextBox
            // 
            AuthortextBox.BackColor = Color.FromArgb(154, 188, 188);
            AuthortextBox.BorderStyle = BorderStyle.None;
            AuthortextBox.Location = new Point(57, 263);
            AuthortextBox.Name = "AuthortextBox";
            AuthortextBox.Size = new Size(443, 16);
            AuthortextBox.TabIndex = 5;
            // 
            // TitletxtBox
            // 
            TitletxtBox.BackColor = Color.FromArgb(154, 188, 188);
            TitletxtBox.BorderStyle = BorderStyle.None;
            TitletxtBox.Location = new Point(57, 207);
            TitletxtBox.Name = "TitletxtBox";
            TitletxtBox.Size = new Size(443, 16);
            TitletxtBox.TabIndex = 4;
            TitletxtBox.TextChanged += TitletxtBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(217, 19);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 3;
            label4.Text = "BookImage";
            label4.Click += label4_Click;
            // 
            // ISBN
            // 
            ISBN.AutoSize = true;
            ISBN.Location = new Point(59, 295);
            ISBN.Name = "ISBN";
            ISBN.Size = new Size(32, 15);
            ISBN.TabIndex = 2;
            ISBN.Text = "ISBN";
            ISBN.Click += ISBN_Click;
            // 
            // Author
            // 
            Author.AutoSize = true;
            Author.Location = new Point(57, 245);
            Author.Name = "Author";
            Author.Size = new Size(44, 15);
            Author.TabIndex = 1;
            Author.Text = "Author";
            Author.Click += label2_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(57, 189);
            Title.Name = "Title";
            Title.Size = new Size(30, 15);
            Title.TabIndex = 0;
            Title.Text = "Title";
            Title.Click += label1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // EditBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(154, 188, 188);
            Controls.Add(groupBox1);
            Name = "EditBooks";
            Size = new Size(761, 506);
            Load += EditBooks_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Counter).EndInit();
            ((System.ComponentModel.ISupportInitialize)BookImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label ISBN;
        private Label Author;
        private Label Title;
        private Panel panel1;
        private TextBox AuthortextBox;
        private TextBox TitletxtBox;
        private Panel panel2;
        private Button button1;
        private Panel panel3;
        private PictureBox BookImage;
        private OpenFileDialog openFileDialog1;
        private Label label1;
        private Label label2;
        private Label Error;
        private Label label3;
        private NumericUpDown Counter;
        private Label label5;
    }
}
