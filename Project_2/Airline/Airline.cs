using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Assignment_2
{
    public class Airline
    {
        //Events used to trigger price increases/cuts
        public static event priceCutEvent priceCut;
        public static event priceIncreaseEvent priceIncrease;

        private static int ticketPrice = 100;       //Starting ticket price
        private static string threadName = "";
        private static int pCuts = 0;               //Number of price cuts that have taken place. After 20, end program
        private static int p = 20;                  //Total # of price cuts allowed. From project guidelinesS

        public static Random rand = new Random();
        
        public void airlineFunc()
        {
            threadName = Thread.CurrentThread.Name;             //Get the airline thread name
            Console.WriteLine("Initial Airline Ticket Price: ${0}\n\n", ticketPrice);
            while (pCuts < p)
            {
                Thread.Sleep(rand.Next(2000, 3000));          //use this time to generate a new price
                ticketPrice = pricingModel();                 //The pricing model gets a new price and triggers the correct event delegate
            }
        }

        public int pricingModel()
        {
            int newPrice = rand.Next(50, 200); //generate new price between 50 and 200
            if (newPrice < getPrice())           //Simply updates the ticketPrice if it is less than the current one. 
            {
                priceCut(newPrice);        //Signal price cut event if the new price is less than the old one
                pCuts++;
            }
            else
                priceIncrease(newPrice);     //Signal price increase event if the new price is greater than the old one
            return newPrice;
        }

        public void Order(string customerId)
        {
            //This causes the orders to be processed asynchronously.
            //Commenting out the Thread.Sleep function will cause orders to be evaluated in order and instantly
            Console.WriteLine("ORDER PLACED FOR CUSTOMER #{0} \n\n", customerId);
            Thread.Sleep(rand.Next(500, 1000));
            OrderObject order = Program.orderBuffer.getBuffer();        //Get the order from the buffer and start an order processing thread.
            Thread thread = new Thread(() => OrderProcessing.processOrderFunc(order));
            thread.Start();
        }


        //getter methods
        public string getThreadName() { return threadName; }
        public int getPrice() { return ticketPrice; }
        public int getPCuts() { return pCuts; }
        public int getP() { return p; }
    }
}
