using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Newtonsoft.Json.Linq;

namespace GetCar
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string[] getCar(string year, string make, string model, string zipCode)
        {
            //Get car uses a RESTful api from Market watch. It identifies all used cars in a radius
            string apiKey = "5EcnjpGYmcy4Baosx3Zog17dKeTTf17D";
            string apiURL = string.Format("http://api.marketcheck.com/v1/search?api_key={0}&year={1}&make={2}&model={3}&zip={4}&radius=200&car_type=used&start=0&rows=50&sort_order=asc", apiKey, year, make, model, zipCode);
            string jsonData = null;
            string[] carsForSale = new string[3];       //Only store the top 3 results
            try
            {
                //Get the weather data and store it in the response object
                HttpWebRequest requestObject = (HttpWebRequest)WebRequest.Create(apiURL);
                requestObject.Host = "marketcheck-prod.apigee.net";
                requestObject.Method = "GET";
                HttpWebResponse responseObject = null;
                responseObject = (HttpWebResponse)requestObject.GetResponse();      //Call the api and store the results


                using (Stream stream = responseObject.GetResponseStream())
                {
                    //data comes in as JSON. Convert the json data to a string so that it can be parsed
                    StreamReader sr = new StreamReader(stream);
                    jsonData = sr.ReadToEnd();
                    sr.Close();
                }
                //Convert the string to a real json array. Need to find the "temp_max" element in the json file
                JToken token = JToken.Parse(jsonData);
                JArray carArray = (JArray)token.SelectToken("listings");        //identifies the json array that contains all car listings

                int resultCount = 3;
                if (carArray.Count < 3)
                {
                    resultCount = carArray.Count;
                }

                for (int i = 0; i < resultCount; i++)
                {
                    //iterate through the car objects and find all important attributes about the car. ie price mileage, etc
                    JObject carObject = (JObject)carArray[i];
                    string url = carObject.SelectToken("vdp_url").ToString();
                    string price = carObject.SelectToken("ref_price").ToString();
                    string mileage = carObject.SelectToken("ref_miles").ToString();
                    carsForSale[i] = string.Format("Year: {0}{1}Make: {2}{3}Model: {4}{5}Price: {6}{7}Mileage: {8}{9}Link: {10}", 
                        year,
                        Environment.NewLine,
                        make,
                        Environment.NewLine,
                        model,
                        Environment.NewLine,
                        price,
                        Environment.NewLine,
                        mileage,
                        Environment.NewLine,
                        url);

                }
                return carsForSale;
            }
            catch (Exception e)
            {
                //Return error message if an error occurs
                carsForSale[0] = e.Message;
                return carsForSale;
            }
        }
    }
}
