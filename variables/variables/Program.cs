using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            Console.WriteLine("Number X is " + x);
            x = 5;
            Console.WriteLine("Number X is " + x);

            double doubleNum = 0.0d;
            float floatNum = 0.0f;
            decimal decimalNum = 0.0m;

            doubleNum = 9.8;
            floatNum = 5.5f;
            decimalNum = 100.250m;

            Console.WriteLine("Double is " + doubleNum + " Float is " + floatNum + " Decimal is " + decimalNum);

            string firstName = "Sam";
            string lastName = "Bello";

            Console.WriteLine("Hello " + firstName + " " + lastName);





        }
    }
}
