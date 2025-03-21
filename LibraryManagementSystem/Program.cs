using LibraryManagementSystem.Controller;
using LibraryManagementSystem.View;
using System;
using System.Runtime.InteropServices;

namespace LibraryManagementSystem
{
    internal static class Program
    {
        //[DllImport("kernel32.dll")]
        //private static extern bool AllocConsole();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //// Allocate a console window
            //AllocConsole();

            //// Write to the console
            //Console.WriteLine("Console initialized!");

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            //!!!!!!!!!!!
            //Uncomment this line to send the json file to the database in the first run

            /*
            SendJsonFileToDatabase sendJsonFileToDatabase = new SendJsonFileToDatabase();
            sendJsonFileToDatabase.SaveToDatabase();
            */
            ApplicationConfiguration.Initialize();
            Application.Run(new Home());
        }
    }
}
