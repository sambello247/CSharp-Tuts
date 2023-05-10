using System;

namespace math1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3.9;
            //Ceiling
            Console.WriteLine("Ceiling : " + Math.Ceiling(x));

            //Floor
            Console.WriteLine("Floor : " + Math.Floor(x));

            //Round
            Console.WriteLine("Round : " + Math.Round(x));

            //Truncate
            Console.WriteLine("Truncate : " + Math.Truncate(x));
        }
    }
}
