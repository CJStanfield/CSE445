using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MakeAppointment
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
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
                if(!DateTime.TryParseExact(dateString, "g", enUS, DateTimeStyles.AllowLeadingWhite, out dateTime))
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

            TimeSpan timeSpan = new TimeSpan(rand.Next(7,18), rand.Next(10) % 2 * 30, 0);
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
