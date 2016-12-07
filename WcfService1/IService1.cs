using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(CallbackContract =typeof(Icall))]
    public interface IService1
    {

        [OperationContract(IsOneWay =true)]
        void GetData(int value);

    

        // TODO: Add your service operations here
    }
    [ServiceContract]
    public interface Icall
    {
        [OperationContract(IsOneWay = true)]
        void done(int x);
        
    }

   
}
