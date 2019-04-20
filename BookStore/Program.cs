using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    static class Program
    {
        private static bool value = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());

            if(value)
            {
                Application.Run(new MainForm());
            }

        }
        public static void call_Main(bool value)
        {
            Program.value = value;
        }
    }
}
