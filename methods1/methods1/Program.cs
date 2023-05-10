using System;

namespace methods1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            int addResult = 0;

            a = 5;
            b = 3;
            addResult = a + b;

            Console.WriteLine($"{a} + {b} = {addResult}");
            


            c = 15;
            d = 10;
            addResult = c + d;

            Console.WriteLine($"{c} + {d} = {addResult}");

            DisplayMessgae();

        }

        static void DisplayMessgae()
        {
            Console.WriteLine("Process is done");
            Console.WriteLine("This process is run by SamBello");
            Console.WriteLine("Run Time:" + DateTime.Now.ToShortTimeString() );
        }
    }
}
