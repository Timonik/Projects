using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using System.Threading;

namespace NetrikaProject.Server
{
    public partial class MainServerWindow : Form
    {
        private ServiceHost host;
        private ServerBase server;

        public MainServerWindow()
        {
            InitializeComponent();
        }

        private void MainServerWindow_Load(object sender, EventArgs e)
        {
            try
            {
                Thread thread = new Thread(new ThreadStart(CreateServerOnNewThread));
                thread.IsBackground = true;
                thread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ошибка запуска сервера. Приложение будет закрыто. Информация: {0}", ex.Message), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void CreateServerOnNewThread()
        {
            try
            {
                server = new ServerBase();
                server.ClientsChangedEvent += ChangeInfoClients;

                host = new ServiceHost(server);
                
                if (host.State == CommunicationState.Opened)
                    this.Close();
                host.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ошибка функции void CreateServerOnNewThread(). Информация: {0}", ex.Message));
            }
        }

        private void MainServerWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (host.State == CommunicationState.Opened)
                host.Close();
        }

        private void ChangeInfoClients()
        {
            string text = String.Empty;
            foreach (string str in server.Clients.Keys)
            {
                text += str + "\r\n";
            }
            int count = server.Clients.Count;
            text += string.Format("Всего: {0}", count);
            SetTxt(text, _clientsTextBox);
        }

        private delegate void SetTextCallback(string txt, TextBox textBox);
        private void SetTxt(string text, TextBox textBox)
        {
            if (this.InvokeRequired)
            {
                SetTextCallback callBack = new SetTextCallback(SetTxt);
                this.Invoke(callBack, new object[] { text, textBox });
            }
            else
            {
                textBox.Text = text;
            }
        }
    }
}
