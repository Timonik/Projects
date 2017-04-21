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

        public ClientBase()
        {
            proxy = new ServerClient();
            proxy.Open();
        }

        public void Register()
        {
            proxy.RegisterClient(Environment.MachineName);
        }
    }
}
