using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class OrderObject
    {
        //Order object class contains all information required to complete an order
        private string senderId;
        private int cardNo;
        private string receiverId;
        private int amount;
        private int unitPrice;

        public OrderObject(string senderId, int cardNo, string receiverId, int amount, int unitPrice)
        {
            this.senderId = senderId;
            this.cardNo = cardNo;
            this.receiverId = receiverId;
            this.amount = amount;
            this.unitPrice = unitPrice;
        }


        //Getter methods
        public string getSenderId()
        {
            return senderId;
        }

        public int getCardNo()
        {
            return cardNo;
        }

        public string getRecieverId()
        {
            return receiverId;
        }

        public int getAmount()
        {
            return amount;
        }

        public int getUnitPrice()
        {
            return unitPrice;
        }
    }
}
