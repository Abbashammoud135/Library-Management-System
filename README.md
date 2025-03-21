## Library Management System Using C# WFA 
• Implemented design patterns like Decorator, Singleton, and Factory for scalable and maintainable architecture, utilizing the MVC architectural pattern.
• Created an admin dashboard for managing students, books, and notifications via email or login, including overdue reminders.
• Enabled members to seamlessly borrow and return books through an intuitive interface.
• Secured user authentication by hashing passwords with a salt to prevent rainbow table attacks.

## Running the Application
Follow these steps to set up and run the application:

1) Execute the SQL Command
Run the provided SQL script(open the application and you will found it inside sql folder) in SQL Server Management Studio. This will create the necessary tables.

2) Database Initialization
The database will start empty, except for the admin credentials.

3) Admin Login Credentials
Use the following credentials to log in as an admin:

Email/UserName: admin@gmail.com
Password: admin

4) Update the Connection String
Modify the connectionString in the AcessDbController class to match your SQL Server instance.

5) Running the Application
Once the above steps are completed, you can run the application and log in as an admin.

6) Populating the Books Database
Instead of manually adding books, pre-saved book data is stored in JSON files. This data can be sent to the database via code.

7) Activating the Book Data Import

Uncomment lines 32 and 33 in Program.cs on the first run to populate the books database.
Important: After the first run, comment these lines again. Otherwise, the books will be re-added each time you start the application, even if you delete some of them.


Enjoy the Application
Once set up, you can explore all the features.

Note: 
Initially, no members exist in the system. First, log in as an admin, register a member, and then you can log in as a member.