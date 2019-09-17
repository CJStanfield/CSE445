using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Project_2
{
    public delegate void priceCutEvent(Int32 pr); //define a delegate
    public class ChickenFarm
    {
        static Random rng = new Random();
        public static event priceCutEvent priceCut;
        private static Int32 chickenPrice = 10;
        public Int32 getPrice() { return chickenPrice; }
        public static void changePrice (Int32 price)
        {
            if(price < chickenPrice)
            {
                if (priceCut != null)
                {
                    priceCut(price);
                }
                chickenPrice = price;
            }
        }

        public void farmerFunc()
        {
            for(Int32 i = 0; i < 50; i++)
            {
                Thread.Sleep(500);
                Int32 p = rng.Next(5, 10);
                Console.WriteLine("new price is {0}", p);
                ChickenFarm.changePrice(p);
            }
        }
    }

    public class Retailer
    {
        public void retailerFunc()
        {
            ChickenFarm chicken = new ChickenFarm();
            for (Int32 i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Int32 p = chicken.getPrice();
                Console.WriteLine("Store{0} has everyday low price: ${1} each", Thread.CurrentThread.Name, p); //prints the name

            }
        }

        public void chickenOnSale(Int32 p)
        {
            //Order chickens from chicken farm - send order into queue
            Console.WriteLine("Store{0} chickens are on sale: as low as ${1} each", Thread.CurrentThread.Name, p);
        }

    }

    public class myApplication
    {
        static void Main(string[] args)
        {
            ChickenFarm chicken = new ChickenFarm();
            Thread farmer = new Thread(new ThreadStart(chicken.farmerFunc));
            farmer.Start();         //Start one farmer thread
            Retailer chickenstore = new Retailer();
            ChickenFarm.priceCut += new priceCutEvent(chickenstore.chickenOnSale);
            Thread[] retailers = new Thread[3];
            for (Int32 i = 0; i < 3; i++)
            {
                //Start N retailer threads
                retailers[i] = new Thread(new ThreadStart(chickenstore.retailerFunc));
                retailers[i].Name = (i + 1).ToString();
                retailers[i].Start();
            }
        }
    }

}
