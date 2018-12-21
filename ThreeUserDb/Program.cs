using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreeUserDb.Forms;

namespace ThreeUserDb
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var loginForm = new LoginForm();
            //loginForm.ShowDialog();
            Application.Run(loginForm);

            if (loginForm.IsAuth)
            {
                Application.Run(new MainForm());
            }

        }
    }
}
