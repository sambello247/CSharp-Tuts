using System;

namespace methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            int addResult = 0;

            a = 5;
            b = 3;

            performAddOperation(a,b);



            c = 15;
            d = 10;
            performAddOperation(c, d);


        }

        static void performAddOperation(int x, int y)
        {
            int addResult = 0;
            addResult = x + y;
            Console.WriteLine($"{x} + {y} = {addResult}");
            displayMessage();

        }

        static void displayMessage()
        {
            Console.WriteLine("Process is done");
            Console.WriteLine("This process is run by SamBello");
            Console.WriteLine("Run Time:" + DateTime.Now.ToShortTimeString());
        }
    }
}
