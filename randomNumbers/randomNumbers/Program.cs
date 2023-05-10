using System;

namespace randomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int x = 0;

            x = rand.Next(1, 13);
            Console.WriteLine($"Moth : {x}");

            double y = 0;
            y = rand.NextDouble() * 1;
            Console.WriteLine("Random double no is " + y);
        }
    }
}
