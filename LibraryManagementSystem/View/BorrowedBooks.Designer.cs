
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    partial class BorrowedBooks
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button1 = new Button();
            Error = new Label();
            OnLogin = new CheckBox();
            Email = new CheckBox();
            NotifyAll = new Button();
            label9 = new Label();
            Notify = new Button();
            returnBooks_bookTitle = new TextBox();
            label6 = new Label();
            returnBooks_email = new TextBox();
            label5 = new Label();
            returnBooks_contact = new TextBox();
            label4 = new Label();
            returnBooks_name = new TextBox();
            label3 = new Label();
            returnBooks_issueID = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(Error);
            panel1.Controls.Add(OnLogin);
            panel1.Controls.Add(Email);
            panel1.Controls.Add(NotifyAll);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(Notify);
            panel1.Controls.Add(returnBooks_bookTitle);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(returnBooks_email);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(returnBooks_contact);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(returnBooks_name);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(returnBooks_issueID);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(15, 21);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 563);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 162, 162);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.CheckedBackColor = Color.DarkSeaGreen;
            button1.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(191, 443);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(127, 50);
            button1.TabIndex = 26;
            button1.Text = "NOTIFY OVERDUE BOOKS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Error
            // 
            Error.AutoSize = true;
            Error.ForeColor = Color.Green;
            Error.Location = new Point(31, 407);
            Error.Name = "Error";
            Error.Size = new Size(0, 15);
            Error.TabIndex = 25;
            // 
            // OnLogin
            // 
            OnLogin.AutoSize = true;
            OnLogin.Location = new Point(36, 366);
            OnLogin.Name = "OnLogin";
            OnLogin.Size = new Size(72, 19);
            OnLogin.TabIndex = 24;
            OnLogin.Text = "OnLogin";
            OnLogin.UseVisualStyleBackColor = true;
            OnLogin.CheckedChanged += OnLogin_CheckedChanged;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(36, 341);
            Email.Name = "Email";
            Email.Size = new Size(55, 19);
            Email.TabIndex = 23;
            Email.Text = "Email";
            Email.UseVisualStyleBackColor = true;
            // 
            // NotifyAll
            // 
            NotifyAll.BackColor = Color.FromArgb(128, 162, 162);
            NotifyAll.FlatAppearance.BorderSize = 0;
            NotifyAll.FlatAppearance.CheckedBackColor = Color.DarkSeaGreen;
            NotifyAll.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            NotifyAll.FlatStyle = FlatStyle.Flat;
            NotifyAll.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NotifyAll.ForeColor = Color.White;
            NotifyAll.Location = new Point(107, 499);
            NotifyAll.Margin = new Padding(4, 3, 4, 3);
            NotifyAll.Name = "NotifyAll";
            NotifyAll.Size = new Size(110, 50);
            NotifyAll.TabIndex = 22;
            NotifyAll.Text = "NOTIFY ALL";
            NotifyAll.UseVisualStyleBackColor = false;
            NotifyAll.Click += NotifyAll_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(36, 314);
            label9.Name = "label9";
            label9.Size = new Size(143, 15);
            label9.TabIndex = 21;
            label9.Text = "Specify Notifying method";
            // 
            // Notify
            // 
            Notify.BackColor = Color.FromArgb(128, 162, 162);
            Notify.FlatAppearance.BorderSize = 0;
            Notify.FlatAppearance.CheckedBackColor = Color.DarkSeaGreen;
            Notify.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            Notify.FlatStyle = FlatStyle.Flat;
            Notify.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Notify.ForeColor = Color.White;
            Notify.Location = new Point(13, 443);
            Notify.Margin = new Padding(4, 3, 4, 3);
            Notify.Name = "Notify";
            Notify.Size = new Size(127, 50);
            Notify.TabIndex = 15;
            Notify.Text = "NOTIFY";
            Notify.UseVisualStyleBackColor = false;
            Notify.Click += Notify_Click;
            // 
            // returnBooks_bookTitle
            // 
            returnBooks_bookTitle.Enabled = false;
            returnBooks_bookTitle.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            returnBooks_bookTitle.Location = new Point(36, 261);
            returnBooks_bookTitle.Margin = new Padding(4, 3, 4, 3);
            returnBooks_bookTitle.Name = "returnBooks_bookTitle";
            returnBooks_bookTitle.Size = new Size(195, 22);
            returnBooks_bookTitle.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(36, 242);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(138, 16);
            label6.TabIndex = 9;
            label6.Text = "Should be Returned on";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // returnBooks_email
            // 
            returnBooks_email.Enabled = false;
            returnBooks_email.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            returnBooks_email.Location = new Point(36, 217);
            returnBooks_email.Margin = new Padding(4, 3, 4, 3);
            returnBooks_email.Name = "returnBooks_email";
            returnBooks_email.Size = new Size(195, 22);
            returnBooks_email.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(36, 198);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(77, 16);
            label5.TabIndex = 6;
            label5.Text = "Borrow time";
            // 
            // returnBooks_contact
            // 
            returnBooks_contact.Enabled = false;
            returnBooks_contact.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            returnBooks_contact.Location = new Point(36, 173);
            returnBooks_contact.Margin = new Padding(4, 3, 4, 3);
            returnBooks_contact.Name = "returnBooks_contact";
            returnBooks_contact.Size = new Size(195, 22);
            returnBooks_contact.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 154);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(49, 16);
            label4.TabIndex = 4;
            label4.Text = "Book Id";
            // 
            // returnBooks_name
            // 
            returnBooks_name.Enabled = false;
            returnBooks_name.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            returnBooks_name.Location = new Point(36, 129);
            returnBooks_name.Margin = new Padding(4, 3, 4, 3);
            returnBooks_name.Name = "returnBooks_name";
            returnBooks_name.Size = new Size(195, 22);
            returnBooks_name.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 106);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 16);
            label3.TabIndex = 2;
            label3.Text = "Member Id";
            // 
            // returnBooks_issueID
            // 
            returnBooks_issueID.Enabled = false;
            returnBooks_issueID.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            returnBooks_issueID.Location = new Point(36, 81);
            returnBooks_issueID.Margin = new Padding(4, 3, 4, 3);
            returnBooks_issueID.Name = "returnBooks_issueID";
            returnBooks_issueID.Size = new Size(195, 22);
            returnBooks_issueID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 62);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 16);
            label2.TabIndex = 0;
            label2.Text = "Borrow Id";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(364, 21);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(631, 563);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(14, 128, 87);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(22, 69);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(591, 454);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 21);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(169, 23);
            label1.TabIndex = 0;
            label1.Text = "All Borrowed Books";
            // 
            // BorrowedBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "BorrowedBooks";
            Size = new Size(1011, 605);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox returnBooks_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox returnBooks_issueID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox returnBooks_contact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox returnBooks_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox returnBooks_bookTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button returnBooks_clearBtn;
        private System.Windows.Forms.Button Notify;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Button NotifyAll;
        private Label label9;
        private CheckBox OnLogin;
        private CheckBox Email;
        private Label Error;
        private Button button1;
    }
}
