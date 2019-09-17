using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_business
{
    public class OrderProcessing
    {
        public void processOrderFunc(int cardNum)
        {
            if (cardNum > 5000 && cardNum < 9000) { Console.WriteLine("Credit Card approved"); }
            else { Console.WriteLine("Credit Card NOT approved"); }
        }
    }
}
