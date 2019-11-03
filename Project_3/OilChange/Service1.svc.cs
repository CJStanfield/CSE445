using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace OilChange
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string OilServiceRecommendation(string oilType, int currentMileage, int lastOilChangeMileage)
        {
            //Get the mileage difference which will be used for identifying the intervals
            int mileageDifference = currentMileage - lastOilChangeMileage;
            string serviceRecommendation = "";
            
            //Basic error checking. Make sure that no value is less than 0 and that current mielage is not less than last mileage
            if(currentMileage < lastOilChangeMileage || currentMileage < 0 || lastOilChangeMileage < 0)
            {
                return "Mileage values incorrect. Check mileage values to make sure they are not negative or current mileage is not less than the last oil" +
                    "change mileage";
            }

            //switch the oil type. There are two different oil change intervals. One for conventional oil and one for synthetic oil.
            switch (oilType.ToLower())
            {
                case "conventional":
                    //If oil is conventional, oil should be changed every 3000 miles
                    if(mileageDifference >= 3000)
                    {
                        if ((mileageDifference - 3000) > 1000) {
                            serviceRecommendation = "Oil change is over 1000 miles past due. Oil change HIGHLY RECOMMENDED!";
                        } else
                            serviceRecommendation = "An oil change is recommended based on the current mileage";
                    }
                    else
                    {
                        serviceRecommendation = string.Format("Oil still has {0} miles left before requiring an oil change", (3000 - mileageDifference));
                    }
                    break;
                    //if ois is synthetic then the oil should be changed  every 8000 miles
                case "synthetic":
                    if (mileageDifference >= 8000)
                    {
                        if ((mileageDifference - 8000) > 1000)
                        {
                            serviceRecommendation = "Oil change is over 1000 miles past due. Oil change HIGHLY RECOMMENDED!";
                        }
                        else
                            serviceRecommendation = "An oil change is recommended based on the current mileage";
                    }
                    else
                    {
                        serviceRecommendation = string.Format("Oil still has {0} miles left before requiring an oil change", (8000 - mileageDifference));
                    }
                    break;
                default: serviceRecommendation = "Invalid oil type. Please choose either conventional or synthetic oil."; break;
                
            }
            return serviceRecommendation;
        }
    }
}
