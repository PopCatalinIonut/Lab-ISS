using System;
using System.Diagnostics;
using System.Windows.Forms;
using controllers;
using persistance;
using service;

namespace ISS_Bugs
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            UsersRepository usersRepo = new UsersRepository();
            BugsRepository bugsRepo = new BugsRepository();
            AppService service = new AppService(usersRepo,bugsRepo);
            LoginController loginController = new LoginController(service);
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm(loginController));
        }
    }
}