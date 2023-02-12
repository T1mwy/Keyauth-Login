using System;
using System.Windows.Forms;

namespace Cookies_Loader_Base
{
    static class Program
    {
        [STAThread]
        static void Main()
        { 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
