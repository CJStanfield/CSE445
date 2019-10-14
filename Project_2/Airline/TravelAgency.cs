using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Assignment_2
{
    
    public class TravelAgency
    {
        public static event orderCreatedEvent newOrderCreated;      //Event that triggers when an order is created and pushed to the buffer 
        
        public static Random rand = new Random();
        Airline airline = new Airline();
        public void travelFunc()
        {
            //Continue creating and processing orders while there are less than 20 price cuts.
            while(airline.getPCuts() < airline.getP())
            {
                Thread.Sleep(rand.Next(500, 2000)); //Sleep the thread

                int price = airline.getPrice();
                string receiverId = (Program.orderCount++).ToString();
                createOrderObject(Thread.CurrentThread.Name, price, receiverId);

                //Show the current ticket price and the seller
                Console.WriteLine("TICKETS AVAILABLE!!!");
                Console.WriteLine("Travel Agency {0} has everyday low price: ${1} each\n\n\n", Thread.CurrentThread.Name, price);
            }
        }

        public void createOrderObject(string threadId, int price, string receiver)  //Create an order object 
        {
            //Order object needs the following:
            //senderId
            //cardNo
            //receiverId
            //amount
            //unit price

            string senderId = threadId;             //SenderId is the thread name of the travel agency
            int cardNo = rand.Next(1000, 9999);     //creates a random card number. If the card # is between 2000 and 9000 it is valid. 
            string receiverId = receiver;           //ReceiverId customer number or the ordercount number that is initialized in Program.cs
            int amount = rand.Next(1, 10);          //Generates a random number of tickets the buyer will buy.
            int unitPrice = price;                  //Unit price is the current ticket price 

            //generate an order object
            OrderObject order = new OrderObject(senderId, cardNo, receiverId, amount, unitPrice);

            //take the order object and put it in the multi cell buffer
            Program.orderBuffer.setBuffer(order);
            newOrderCreated(order.getRecieverId());                      //Trigger the order created event so that processing can begin
        }

        public void ticketsOnSale(int price)
        {
            //Method that is the result of a price reduction event. Prints out the new price and number of price cuts
            Console.WriteLine("PRICED REDUCED!!!!!");
            Console.WriteLine("{0} has plane tickets that are on sale: as low as ${1} each", airline.getThreadName(), price);
            Console.WriteLine("Total Price Cuts = {0}\n\n", airline.getPCuts() + 1);
        }

        public void ticketPriceIncrease(int price)
        {
            //Method that is the result of a price increase event. Prints out the new price
            Console.WriteLine("PRICE INCREASE!!!!!");
            Console.WriteLine("{0} has plane tickets that are on sale: as low as ${1} each\n\n", airline.getThreadName(), price);
        }



        public void orderProcessed(OrderObject order)
        {
            // write to console all details of the order that has processed.
            Console.WriteLine("\t\t\t##########   ORDER PROCESSED FOR CUSTOMER #{0}   ###########", order.getRecieverId());
            Console.WriteLine("\t\t\tTravel Agency {0} has processed the order for customer {1}. \n\t\t\t\tTicket Price = ${2}.\n\t\t\t\tAmount Ordered = {3}. \n\t\t\t\tTotal Cost = ${4}",
                order.getSenderId(), 
                order.getRecieverId(), 
                order.getUnitPrice(), 
                order.getAmount(), 
                (order.getAmount() * order.getUnitPrice()));
            Console.WriteLine("\t\t\t###########################################################\n\n");

        }

        public void orderFailed(int cardNo)
        {
            // write to console all details of the order that has processed.
            Console.WriteLine("\t\t\t##########   ORDER FAILED   ###########");
            Console.WriteLine("\t\t\t\tCard Number: {0} is invalid \n\n", cardNo);

        }

    }
}
