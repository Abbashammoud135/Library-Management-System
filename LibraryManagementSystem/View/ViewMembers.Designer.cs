namespace LibraryManagementSystem.View
{
    partial class ViewMember
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
            ErrorMessage = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            EmailtxtBox = new TextBox();
            NametxtBox = new TextBox();
            ISBN = new Label();
            Author = new Label();
            label = new Label();
            button1 = new Button();
            ViewMembersAsList = new DataGridView();
            Update = new Button();
            panel1 = new Panel();
            PasswordtxtBox = new TextBox();
            Error = new Label();
            ((System.ComponentModel.ISupportInitialize)ViewMembersAsList).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ErrorMessage
            // 
            ErrorMessage.AutoSize = true;
            ErrorMessage.Location = new Point(191, 559);
            ErrorMessage.Name = "ErrorMessage";
            ErrorMessage.Size = new Size(0, 15);
            ErrorMessage.TabIndex = 48;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Location = new Point(187, 550);
            panel3.Name = "panel3";
            panel3.Size = new Size(443, 5);
            panel3.TabIndex = 41;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Location = new Point(187, 500);
            panel2.Name = "panel2";
            panel2.Size = new Size(443, 5);
            panel2.TabIndex = 40;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Location = new Point(187, 442);
            panel4.Name = "panel4";
            panel4.Size = new Size(443, 5);
            panel4.TabIndex = 39;
            // 
            // EmailtxtBox
            // 
            EmailtxtBox.BackColor = Color.FromArgb(128, 162, 162);
            EmailtxtBox.BorderStyle = BorderStyle.None;
            EmailtxtBox.Location = new Point(187, 482);
            EmailtxtBox.Name = "EmailtxtBox";
            EmailtxtBox.ReadOnly = true;
            EmailtxtBox.Size = new Size(443, 16);
            EmailtxtBox.TabIndex = 38;
            // 
            // NametxtBox
            // 
            NametxtBox.BackColor = Color.FromArgb(128, 162, 162);
            NametxtBox.BorderStyle = BorderStyle.None;
            NametxtBox.Location = new Point(187, 426);
            NametxtBox.Name = "NametxtBox";
            NametxtBox.Size = new Size(443, 16);
            NametxtBox.TabIndex = 37;
            // 
            // ISBN
            // 
            ISBN.AutoSize = true;
            ISBN.BackColor = Color.FromArgb(128, 162, 162);
            ISBN.Location = new Point(187, 517);
            ISBN.Name = "ISBN";
            ISBN.Size = new Size(57, 15);
            ISBN.TabIndex = 36;
            ISBN.Text = "Password";
            // 
            // Author
            // 
            Author.AutoSize = true;
            Author.BackColor = Color.FromArgb(128, 162, 162);
            Author.Location = new Point(187, 464);
            Author.Name = "Author";
            Author.Size = new Size(36, 15);
            Author.TabIndex = 35;
            Author.Text = "Email";
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.FromArgb(128, 162, 162);
            label.Location = new Point(187, 408);
            label.Name = "label";
            label.Size = new Size(39, 15);
            label.TabIndex = 34;
            label.Text = "Name";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Image = Properties.Resources.blue_gradient;
            button1.Location = new Point(797, 510);
            button1.Name = "button1";
            button1.Size = new Size(150, 43);
            button1.TabIndex = 33;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ViewMembersAsList
            // 
            ViewMembersAsList.AllowUserToAddRows = false;
            ViewMembersAsList.AllowUserToDeleteRows = false;
            ViewMembersAsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewMembersAsList.Cursor = Cursors.Hand;
            ViewMembersAsList.Location = new Point(187, 20);
            ViewMembersAsList.Name = "ViewMembersAsList";
            ViewMembersAsList.ReadOnly = true;
            ViewMembersAsList.RowHeadersWidth = 51;
            ViewMembersAsList.Size = new Size(760, 357);
            ViewMembersAsList.TabIndex = 31;
            ViewMembersAsList.CellClick += ViewMembersAsList_CellClick;
            ViewMembersAsList.CellContentClick += ViewMembersAsList_CellContentClick_1;
            ViewMembersAsList.SelectionChanged += ViewMembersAsList_SelectionChanged;
            // 
            // Update
            // 
            Update.BackColor = SystemColors.ActiveCaption;
            Update.Image = Properties.Resources.blue_gradient;
            Update.Location = new Point(797, 442);
            Update.Name = "Update";
            Update.Size = new Size(150, 43);
            Update.TabIndex = 32;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = false;
            Update.Click += Update_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 162, 162);
            panel1.Controls.Add(PasswordtxtBox);
            panel1.Controls.Add(Error);
            panel1.Controls.Add(ErrorMessage);
            panel1.Controls.Add(ViewMembersAsList);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(Update);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label);
            panel1.Controls.Add(Author);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(ISBN);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(NametxtBox);
            panel1.Controls.Add(EmailtxtBox);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1143, 605);
            panel1.TabIndex = 49;
            panel1.Paint += panel1_Paint;
            // 
            // PasswordtxtBox
            // 
            PasswordtxtBox.BackColor = Color.FromArgb(128, 162, 162);
            PasswordtxtBox.BorderStyle = BorderStyle.None;
            PasswordtxtBox.Location = new Point(189, 533);
            PasswordtxtBox.Name = "PasswordtxtBox";
            PasswordtxtBox.Size = new Size(439, 16);
            PasswordtxtBox.TabIndex = 50;
            PasswordtxtBox.TextChanged += PasswordtxtBox_TextChanged;
            // 
            // Error
            // 
            Error.AutoSize = true;
            Error.Enabled = false;
            Error.ForeColor = Color.FromArgb(192, 0, 0);
            Error.Location = new Point(187, 559);
            Error.Name = "Error";
            Error.Size = new Size(0, 15);
            Error.TabIndex = 49;
            Error.Click += Error_Click;
            // 
            // ViewMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ViewMember";
            Size = new Size(1143, 605);
            Load += ViewMembers_Load;
            ((System.ComponentModel.ISupportInitialize)ViewMembersAsList).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label ErrorMessage;
        private Label ISBNChange;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private TextBox EmailtxtBox;
        private TextBox NametxtBox;
        private Label ISBN;
        private Label Author;
        private Label label;
        private Button button1;
        private DataGridView ViewMembersAsList;
        private Button Update;
        private Panel panel1;
        private Label Error;
        private TextBox PasswordtxtBox;
    }
}
