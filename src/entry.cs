/*---------------------------------------------------------------------------------------------------------------------------------------
 * Name:          Entry
 * Author:        Tyler aka Link aka Zafar
 *
 * Description:
 * Entry point for the Interval Click Program
 * --------------------------------------------------------------------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interval_Click_Graphic
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new intervalClick());
        }
    }
}
