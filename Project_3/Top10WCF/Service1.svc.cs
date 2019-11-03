using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Globalization;

namespace Top10WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
       public string[] Top10Words(string url)
        {
            //Store the words in a string. Return later
            string[] top10Words = new string[10];
            string regex = "[A-Za-z ]+";            //Regex used to identify the 10 most common words on the page
            
            try
            {
                //Create instance of the Web2String service
                Web2String.ServiceClient webData = new Web2String.ServiceClient();
                string data = webData.GetWebContent(url);       //Call the service and store the data
                var topWords = Regex.Matches(data, regex)       //Linq and Regex used to identify the most common words from data
                    .Cast<Match>()
                    .Select(match => match.Value)
                    .Where(value => value.Length > 3)           //Only choose words whose length is greater than 3Pro
                    .GroupBy(match => match)
                    .OrderByDescending(match => match.Count())
                    .ToList();

                for (int i = 0; i < top10Words.Length; i++)
                {
                    //Get the top words and store them in the array to be returned
                    top10Words[i] = topWords[i].Key;
                }
                return top10Words;
            }
            catch (Exception e)
            {
                //Return error message if an error occurs
                top10Words[0] = e.Message;
                return top10Words;
            }
   
        }

        public string[] WeatherService(string zipcode)
        {
            //Test data was used so I would not go over my api call daily limit
            string testData = "{\"cod\":\"200\",\"message\":0.0122,\"cnt\":40,\"list\":[{\"dt\":1519074000,\"main\":{\"temp\":283.99,\"temp_min\":281.801,\"temp_max\":283.99,\"pressure\":989.94,\"sea_level\":1029.29,\"grnd_level\":989.94,\"humidity\":52,\"temp_kf\":2.19},\"weather\":[{\"id\":801,\"main\":\"Clouds\",\"description\":\"few clouds\",\"icon\":\"02d\"}],\"clouds\":{\"all\":20},\"wind\":{\"speed\":3.36,\"deg\":325.001},\"rain\":{},\"sys\":{\"pod\":\"d\"},\"dt_txt\":\"2018-02-19 21:00:00\"},{\"dt\":1519084800,\"main\":{\"temp\":282.64,\"temp_min\":281.177,\"temp_max\":282.64,\"pressure\":990.6,\"sea_level\":1029.94,\"grnd_level\":990.6,\"humidity\":47,\"temp_kf\":1.46},\"weather\":[{\"id\":802,\"main\":\"Clouds\",\"description\":\"scattered clouds\",\"icon\":\"03n\"}],\"clouds\":{\"all\":36},\"wind\":{\"speed\":3.17,\"deg\":319.502},\"rain\":{},\"sys\":{\"pod\":\"n\"},\"dt_txt\":\"2018-02-20 00:00:00\"},{\"dt\":1519095600,\"main\":{\"temp\":278.3,\"temp_min\":277.566,\"temp_max\":278.3,\"pressure\":992.46,\"sea_level\":1032.01,\"grnd_level\":992.46,\"humidity\":53,\"temp_kf\":0.73},\"weather\":[{\"id\":800,\"main\":\"Clear\",\"description\":\"clear sky\",\"icon\":\"01n\"}],\"clouds\":{\"all\":0},\"wind\":{\"speed\":2.12,\"deg\":309.009},\"rain\":{},\"sys\":{\"pod\":\"n\"},\"dt_txt\":\"2018-02-20 03:00:00\"},{\"dt\":1519106400,\"main\":{\"temp\":273.972,\"temp_min\":273.972,\"temp_max\":273.972,\"pressure\":993.96,\"sea_level\":1033.75,\"grnd_level\":993.96,\"humidity\":69,\"temp_kf\":0},\"weather\":[{\"id\":800,\"main\":\"Clear\",\"description\":\"clear sky\",\"icon\":\"01n\"}],\"clouds\":{\"all\":0},\"wind\":{\"speed\":1.96,\"deg\":307},\"rain\":{},\"sys\":{\"pod\":\"n\"},\"dt_txt\":\"2018-02-20 06:00:00\"},{\"dt\":1519117200,\"main\":{\"temp\":271.856,\"temp_min\":271.856,\"temp_max\":271.856,\"pressure\":995.07,\"sea_level\":1035.03,\"grnd_level\":995.07,\"humidity\":80,\"temp_kf\":0},\"weather\":[{\"id\":800,\"main\":\"Clear\",\"description\":\"clear sky\",\"icon\":\"01n\"}],\"clouds\":{\"all\":0},\"wind\":{\"speed\":1.81,\"deg\":305.003},\"rain\":{},\"sys\":{\"pod\":\"n\"},\"dt_txt\":\"2018-02-20 09:00:00\"},{\"dt\":1519128000,\"main\":{\"temp\":269.692,\"temp_min\":269.692,\"temp_max\":269.692,\"pressure\":995.34,\"sea_level\":1035.47,\"grnd_level\":995.34,\"humidity\":87,\"temp_kf\":0},\"weather\":[{\"id\":800,\"main\":\"Clear\",\"description\":\"clear sky\",\"icon\":\"01n\"}],\"clouds\":{\"all\":0},\"wind\":{\"speed\":1.31,\"deg\":308.503},\"rain\":{},\"sys\":{\"pod\":\"n\"},\"dt_txt\":\"2018-02-20 12:00:00\"},{\"dt\":1519138800,\"main\":{\"temp\":268.169,\"temp_min\":268.169,\"temp_max\":268.169,\"pressure\":996.59,\"sea_level\":1036.87,\"grnd_level\":996.59,\"humidity\":87,\"temp_kf\":0},\"weather\":[{\"id\":800,\"main\":\"Clear\",\"description\":\"clear sky\",\"icon\":\"01d\"}],\"clouds\":{\"all\":0},\"wind\":{\"speed\":1.06,\"deg\":310.5},\"rain\":{},\"sys\":{\"pod\":\"d\"},\"dt_txt\":\"2018-02-20 15:00:00\"},{\"dt\":1519149600,\"main\":{\"temp\":279.577,\"temp_min\":279.577,\"temp_max\":279.577,\"pressure\":997.47,\"sea_level\":1037.47,\"grnd_level\":997.47,\"humidity\":56,\"temp_kf\":0},\"weather\":[{\"id\":800,\"main\":\"Clear\",\"description\":\"clear sky\",\"icon\":\"01d\"}],\"clouds\":{\"all\":0},\"wind\":{\"speed\":1.16,\"deg\":261.501},\"rain\":{},\"sys\":{\"pod\":\"d\"},\"dt_txt\":\"2018-02-20 18:00:00\"},{\"dt\":1519160400,\"main\":{\"temp\":282.676,\"temp_min\":282.676,\"temp_max\":282.676,\"pressure\":996.36,\"sea_level\":1036.17,\"grnd_level\":996.36,\"humidity\":50,\"temp_kf\":0},\"weather\":[{\"id\":800,\"main\":\"Clear\",\"description\":\"clear sky\",\"icon\":\"01d\"}],\"clouds\":{\"all\":0},\"wind\":{\"speed\":1.25,\"deg\":245.003},\"rain\":{},\"sys\":{\"pod\":\"d\"},\"dt_txt\":\"2018-02-20 21:00:00\"},{\"dt\":1519171200,\"main\":{\"temp\":282.104,\"temp_min\":282.104,\"temp_max\":282.104,\"pressure\":995.95,\"sea_level\":1035.57,\"grnd_level\":995.95,\"humidity\":46,\"temp_kf\":0},\"weather\":[{\"id\":800,\"main\":\"Clear\",\"description\":\"clear sky\",\"icon\":\"01n\"}],\"clouds\":{\"all\":0},\"wind\":{\"speed\":1.72,\"deg\":287.51},\"rain\":{},\"sys\":{\"pod\":\"n\"},\"dt_txt\":\"2018-02-21 00:00:00\"},{\"dt\":1519182000,\"main\":{\"temp\":277.158,\"temp_min\":277.158,\"temp_max\":277.158,\"pressure\":996.54,\"sea_level\":1036.15,\"grnd_level\":996.54,\"humidity\":57,\"temp_kf\":0},\"weather\":[{\"id\":802,\"main\":\"Clouds\",\"description\":\"scattered clouds\",\"icon\":\"03n\"}],\"clouds\":{\"all\":44},\"wind\":{\"speed\":1.94,\"deg\":300.001},\"rain\":{},\"sys\":{\"pod\":\"n\"},\"dt_txt\":\"2018-02-21 03:00:00\"},{\"dt\":1519192800,\"main\":{\"temp\":274.107,\"temp_min\":274.107,\"temp_max\":274.107,\"pressure\":996.81,\"sea_level\":1036.63,\"grnd_level\":996.81,\"humidity\":88,\"temp_kf\":0},\"weather\":[{\"id\":802,\"main\":\"Clouds\",\"description\":\"scattered clouds\",\"icon\":\"03n\"}],\"clouds\":{\"all\":32},\"wind\":{\"speed\":1.41,\"deg\":304.004},\"rain\":{},\"sys\":{\"pod\":\"n\"},\"dt_txt\":\"2018-02-21 06:00:00\"},{\"dt\":1519203600,\"main\":{\"temp\":271.616,\"temp_min\":271.616,\"temp_max\":271.616,\"pressure\":996.57,\"sea_level\":1036.49,\"grnd_level\":996.57,\"humidity\":93,\"temp_kf\":0},\"weather\":[{\"id\":801,\"main\":\"Clouds\",\"description\":\"few clouds\",\"icon\":\"02n\"}],\"clouds\":{\"all\":12},\"wind\":{\"speed\":0.97,\"deg\":302.002},\"rain\":{},\"sys\":{\"pod\":\"n\"},\"dt_txt\":\"2018-02-21 09:00:00\"},{\"dt\":1519214400,\"main\":{\"temp\":270.18,\"temp_min\":270.18,\"temp_max\":270.18,\"pressure\":996.04,\"sea_level\":1036.07,\"grnd_level\":996.04,\"humidity\":91,\"temp_kf\":0},\"weather\":[{\"id\":500,\"main\":\"Rain\",\"description\":\"light rain\",\"icon\":\"10n\"}],\"clouds\":{\"all\":36},\"wind\":{\"speed\":0.76,\"deg\":307.5},\"rain\":{\"3h\":0.005},\"sys\":{\"pod\":\"n\"},\"dt_txt\":\"2018-02-21 12:00:00\"},{\"dt\":1519225200,\"main\":{\"temp\":271.622,\"temp_min\":271.622,\"temp_max\":271.622,\"pressure\":996.42,\"sea_level\":1036.63,\"grnd_level\":996.42,\"humidity\":96,\"temp_kf\":0},\"weather\":[{\"id\":500,\"main\":\"Rain\",\"description\":\"light rain\",\"icon\":\"10d\"}],\"clouds\":{\"all\":80},\"wind\":{\"speed\":0.65,\"deg\":59.5043},\"rain\":{\"3h\":0.32},\"sys\":{\"pod\":\"d\"},\"dt_txt\":\"2018-02-21 15:00:00\"},{\"dt\":1519236000,\"main\":{\"temp\":278.703,\"temp_min\":278.703,\"temp_max\":278.703,\"pressure\":996.95,\"sea_level\":1036.91,\"grnd_level\":996.95,\"humidity\":89,\"temp_kf\":0},\"weather\":[{\"id\":500,\"main\":\"Rain\",\"description\":\"light rain\",\"icon\":\"10d\"}],\"clouds\":{\"all\":76},\"wind\":{\"speed\":1.12,\"deg\":159.504},\"rain\":{\"3h\":0.455},\"sys\":{\"pod\":\"d\"},\"dt_txt\":\"2018-02-21 18:00:00\"},{\"dt\":1519246800,\"main\":{\"temp\":280.884,\"temp_min\":280.884,\"temp_max\":280.884,\"pressure\":996.59,\"sea_level\":1036.21,\"grnd_level\":996.59,\"humidity\":84,\"temp_kf\":0},\"weather\":[{\"id\":500,\"main\":\"Rain\",\"description\":\"light rain\",\"icon\":\"10d\"}],\"clouds\":{\"all\":92},\"wind\":{\"speed\":1.46,\"deg\":232.004},\"rain\":{\"3h\":0.2},\"sys\":{\"pod\":\"d\"},\"dt_txt\":\"2018-02-21 21:00:00\"},{\"dt\":1519257600,\"main\":{\"temp\":280.979,\"temp_min\":280.979,\"temp_max\":280.979,\"pressure\":996.24,\"sea_level\":1035.68,\"grnd_level\":996.24,\"humidity\":82,\"temp_kf\":0},\"weather\":[{\"id\":500,\"main\":\"Rain\",\"description\":\"light rain\",\"icon\":\"10n\"}],\"clouds\":{\"all\":88},\"wind\":{\"speed\":1.5,\"deg\":270.5},\"rain\":{\"3h\":0.21},\"sys\":{\"pod\":\"n\"},\"dt_txt\":\"2018-02-22 00:00:00\"},{\"dt\":1519268400,\"main\":{\"temp\":277.803,\"temp_min\":277.803,\"temp_max\":277.803,\"pressure\":996.2,\"sea_level\":1035.92,\"grnd_level\":996.2,\"humidity\":93,\"temp_kf\":0},\"weather\":[{\"id\":500,\"main\":\"Rain\",\"description\":\"light rain\",\"icon\":\"10n\"}],\"clouds\":{\"all\":48},\"wind\":{\"speed\":1.06,\"deg\":270.001},\"rain\":{\"3h\":0.075},\"sys\":{\"pod\":\"n\"},\"dt_txt\":\"2018-02-22 03:00:00\"},{\"dt\":1519279200,\"main\":{\"temp\":275.158,\"temp_min\":275.158,\"temp_max\":275.158,\"pressure\":996.81,\"sea_level\":1036.55,\"grnd_level\":996.81,\"humidity\":97,\"temp_kf\":0},\"weather\":[{\"id\":500,\"main\":\"Rain\",\"description\":\"light rain\",\"icon\":\"10n\"}],\"clouds\":{\"all\":68},\"wind\":{\"speed\":1.12,\"deg\":268.001},\"rain\":{\"3h\":0.025},\"sys\":{\"pod\":\"n\"},\"dt_txt\":\"2018-02-22 06:00:00\"},{\"dt\":1519290000,\"main\":{\"temp\":274.189,\"temp_min\":274.189,\"temp_max\":274.189,\"pressure\":996.89,\"sea_level\":1036.81,\"grnd_level\":996.89,\"humidity\":94,\"temp_kf\":0},\"weather\":[{\"id\":500,\"main\":\"Rain\",\"description\":\"light rain\",\"icon\":\"10n\"}],\"clouds\":{\"all\":56},\"wind\":{\"speed\":1.16,\"deg\":258.5},\"rain\":{\"3h\":0.01},\"sys\":{\"pod\":\"n\"},\"dt_txt\":\"2018-02-22 09:00:00\"},{\"dt\":1519300800,\"main\":{\"temp\":273.218,\"temp_min\":273.218,\"temp_max\":273.218,\"pressure\":996.5,\"sea_level\":1036.46,\"grnd_level\":996.5,\"humidity\":93,\"temp_kf\":0},\"weather\":[{\"id\":500,\"main\":\"Rain\",\"description\":\"light rain\",\"icon\":\"10n\"}],\"clouds\":{\"all\":12},\"wind\":{\"speed\":1.21,\"deg\":252.006},\"rain\":{\"3h\":0.01},\"sys\":{\"pod\":\"n\"},\"dt_txt\":\"2018-02-22 12:00:00\"},{\"dt\":1519311600,\"main\":{\"temp\":270.248,\"temp_min\":270.248,\"temp_max\":270.248,\"pressure\":996.46,\"sea_level\":1036.63,\"grnd_level\":996.46,\"humidity\":87,\"temp_kf\":0},\"weather\":[{\"id\":801,\"main\":\"Clouds\",\"description\":\"few clouds\",\"icon\":\"02d\"}],\"clouds\":{\"all\":20},\"wind\":{\"speed\":1.44,\"deg\":254.502},\"rain\":{},\"sys\":{\"pod\":\"d\"},\"dt_txt\":\"2018-02-22 15:00:00\"},{\"dt\":1519322400,\"main\":{\"temp\":279.559,\"temp_min\":279.559,\"temp_max\":279.559,\"pressure\":997.16,\"sea_level\":1036.98,\"grnd_level\":997.16,\"humidity\":76,\"temp_kf\":0},\"weather\":[{\"id\":802,\"main\":\"Clouds\",\"description\":\"scattered clouds\",\"icon\":\"03d\"}],\"clouds\":{\"all\":48},\"wind\":{\"speed\":1.77,\"deg\":281.001},\"rain\":{},\"sys\":{\"pod\":\"d\"},\"dt_txt\":\"2018-02-22 18:00:00\"},{\"dt\":1519333200,\"main\":{\"temp\":281.812,\"temp_min\":281.812,\"temp_max\":281.812,\"pressure\":996.36,\"sea_level\":1036,\"grnd_level\":996.36,\"humidity\":65,\"temp_kf\":0},\"weather\":[{\"id\":802,\"main\":\"Clouds\",\"description\":\"scattered clouds\",\"icon\":\"03d\"}],\"clouds\":{\"all\":44},\"wind\":{\"speed\":2.6,\"deg\":288.002},\"rain\":{},\"sys\":{\"pod\":\"d\"},\"dt_txt\":\"2018-02-22 21:00:00\"},{\"dt\":1519344000,\"main\":{\"temp\":281.557,\"temp_min\":281.557,\"temp_max\":281.557,\"pressure\":995.1,\"sea_level\":1034.65,\"grnd_level\":995.1,\"humidity\":63,\"temp_kf\":0},\"weather\":[{\"id\":803,\"main\":\"Clouds\",\"description\":\"broken clouds\",\"icon\":\"04n\"}],\"clouds\":{\"all\":76},\"wind\":{\"speed\":2.52,\"deg\":267.503},\"rain\":{},\"sys\":{\"pod\":\"n\"},\"dt_txt\":\"2018-02-23 00:00:00\"},{\"dt\":1519354800,\"main\":{\"temp\":278.157,\"temp_min\":278.157,\"temp_max\":278.157,\"pressure\":993.9,\"sea_level\":1033.66,\"grnd_level\":993.9,\"humidity\":94,\"temp_kf\":0},\"weather\":[{\"id\":500,\"main\":\"Rain\",\"description\":\"light rain\",\"icon\":\"10n\"}],\"clouds\":{\"all\":88},\"wind\":{\"speed\":2.43,\"deg\":213.501},\"rain\":{\"3h\":1.675},\"sys\":{\"pod\":\"n\"},\"dt_txt\":\"2018-02-23 03:00:00\"},{\"dt\":1519365600,\"main\":{\"temp\":277.192,\"temp_min\":277.192,\"temp_max\":277.192,\"pressure\":993.22,\"sea_level\":1033.14,\"grnd_level\":993.22,\"humidity\":100,\"temp_kf\":0},\"weather\":[{\"id\":501,\"main\":\"Rain\",\"description\":\"moderate rain\",\"icon\":\"10n\"}],\"clouds\":{\"all\":92},\"wind\":{\"speed\":1.02,\"deg\":202.503},\"rain\":{\"3h\":6.675},\"sys\":{\"pod\":\"n\"},\"dt_txt\":\"2018-02-23 06:00:00\"},{\"dt\":1519376400,\"main\":{\"temp\":276.093,\"temp_min\":276.093,\"temp_max\":276.093,\"pressure\":992.68,\"sea_level\":1032.71,\"grnd_level\":992.68,\"humidity\":100,\"temp_kf\":0},\"weather\":[{\"id\":500,\"main\":\"Rain\",\"description\":\"light rain\",\"icon\":\"10n\"}],\"clouds\":{\"all\":68},\"wind\":{\"speed\":1.18,\"deg\":84.0001},\"rain\":{\"3h\":0.865},\"sys\":{\"pod\":\"n\"},\"dt_txt\":\"2018-02-23 09:00:00\"},{\"dt\":1519387200,\"main\":{\"temp\":275.6,\"temp_min\":275.6,\"temp_max\":275.6,\"pressure\":992.47,\"sea_level\":1032.53,\"grnd_level\":992.47,\"humidity\":98,\"temp_kf\":0},\"weather\":[{\"id\":501,\"main\":\"Rain\",\"description\":\"moderate rain\",\"icon\":\"10n\"}],\"clouds\":{\"all\":92},\"wind\":{\"speed\":1.03,\"deg\":14.5031},\"rain\":{\"3h\":3.85},\"sys\":{\"pod\":\"n\"},\"dt_txt\":\"2018-02-23 12:00:00\"},{\"dt\":1519398000,\"main\":{\"temp\":275.166,\"temp_min\":275.166,\"temp_max\":275.166,\"pressure\":992.88,\"sea_level\":1033.03,\"grnd_level\":992.88,\"humidity\":100,\"temp_kf\":0},\"weather\":[{\"id\":500,\"main\":\"Rain\",\"description\":\"light rain\",\"icon\":\"10d\"}],\"clouds\":{\"all\":88},\"wind\":{\"speed\":1.18,\"deg\":10.0015},\"rain\":{\"3h\":0.95},\"sys\":{\"pod\":\"d\"},\"dt_txt\":\"2018-02-23 15:00:00\"},{\"dt\":1519408800,\"main\":{\"temp\":277.785,\"temp_min\":277.785,\"temp_max\":277.785,\"pressure\":994.13,\"sea_level\":1034.25,\"grnd_level\":994.13,\"humidity\":95,\"temp_kf\":0},\"weather\":[{\"id\":500,\"main\":\"Rain\",\"description\":\"light rain\",\"icon\":\"10d\"}],\"clouds\":{\"all\":48},\"wind\":{\"speed\":1.5,\"deg\":17.5006},\"rain\":{\"3h\":0.030000000000001},\"sys\":{\"pod\":\"d\"},\"dt_txt\":\"2018-02-23 18:00:00\"},{\"dt\":1519419600,\"main\":{\"temp\":280.091,\"temp_min\":280.091,\"temp_max\":280.091,\"pressure\":993.64,\"sea_level\":1033.38,\"grnd_level\":993.64,\"humidity\":86,\"temp_kf\":0},\"weather\":[{\"id\":500,\"main\":\"Rain\",\"description\":\"light rain\",\"icon\":\"10d\"}],\"clouds\":{\"all\":36},\"wind\":{\"speed\":1.76,\"deg\":15.0001},\"rain\":{\"3h\":0.004999999999999},\"sys\":{\"pod\":\"d\"},\"dt_txt\":\"2018-02-23 21:00:00\"},{\"dt\":1519430400,\"main\":{\"temp\":280.846,\"temp_min\":280.846,\"temp_max\":280.846,\"pressure\":993.19,\"sea_level\":1032.55,\"grnd_level\":993.19,\"humidity\":81,\"temp_kf\":0},\"weather\":[{\"id\":800,\"main\":\"Clear\",\"description\":\"clear sky\",\"icon\":\"01n\"}],\"clouds\":{\"all\":0},\"wind\":{\"speed\":2.13,\"deg\":12.5009},\"rain\":{},\"sys\":{\"pod\":\"n\"},\"dt_txt\":\"2018-02-24 00:00:00\"},{\"dt\":1519441200,\"main\":{\"temp\":276.774,\"temp_min\":276.774,\"temp_max\":276.774,\"pressure\":994.05,\"sea_level\":1033.52,\"grnd_level\":994.05,\"humidity\":88,\"temp_kf\":0},\"weather\":[{\"id\":800,\"main\":\"Clear\",\"description\":\"clear sky\",\"icon\":\"01n\"}],\"clouds\":{\"all\":0},\"wind\":{\"speed\":1.97,\"deg\":331.5},\"rain\":{},\"sys\":{\"pod\":\"n\"},\"dt_txt\":\"2018-02-24 03:00:00\"},{\"dt\":1519452000,\"main\":{\"temp\":273.275,\"temp_min\":273.275,\"temp_max\":273.275,\"pressure\":994.81,\"sea_level\":1034.51,\"grnd_level\":994.81,\"humidity\":95,\"temp_kf\":0},\"weather\":[{\"id\":800,\"main\":\"Clear\",\"description\":\"clear sky\",\"icon\":\"01n\"}],\"clouds\":{\"all\":0},\"wind\":{\"speed\":1.67,\"deg\":312.503},\"rain\":{},\"sys\":{\"pod\":\"n\"},\"dt_txt\":\"2018-02-24 06:00:00\"},{\"dt\":1519462800,\"main\":{\"temp\":271.136,\"temp_min\":271.136,\"temp_max\":271.136,\"pressure\":995.16,\"sea_level\":1034.94,\"grnd_level\":995.16,\"humidity\":94,\"temp_kf\":0},\"weather\":[{\"id\":800,\"main\":\"Clear\",\"description\":\"clear sky\",\"icon\":\"01n\"}],\"clouds\":{\"all\":0},\"wind\":{\"speed\":1.61,\"deg\":299.001},\"rain\":{},\"sys\":{\"pod\":\"n\"},\"dt_txt\":\"2018-02-24 09:00:00\"},{\"dt\":1519473600,\"main\":{\"temp\":269.836,\"temp_min\":269.836,\"temp_max\":269.836,\"pressure\":995.17,\"sea_level\":1035.03,\"grnd_level\":995.17,\"humidity\":93,\"temp_kf\":0},\"weather\":[{\"id\":500,\"main\":\"Rain\",\"description\":\"light rain\",\"icon\":\"10n\"}],\"clouds\":{\"all\":0},\"wind\":{\"speed\":1.32,\"deg\":281.5},\"rain\":{\"3h\":0.0050000000000008},\"sys\":{\"pod\":\"n\"},\"dt_txt\":\"2018-02-24 12:00:00\"},{\"dt\":1519484400,\"main\":{\"temp\":268.491,\"temp_min\":268.491,\"temp_max\":268.491,\"pressure\":996.36,\"sea_level\":1036.28,\"grnd_level\":996.36,\"humidity\":85,\"temp_kf\":0},\"weather\":[{\"id\":800,\"main\":\"Clear\",\"description\":\"clear sky\",\"icon\":\"02d\"}],\"clouds\":{\"all\":8},\"wind\":{\"speed\":0.63,\"deg\":220.505},\"rain\":{},\"sys\":{\"pod\":\"d\"},\"dt_txt\":\"2018-02-24 15:00:00\"},{\"dt\":1519495200,\"main\":{\"temp\":280.831,\"temp_min\":280.831,\"temp_max\":280.831,\"pressure\":997.47,\"sea_level\":1037.05,\"grnd_level\":997.47,\"humidity\":91,\"temp_kf\":0},\"weather\":[{\"id\":800,\"main\":\"Clear\",\"description\":\"clear sky\",\"icon\":\"01d\"}],\"clouds\":{\"all\":0},\"wind\":{\"speed\":1.01,\"deg\":192.506},\"rain\":{},\"sys\":{\"pod\":\"d\"},\"dt_txt\":\"2018-02-24 18:00:00\"}],\"city\":{\"name\":\"Mountain View\",\"coord\":{\"lat\":37.3855,\"lon\":-122.088},\"country\":\"US\"}}\n";
            string jsonData = null;
            string[] FiveDayWeather = new String[5];
            string apiKey = "1681919ad800d13233713637ee2d846b";
            string weatherApiUrl = string.Format("http://api.openweathermap.org/data/2.5/forecast?zip={0}&appid={1}", zipcode, apiKey);
            //Used the openweathermap api to get the weather information

            try
            {
                //Get the weather data and store it in the response object
                WebRequest requestObject = WebRequest.Create(weatherApiUrl);
                requestObject.Method = "GET";
                HttpWebResponse responseObject = null;
                responseObject = (HttpWebResponse)requestObject.GetResponse();


                using (Stream stream = responseObject.GetResponseStream())
                {
                    //Stream the data as a json string
                    StreamReader sr = new StreamReader(stream);
                    jsonData = sr.ReadToEnd();
                    sr.Close();
                }
                //Convert the string to a real json array. Need to find the "temp_max" element in the json file
                JToken token = JToken.Parse(jsonData);
                JArray weatherArray = (JArray)token.SelectToken("list");

                for (int i = 0; i < 5; i++)
                {
                    //iterate through the array and identify the maximum temp for the given day. This will be the information that is returned
                    JObject weatherObject = (JObject)weatherArray[i];
                    double temperature = (double)weatherObject.SelectToken("main").SelectToken("temp_max");
                    double fahrenheit = (((temperature - 273.15) * 1.8) + 32);      //Convert kelvin to fahrenheit
                    FiveDayWeather[i] = string.Format("{0:N2} F", fahrenheit);
                }
                return FiveDayWeather;
            }catch (Exception e)
            {
                //Return error message if an error occurs
                FiveDayWeather[0] = e.Message;
                return FiveDayWeather;
            }
        }



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


        public string ScheduleAppointment(string date, string time)
        {
            //This service lets someone schedule an appointment to get their car serviced.
            //Uses dummy data to check to make sure the time the user wants is actually available
            int tempAppointmentSize = 100;
            string returnMessage;
            Appointment appointment = new Appointment(date, time);      //Create instance of an appointment for the user
            if (!appointment.getError())
            {
                //Generate array of dummy data appointments representing other users who are scheduling appointments
                //This is done because I do not have access to a database. otherwise appointments would be looked up in database
                Appointment[] tempAppointments = new Appointment[tempAppointmentSize];                //Since no access to a database, simulate appointments
                for (int i = 0; i < tempAppointmentSize; i++)
                {
                    tempAppointments[i] = new Appointment("generate", "generate");
                    DateTime temp = tempAppointments[i].getDateTime();
                    if (tempAppointments[i].getDateTime() == appointment.getDateTime()) //Makes sure that the the appointment does not interfere with other appointments
                    {
                        returnMessage = "Sorry. There is already a scheduled appointment at this time.\nPlease input another time.";
                    }
                }
                returnMessage = "Appointment scheduled successfully!";

                return returnMessage;

            }
            returnMessage = "Date and time information entered incorrectly. Please follow the correct format MM:dd:yyyy HH:mm AM/PM";
            return returnMessage;
        }

        public string OilServiceRecommendation(string oilType, int currentMileage, int lastOilChangeMileage)
        {
            //Get the mileage difference which will be used for identifying the intervals
            int mileageDifference = currentMileage - lastOilChangeMileage;
            string serviceRecommendation = "";

            //Basic error checking. Make sure that no value is less than 0 and that current mielage is not less than last mileage
            if (currentMileage < lastOilChangeMileage || currentMileage < 0 || lastOilChangeMileage < 0)
            {
                return "Mileage values incorrect. Check mileage values to make sure they are not negative or current mileage is not less than the last oil" +
                    "change mileage";
            }

            //switch the oil type. There are two different oil change intervals. One for conventional oil and one for synthetic oil.
            switch (oilType.ToLower())
            {
                case "conventional":
                    //If oil is conventional, oil should be changed every 3000 miles
                    if (mileageDifference >= 3000)
                    {
                        if ((mileageDifference - 3000) > 1000)
                        {
                            serviceRecommendation = "Oil change is over 1000 miles past due. Oil change HIGHLY RECOMMENDED!";
                        }
                        else
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


    public class Appointment
    {
        //Appointment class helps keep track of day and time of an Appointment
        //Stores useful information such as the format of the date/time
        //as well as the date time itself.
        Random rand = new Random();
        DateTime dateTime = new DateTime();
        string dateTimePattern = "MM/dd/yy H:mm";
        CultureInfo enUS = new CultureInfo("en-US");
        bool error = false;
        public Appointment(string date, string time)
        {
            if (date == "generate" && time == "generate")
            {
                dateTime = generateDateTime();
            }
            else
            {
                string temp = "5/01/2009 8:30 AM";
                string dateString = string.Format("{0} {1}", date, time);
                if (!DateTime.TryParseExact(dateString, "g", enUS, DateTimeStyles.AllowLeadingWhite, out dateTime))
                {
                    error = true;
                }
            }
        }
        //Helper method returs the dateTime object
        public DateTime getDateTime()
        {
            return dateTime;
        }

        //returns if an error has occured. boolean value
        public bool getError()
        {
            return error;
        }
        //Method generates date time. Used for the dummy data
        public DateTime generateDateTime()
        {
            DateTime temp = DateTime.Today;

            TimeSpan timeSpan = new TimeSpan(rand.Next(7, 18), rand.Next(10) % 2 * 30, 0);
            temp = temp.AddDays(rand.Next(7));
            temp = temp.Date + timeSpan;
            return temp;
        }

        override
        public string ToString()
        {
            return dateTime.ToString(dateTimePattern);
        }
    }

}
