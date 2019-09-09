using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        //Method used for sorting the string. Using Linq library (Like java streams). 
        //The string is split into each element by comma, converted to a number and sorted based on its value.
        //The result is joined back together with commas and returned.
        public string sort(string s)
        {
            try
            {
                String sortedNumbers = String.Join(",", s
                    .Split(',')
                    .Select(number => int.Parse(number))
                    .OrderBy(number => number));
                return sortedNumbers;
            }catch (Exception ex)
            {
                return ex.ToString();
            }
        }

    }
}
