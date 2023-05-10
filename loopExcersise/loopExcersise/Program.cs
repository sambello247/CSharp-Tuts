using System;

namespace loopExcersise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Even Numberss
            Console.WriteLine("Even Numbers");

            for (int i = 2; i <= 100; i+=2)
            {
                Console.Write( i + ", ");
            }

            Console.WriteLine();




            Console.WriteLine("Binary Triangle");

            for (int y = 0; y <= 10; y++)
            {
                

                for (int x = 0; x <= y; x++)
                {
                    Console.Write("0");
                }

                Console.WriteLine();
            }
        }
    }
}
