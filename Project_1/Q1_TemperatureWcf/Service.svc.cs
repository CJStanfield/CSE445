using System;
using System.Net;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Project_1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service : IService
    {
        public string getRandom(int len)
        {
            string baseURL = "http://neptune.fulton.ad.asu.edu/WSRepository/Services/RandomString/Service.svc/GetRandomString/";
            string fullURL = baseURL + Convert.ToSingle(len);
            Uri ServivrUri = new Uri(fullURL);
            WebClient proxy = new WebClient();
            byte[] abc = proxy.DownloadData(ServivrUri);
            string str = System.Text.UTF8Encoding.UTF8.GetString(abc);
            XElement xmlRoot = XElement.Parse(str);
            string txtContent = ((XElement)(xmlRoot)).Value;
            return txtContent;
        }
    }
}
