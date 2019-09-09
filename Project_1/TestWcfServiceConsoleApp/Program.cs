using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWcfServiceConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            myServiceRef.Service1Client myPxy = new myServiceRef.Service1Client();
            String str = myPxy.Hello();
            double pi = myPxy.PiValue();
            int test1 = -27;
            int result1 = myPxy.absValue(test1);
            int temp = myPxy.c2f(100);
            Console.WriteLine("Hello returns {0}", str);
            Console.WriteLine("PI value =  {0}", pi);
            Console.WriteLine("Absolute value =  {0}", result1);
            Console.WriteLine("Temperature =  {0}", temp);
            myPxy.Close();

        }
    }
}
