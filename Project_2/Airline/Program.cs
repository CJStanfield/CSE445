using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace Assignment_2
{
    //Cole Stanfield (1208803696)
    
    public delegate void priceCutEvent(int price);                              //define a delegate. Event signals a price cut has occured
    public delegate void priceIncreaseEvent(int price);                         //define a delegate. Event signals a price increase has occured
    public delegate void orderProcessedEvent(OrderObject order);                //event when an order completes being processed
    public delegate void orderCreatedEvent(string customerId);                                   //event that signals a new order was created
    public delegate void orderFailedEvent(int cardNo);                          //event that signals invalid card number

    static class Program
    {
        public static Buffer orderBuffer;
        public static int orderCount = 1;       //Order count keeps track of how many orders have been placed. This is displayed as the customer #
        public static int N = 5;                //Defined value in the project guidelines
        public static int n = 2;                //Defined value in the project guidelines
        static void Main(string[] args)
        {
            //Create the order buffer
            Semaphore read = new Semaphore(n, n);   //Use a read and write semaphore to manage which threads can access buffer
            Semaphore write = new Semaphore(n, n);
            orderBuffer = new Buffer(read, write);


            //Create the airline object
            //Create the Airline thread and pass in the start function. (airlineFunc)
            Airline airline = new Airline();
            Thread airlineThread = new Thread(new ThreadStart(airline.airlineFunc));
            airlineThread.Name = "Airline 1";
            airlineThread.Start(); //start one airline thread


            //Create the travelAgency Object
            //Define the travel agencies array. There will be 5 travel agency threads.
            TravelAgency travelAgency = new TravelAgency();
            Thread[] agencies = new Thread[N];

    
            //Define the Events used to trigger methods.
            Airline.priceCut += new priceCutEvent(travelAgency.ticketsOnSale);
            Airline.priceIncrease += new priceIncreaseEvent(travelAgency.ticketPriceIncrease);
            OrderProcessing.orderProcessed += new orderProcessedEvent(travelAgency.orderProcessed);
            OrderProcessing.orderFailed += new orderFailedEvent(travelAgency.orderFailed);
            TravelAgency.newOrderCreated += new orderCreatedEvent(airline.Order);

           //Start all the travel agency threads
            for(int i = 0; i < N; i++)
            {
                agencies[i] = new Thread(new ThreadStart(travelAgency.travelFunc));
                agencies[i].Name = (i + 1).ToString();
                agencies[i].Start();
            }
            Thread.Sleep(2000);      //allow all threads to start
        }
    }

}
