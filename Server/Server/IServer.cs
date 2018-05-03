using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Drawing;
using System.Collections;

namespace Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServer
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here

        
        [OperationContract]
        bool LoginDesigner(string name, string pass);
        [OperationContract]
        bool LoginAdmin(string name, string pass);
        [OperationContract]
        void AddDesignInDL(Image img);

        [OperationContract]
        void AddShoe(string m, string s, string b, string l);

        [OperationContract]
        List<Order> GetOrdersList();
      /*  [OperationContract]
        void SetStatus(string m, string s, string b, string l); */
        [OperationContract]
        string ShowShoeStatus(string m, string s, string b, string l);
        [OperationContract]
        Order CreateaOrder();


    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }

    }

}
