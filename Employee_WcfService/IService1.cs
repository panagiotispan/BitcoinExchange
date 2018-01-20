using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Employee_WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void insertr_Employee(Employee obj);

       
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Employee
    {
        int eno;
        string ename;
        double salary;

        [DataMember]
        public int Wcf_eno
        {
            get { return eno; }
            set { eno = value; }
        }

        [DataMember]
        public string wcf_ename
        {
            get { return ename; }
            set { ename = value; }
        }
        [DataMember]
        public double wcf_salary
        {
            get { return salary; }
            set { ename = value.ToString(); }
        }
    }
}
