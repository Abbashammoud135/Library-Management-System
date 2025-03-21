namespace LibraryManagementSystem.View
{
    partial class AddNewMember
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
            Error = new Label();
            AddMember = new Button();
            Passwordtxt = new TextBox();
            Emailtxt = new TextBox();
            Nametxt = new TextBox();
            label3 = new Label();
            label2 = new Label();
            Name = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Error);
            groupBox1.Controls.Add(AddMember);
            groupBox1.Controls.Add(Passwordtxt);
            groupBox1.Controls.Add(Emailtxt);
            groupBox1.Controls.Add(Nametxt);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(Name);
            groupBox1.Location = new Point(102, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(506, 321);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Member";
            // 
            // Error
            // 
            Error.AutoSize = true;
            Error.Location = new Point(32, 180);
            Error.Name = "Error";
            Error.Size = new Size(0, 15);
            Error.TabIndex = 7;
            // 
            // AddMember
            // 
            AddMember.BackColor = SystemColors.ActiveCaptionText;
            AddMember.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddMember.ForeColor = SystemColors.ButtonHighlight;
            AddMember.Image = Properties.Resources.blue_gradient;
            AddMember.Location = new Point(32, 213);
            AddMember.Name = "AddMember";
            AddMember.Size = new Size(429, 52);
            AddMember.TabIndex = 6;
            AddMember.Text = "Add Member";
            AddMember.UseVisualStyleBackColor = false;
            AddMember.Click += AddMember_Click;
            // 
            // Passwordtxt
            // 
            Passwordtxt.Location = new Point(32, 154);
            Passwordtxt.Name = "Passwordtxt";
            Passwordtxt.Size = new Size(429, 23);
            Passwordtxt.TabIndex = 5;
            // 
            // Emailtxt
            // 
            Emailtxt.Location = new Point(32, 110);
            Emailtxt.Name = "Emailtxt";
            Emailtxt.Size = new Size(429, 23);
            Emailtxt.TabIndex = 4;
            Emailtxt.TextChanged += Emailtxt_TextChanged;
            // 
            // Nametxt
            // 
            Nametxt.Location = new Point(32, 62);
            Nametxt.Name = "Nametxt";
            Nametxt.Size = new Size(429, 23);
            Nametxt.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 136);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 92);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Location = new Point(28, 44);
            Name.Name = "Name";
            Name.Size = new Size(39, 15);
            Name.TabIndex = 0;
            Name.Text = "Name";
            // 
            // AddNewMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            //Name = "AddNewMember";
            Size = new Size(761, 506);
            Load += AddNewMember_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label Error;
        private Button AddMember;
        private TextBox Passwordtxt;
        private TextBox Emailtxt;
        private TextBox Nametxt;
        private Label label3;
        private Label label2;
        private Label Name;
    }
}
