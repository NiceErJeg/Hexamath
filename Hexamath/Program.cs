using System;
using System.Windows.Forms;

namespace Hexamath
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LogInPage logInPage = new LogInPage();
            logInPage.buttonChooseUser.Click += EnterMainPage;
            Application.Run(logInPage);


        }

        static void EnterMainPage(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();

            Application.Run(mainPage)
        }
    }
}
