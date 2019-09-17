using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace e_business
{
    public class Airline
    {
        private static int ticketPrice;
        public int getPrice() { return ticketPrice; }
        public void airlineFunc()
        {
            ticketPrice = pricingModel();

            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(500);
            }
        }

        public int pricingModel()
        {
            Random rand = new Random();
            return rand.Next(50, 200);
        }

        public static void changePrice(int price)
        {
            ticketPrice = price;
        }
    }
}
