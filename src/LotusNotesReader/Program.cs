using System;
using System.Windows.Forms;

namespace LotusNotesReader
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //if (DateTime.Now.Ticks > 636983136000000000) return; // 2019-07-10

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
