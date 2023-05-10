using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            int addResult = 0;

            a = 5;
            b = 3;

            addResult = performAddOperation(a, b);
            Console.WriteLine($"{a} + {b} = {addResult}");
            displayMessage();



            c = 15;
            d = 10;
            addResult = performAddOperation(c, d);
            Console.WriteLine($"{c} + {d} = {addResult}");
            displayMessage();


        }

        static int performAddOperation(int x, int y)
        {
            int addResult = 0;
            addResult = x + y;
            return addResult;
        }

        static void displayMessage()
        {
            Console.WriteLine("Process is done");
            Console.WriteLine("This process is run by SamBello");
            Console.WriteLine("Run Time:" + DateTime.Now.ToShortTimeString());
        }
    }
}
