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
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebGet(UriTemplate="/json/{number}",ResponseFormat= WebMessageFormat.Json)]
        // TODO: Add your service operations here
         public Data GetJSON(string number)
        {
            var x = new Data(int.Parse(number));
            return new Data(int.Parse(number));
        }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    }

    public class Data
    {
        public int[] Multiples { get; set; }

        public Data(int num)
        {
            Multiples = new int[10];

            for (int i = 0; i < Multiples.Length; i++)
            {
                Multiples[i] = i;
            }
        }
    }
}
