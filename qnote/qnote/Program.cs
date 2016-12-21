using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qnote
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            User statusUser = Backend.checkStatus();
            if (statusUser != null)
            {
                Application.Run(new MainActivity(statusUser.username, statusUser.password));
            }
            else
            {
                Application.Run(new SignUp());
            }
        }
    }
}
