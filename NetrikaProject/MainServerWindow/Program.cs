using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace NetrikaProject.Server
{
    static class Program
    {
        private static Mutex m_instance;
        private const string m_appName = "ServerProject";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool createNewApp;
            m_instance = new Mutex(true, m_appName, out createNewApp);

            if (createNewApp)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainServerWindow());
                return;
            }
            else
            {
                MessageBox.Show("Сервер уже запущен. Повторно запускаться не будет.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
