using System;

namespace assignment4
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 10; i >= 0; i--)
            {
                //Console.WriteLine("First loop i = " + i);

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("0 ");
                    //Console.WriteLine("Second loop j = " + j);
                }

                Console.WriteLine();
            }

        }
    }
}
