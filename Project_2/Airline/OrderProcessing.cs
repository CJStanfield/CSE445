using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class OrderProcessing
    {
        public static event orderProcessedEvent orderProcessed;
        public static event orderFailedEvent orderFailed;

        public static void processOrderFunc(OrderObject order)
        {
            //Compute the total cost of the purchase. 
            int totalCost = order.getUnitPrice() * order.getAmount();

            //Check to make sure card is valid. The program is designed to generate invalid card numbers to show that error checking is working
            int cardNo = order.getCardNo();
            if (cardNo < 1500 || cardNo > 9500)
            {
                //If card is invalid, then display message. Also trigger the orderFailed event.
                Console.WriteLine("ERROR. INVALID CARD NO. {0}.\n PLEASE USE A DIFFERENT CARD\n", cardNo);
                orderFailed(cardNo);
                return;
            }else
            {
                orderProcessed(order);          //Trigger the orderProcessed event if the card number is correct.
            }

        }
    }
}
