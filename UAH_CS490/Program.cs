using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAH_CS490
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static GUI GUI;
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            GUI = new GUI();
            System.Windows.Forms.Application.Run(GUI);
        }
    }
}
