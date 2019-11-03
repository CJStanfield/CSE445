using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Top10WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string[] Top10Words(string url);

        [OperationContract]
        string[] WeatherService(string zipcode);

        [OperationContract]
        string[] getCar(string year, string make, string model, string zipCode);

        [OperationContract]
        string ScheduleAppointment(string date, string time);

        [OperationContract]
        string OilServiceRecommendation(string oilType, int currentMileage, int lastOilChangeMileage);

        // TODO: Add your service operations here
    }



}
