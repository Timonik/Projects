using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using NetrikaProject.Client;
using NetrikaProject.Client.Proxy;

namespace NetrikaProject.Client
{
    public class ClientBase
    {
        private ServerClient proxy;
        private RequestFault _detail;

        public RequestFault Detail
        {
            get { return _detail; }
            set { _detail = value; }
        }
        public ClientBase()
        {
            proxy = new ServerClient();
            proxy.Open();
        }

        public void Register()
        {
            proxy.RegisterClient(Environment.MachineName);
        }

        public void AddPatient(PatientDto PatientDto)
        {
            _detail = proxy.AddPatient("8CDE415D-FAB7-4809-AA37-8CDD70B1B46C", "1.2.643.5.1.13.3.25.78.118", PatientDto);
        }
    }
}
