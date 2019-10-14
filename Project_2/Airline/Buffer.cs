using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Assignment_2
{
    public class Buffer
    {
        //Semaphores that limit the number of threads that can access the buffer
        private Semaphore write;
        private Semaphore read;
        private static int count = 0;       //count keeps track of how many orders are currently in the buffer.
        private static int N = 2; //Size of the multicell buffer for individual project
        public static OrderObject[] bufferOrders = new OrderObject[N];      //Buffer consists of order objects. Order objects defined in OrderObjects.cs

        public Buffer(Semaphore read, Semaphore write)
        {
            this.read = read;       //read and write semaphores passed in from Program.cs. Should have 2 read and 2 write 
            this.write = write;
            lock (bufferOrders)
            {
                for (int i = 0; i < N; i++)
                {
                    bufferOrders[i] = null;             //initialize all bufferOrders to null.
                }
            }
        }

        //setBuffer takes an order and adds it to the buffer.
        public void setBuffer(OrderObject order)
        {
            write.WaitOne();
            lock (bufferOrders)
            {
                while (count >= N)      //Wait until there is a spot available in the buffer. 
                {
                    Monitor.Wait(bufferOrders);
                }
                for (int i = 0; i < N; i++)
                {   
                    if (bufferOrders[i] == null)        //Find the empty spot in the buffer and assign it to the order
                    {
                        bufferOrders[i] = order;
                        count++;
                        break;
                    }
                }
                write.Release();            //Release the semaphore
                Monitor.Pulse(bufferOrders);        //Notify other threads
            }
        }

        public OrderObject getBuffer()
        {
            read.WaitOne();
            OrderObject order = null;
            lock (bufferOrders)
            {
                while (count <= 0)          //Wait while there are no orders in the buffer.
                {
                    Monitor.Wait(bufferOrders);     
                }
                for (int i = 0; i < N; i++)         //Find the order that is not null in the buffer and return it for order processing
                {
                    if (bufferOrders[i] != null)
                    {

                        order = bufferOrders[i];        //Get the order and set that index in the buffer equal to null
                        bufferOrders[i] = null;
                        count--;
                        break;
                    }
                }
                read.Release();              //Release the semaphore
                Monitor.Pulse(bufferOrders);        //Notify other threads
            }

            return order;
        }
    }
}
