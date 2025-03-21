
namespace LibraryManagementSystem.View
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            LoginButton = new Button();
            UserNameLabel = new Label();
            PasswordLabel = new Label();
            UserNameText = new TextBox();
            PasswordText = new TextBox();
            ErrorLabel = new Label();
            MemberOrAdmin = new ComboBox();
            LoginAsLabel = new Label();
            WelcomeUser = new Label();
            Logo = new PictureBox();
            Exit = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Exit).BeginInit();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.BackgroundImageLayout = ImageLayout.Stretch;
            LoginButton.Image = Properties.Resources.blue_gradient;
            LoginButton.Location = new Point(323, 436);
            LoginButton.Margin = new Padding(0);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(400, 52);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Location = new Point(191, 254);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(65, 15);
            UserNameLabel.TabIndex = 1;
            UserNameLabel.Text = "UserName:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(191, 307);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(60, 15);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Password:";
            // 
            // UserNameText
            // 
            UserNameText.Location = new Point(191, 271);
            UserNameText.Margin = new Padding(3, 2, 3, 2);
            UserNameText.Multiline = true;
            UserNameText.Name = "UserNameText";
            UserNameText.Size = new Size(665, 26);
            UserNameText.TabIndex = 3;
            UserNameText.TextChanged += UserNameText_TextChanged;
            // 
            // PasswordText
            // 
            PasswordText.Location = new Point(191, 324);
            PasswordText.Margin = new Padding(3, 2, 3, 2);
            PasswordText.Multiline = true;
            PasswordText.Name = "PasswordText";
            PasswordText.PasswordChar = '*';
            PasswordText.Size = new Size(665, 26);
            PasswordText.TabIndex = 4;
            PasswordText.TextChanged += PasswordText_TextChanged;
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.ForeColor = Color.Red;
            ErrorLabel.Location = new Point(204, 411);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(0, 15);
            ErrorLabel.TabIndex = 10;
            ErrorLabel.Click += ErrorLabel_Click_1;
            // 
            // MemberOrAdmin
            // 
            MemberOrAdmin.FormattingEnabled = true;
            MemberOrAdmin.Items.AddRange(new object[] { "Member", "Admin" });
            MemberOrAdmin.Location = new Point(191, 376);
            MemberOrAdmin.Margin = new Padding(3, 2, 3, 2);
            MemberOrAdmin.Name = "MemberOrAdmin";
            MemberOrAdmin.Size = new Size(665, 23);
            MemberOrAdmin.TabIndex = 8;
            MemberOrAdmin.Text = "Member";
            MemberOrAdmin.SelectedIndexChanged += MemberOrAdmin_SelectedIndexChanged;
            // 
            // LoginAsLabel
            // 
            LoginAsLabel.AutoSize = true;
            LoginAsLabel.Location = new Point(191, 359);
            LoginAsLabel.Name = "LoginAsLabel";
            LoginAsLabel.Size = new Size(54, 15);
            LoginAsLabel.TabIndex = 9;
            LoginAsLabel.Text = "Login as:";
            // 
            // WelcomeUser
            // 
            WelcomeUser.AutoSize = true;
            WelcomeUser.Font = new Font("Bookman Old Style", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WelcomeUser.Location = new Point(380, 199);
            WelcomeUser.Name = "WelcomeUser";
            WelcomeUser.Size = new Size(285, 42);
            WelcomeUser.TabIndex = 10;
            WelcomeUser.Text = "Welcome, User!";
            // 
            // Logo
            // 
            Logo.Image = Properties.Resources.NHA_new_logo;
            Logo.Location = new Point(191, 12);
            Logo.Name = "Logo";
            Logo.Size = new Size(665, 187);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 11;
            Logo.TabStop = false;
            // 
            // Exit
            // 
            Exit.Image = (Image)resources.GetObject("Exit.Image");
            Exit.Location = new Point(1004, 9);
            Exit.Name = "Exit";
            Exit.Size = new Size(35, 35);
            Exit.SizeMode = PictureBoxSizeMode.Zoom;
            Exit.TabIndex = 12;
            Exit.TabStop = false;
            Exit.Click += Exit_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(154, 188, 188);
            ClientSize = new Size(1048, 556);
            Controls.Add(Exit);
            Controls.Add(Logo);
            Controls.Add(WelcomeUser);
            Controls.Add(LoginAsLabel);
            Controls.Add(MemberOrAdmin);
            Controls.Add(ErrorLabel);
            Controls.Add(PasswordText);
            Controls.Add(UserNameText);
            Controls.Add(PasswordLabel);
            Controls.Add(UserNameLabel);
            Controls.Add(LoginButton);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load_1;
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)Exit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button LoginButton;
        private Label UserNameLabel;
        private Label PasswordLabel;
        private TextBox UserNameText;
        private TextBox PasswordText;
        private Label ErrorLabel;
        private ComboBox MemberOrAdmin;
        private Label LoginAsLabel;
        private Label WelcomeUser;
        private PictureBox Logo;
        private PictureBox Exit;
    }
}