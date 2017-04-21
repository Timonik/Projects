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

        private void _sendButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(_familyNameTextBox.Text) || String.IsNullOrEmpty(_givenNameTextBox.Text) || String.IsNullOrEmpty(_idPatientMISTextBox.Text) || _sexComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Заполнены не все обязательные поля!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            client.AddPatient(new PatientDto()
            {
                BirthDate = _birthDayDateTimePicker.Value,
                FamilyName = _familyNameTextBox.Text,
                GivenName = _givenNameTextBox.Text,
                IdPatientMIS = _idPatientMISTextBox.Text,
                Sex = (byte)_sexComboBox.SelectedIndex
            });

            switch(client.Detail.ErrorCode)
            {
                case 23:
                    MessageBox.Show("Пациент с такими данными уже существует");
                    break;
                case 99:
                    MessageBox.Show("Пациент успешно добавлен");
                    break;
            }
        }

        private void _exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
