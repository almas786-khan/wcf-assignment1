using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Assignment1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int CheckPrime(int n1);
        [OperationContract]
        int Sum(int n1);
        [OperationContract]
        string ReverseString(string s1);
        [OperationContract]
        string HTMLTag(string tag, string s1);
        [OperationContract]
        int[] SortNum(int[] s1, string sortOrder);
    }
}
