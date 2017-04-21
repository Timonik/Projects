using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Data;

namespace NetrikaProject.Contracts
{
    [ServiceContract(Namespace="http://NetrikaProject", CallbackContract=typeof(Contracts.IClient), SessionMode = SessionMode.Required)]
    public interface IServer
    {
        [OperationContract]
        [WebInvoke(Method = "POST")]
        void RegisterClient(string ClientLocalName);
    }
}
