using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment6TryIt
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GetCarButtonSubmit_Click(object sender, EventArgs e)
        {

            GetCarResult1.Text = null;
            GetCarResult2.Text = null;
            GetCarResult3.Text = null;
            AllServices.Service1Client car = new AllServices.Service1Client();
            try
            {
                //Get the parameters
                string make = GetCarMake.Text;
                string model = GetCarModel.Text;
                string year = GetCarYear.Text;
                string zipcode = GetCarZipcode.Text;

                //Call the service and display the results
                string[] results = car.getCar(year, make, model, zipcode);
                GetCarResult1.Text = results[0];
                GetCarResult2.Text = results[1];
                GetCarResult3.Text = results[2];
            }catch(Exception ex)
            {
                GetCarResult1.Text = ex.Message;
            }
           
        }

        protected void BrakeButtonSubmit_Click(object sender, EventArgs e)
        {

            try
            {
                //Get the parameters
                string[] mileage = { BrakeCurrentMileage.Text, BrakeLastMileage.Text };

                //Generate the URI template
                Uri baseUri = new Uri("http://webstrar32.fulton.asu.edu/page7/Service1.svc");
                UriTemplate myTemplate = new UriTemplate("BrakeService?currentMileage={currentMileage}&LastBrakeChangeMileage={lastMileage}");
                Uri completeUri = myTemplate.BindByPosition(baseUri, mileage);

                WebClient channel = new WebClient(); //create a channel
                byte[] abc = channel.DownloadData(completeUri); //return byte array
                Stream strm = new MemoryStream(abc); //convert to mem stream

                DataContractSerializer obj = new DataContractSerializer(typeof(string));
                string randString = obj.ReadObject(strm).ToString(); //convert to string

                //display the result
                BrakeLabelResult.Text = randString;

            }catch (Exception ex)
            {
                //display any error messages
                BrakeLabelResult.Text = ex.Message;
            }
        }

        protected void OilButtonSubmit_Click(object sender, EventArgs e)
        {
           
            OilLabelResult.Text = null;
            AllServices.Service1Client oil = new AllServices.Service1Client();
            try
            {
                //Get the parameters
                int currentMileage = Convert.ToInt32(OilCurrentMileage.Text);
                int lastMileage = Convert.ToInt32(OilLastMileage.Text);
                string oilType = OilType.Text;
                //Call the service and set the text equal to the output label
                OilLabelResult.Text = oil.OilServiceRecommendation(oilType, currentMileage, lastMileage);
            }
            catch (Exception ex)
            {
                //display any error messages
                OilLabelResult.Text = ex.Message;
            }

        }

        protected void AppointmentButtonSubmit_Click(object sender, EventArgs e)
        {
            AppointmentLabelResult.Text = null;
            AllServices.Service1Client appt = new AllServices.Service1Client();
            try
            {
                //Get the parameters
                string date = DesiredDate.Text;
                string time = DesiredTime.Text;
                
                //Call the service and display the result
                AppointmentLabelResult.Text = appt.ScheduleAppointment(date, time);
            }
            catch (Exception ex)
            {
                //display any error messages
                AppointmentLabelResult.Text = ex.Message;
            }
        }

        protected void Top10Submit_Click(object sender, EventArgs e)
        {
            Top10ListBox.Items.Clear();
            AllServices.Service1Client words = new AllServices.Service1Client();
            string input = Top10URL.Text;

            //Call the service and store the result
            string[] results = words.Top10Words(input);
            foreach (string word in results)
            {
                //Add the result to the listbox
                Top10ListBox.Items.Add(word);
            }
        }

        protected void WeatherSubmit_Click(object sender, EventArgs e)
        {
            //create instance of the service
            WeatherListBox.Items.Clear();
            AllServices.Service1Client weather = new AllServices.Service1Client();
            string input = WeatherZipcode.Text;

            //Call the service and store the result
            string[] results = weather.WeatherService(input);

            foreach (string temperature in results)
            {
                //Add result to the list box
                WeatherListBox.Items.Add(temperature);
            }
        }
    }
}