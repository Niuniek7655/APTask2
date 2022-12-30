using APTask2.DAL;
using System;
using System.Windows.Forms;

namespace APTask2
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

            var context = new APTaskDbContext();
            context.Database.Initialize(true);

            Application.Run(new Main(context));
        }
    }
}
