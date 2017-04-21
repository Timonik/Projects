using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NetrikaProject.Client;
using System.ServiceModel;
using System.Threading;
using NetrikaProject.Client.Proxy;



namespace NetrikaProject.Client
{
    public partial class MainClientWindow : Form
    {
        private ClientBase client;

        public delegate void ChandedCommStateHandler(ClientBase client);

        public MainClientWindow()
        {
            InitializeComponent();
        }

        private void MainClientWindow_Load(object sender, EventArgs e)
        {
            try
            {
                Thread thread = new Thread(new ThreadStart(RegisterClient));
                thread.IsBackground = true;
                thread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ошибка запуска приложения. Информация:\r\n{0}\r\nПриложение будет закрыто.", ex.Message), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void RegisterClient()
        {
            try
            {
                client = new ClientBase();
                client.Register();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client.AddPatient(new PatientDto()
            {
                BirthDate = new DateTime(1986, 03, 11),
                FamilyName = "Иванов",
                GivenName = "Иван",
                IdPatientMIS = "NewPacientTest2",
                Sex = 1
            });
        }
    }
}
