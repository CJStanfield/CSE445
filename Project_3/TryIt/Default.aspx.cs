using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TryIt
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //create instance of the service
            ListBoxWeather.Items.Clear();
            Assignment5Services.Service1Client weather = new Assignment5Services.Service1Client();
            string input = WeatherInput.Text;

            //Call the service and store the result
            string[] results = weather.WeatherService(input);

            foreach(string temperature in results)
            {
                //Add result to the list box
                ListBoxWeather.Items.Add(temperature);
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Create instance of service
            ListBoxWords.Items.Clear();
            Assignment5Services.Service1Client words = new Assignment5Services.Service1Client();
            string input = TopWordsInput.Text;

            //Call the service and store the result
            string[] results = words.Top10Words(input);

            foreach (string word in results)
            {
                //Add the result to the listbox
                ListBoxWords.Items.Add(word);
            }

        }
    }
}