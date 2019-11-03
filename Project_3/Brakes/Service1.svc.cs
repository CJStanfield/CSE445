using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Brakes
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string BrakeService(int currentMileage, int LastBrakeChangeMileage)
        {
            //Get the mileage difference. Will be used to examine the interval
            int mileageDifference = currentMileage - LastBrakeChangeMileage;
            string serviceRecommendation = "";

            //basic error checking. Make sure values are not less than 0 and that the lastMileage is not larger than the current  mileage
            if (currentMileage < LastBrakeChangeMileage || currentMileage < 0 || LastBrakeChangeMileage < 0)
            {
                return "Mileage values incorrect. Check mileage values to make sure they are not negative or current mileage is not less than the last oil" +
                    "change mileage";
            }

            //Based on research, brakes need to be changed roughly every 30,000 miles. This is the metric I am using
            if(mileageDifference > 30000)
            {
                //This identifies if the brakes are severly over due. 
                if(mileageDifference - 30000 > 5000)
                {
                    serviceRecommendation = string.Format("Brakes are {0} past due. A brake service is highly recommended", mileageDifference - 30000);
                }else
                    serviceRecommendation = string.Format("Brakes are {0} past due. A brake service is recommended", mileageDifference - 30000);
            }else
                serviceRecommendation = string.Format("Brakes are okay. {0} miles remaining before service is required", 30000 - mileageDifference);

            return serviceRecommendation;
        }
    }
}
