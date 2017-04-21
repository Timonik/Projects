using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using NetrikaProject.Contracts;
using System.ServiceModel;
using System.Threading;

namespace NetrikaProject.Server
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple, UseSynchronizationContext = false)]
    public class ServerBase: IServer
    {
        private Dictionary<string, IClient> clients;

        public Dictionary<string, IClient> Clients
        {
            get
            {
                return clients;
            }
        }

        public delegate void ChangedPropertyHandler();
        public event ChangedPropertyHandler ClientsChangedEvent;

        public ServerBase()
        {
            clients = new Dictionary<string, IClient>();
        }

        public void AddPatient(string _guid, string _idLpu, Netrika.PatientDto _patientDto)
        {
            Netrika.PixServiceClient psc = new Netrika.PixServiceClient("BasicHttpBinding_IPixService");

            try
            {
                psc.AddPatient(_guid, _idLpu, _patientDto);
            }
            catch (FaultException<Netrika.RequestFault> edc)
            {

            }
        }

        public void RegisterClient(string name)
        { 
            try
            {
                IClient c = OperationContext.Current.GetCallbackChannel<IClient>();
                lock (clients)
                {
                    clients.Add(name, c);
                    ((ICommunicationObject)c).Closed += (sender, e) =>
                    {
                        try
                        {
                            lock (clients)
                            {
                                string client = clients.Where(cur => cur.Value == sender).Select(cur => cur.Key).SingleOrDefault();
                                if (client == null) return;

                                clients.Remove(client);                                
                            }
                            if (ClientsChangedEvent != null)
                                ClientsChangedEvent.Invoke();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                    };
                    ((ICommunicationObject)c).Faulted += (sender, e) =>
                    {
                        try
                        {
                            lock (clients)
                            {
                                string client = clients.Where(cur => cur.Value == sender).Select(cur => cur.Key).SingleOrDefault();
                                if (client == null) return;

                                clients.Remove(client);
                            }
                            if (ClientsChangedEvent != null)
                                ClientsChangedEvent.Invoke();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                    };
                }
                if (ClientsChangedEvent != null)
                    ClientsChangedEvent.Invoke();                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
