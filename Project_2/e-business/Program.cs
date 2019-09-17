using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace e_business
{
    public delegate void priceCutEvent(int pr);     //define a delegate
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class Airline
    {
        private int ticketPrice;
        public int getPrice() { return ticketPrice; }
        public void airlineFunc()
        {
            for(int i = 0; i < 50; i++)
            {
                Thread.Sleep(500);
            }
        }
    }

    public class PricingModel
    {

    }

    public class Buffer
    {

    }

    public class OrderProcessing
    {

    }

    public class TravelAgency
    {


    }
}
