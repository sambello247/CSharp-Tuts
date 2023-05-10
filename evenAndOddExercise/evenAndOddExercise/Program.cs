using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenAndOddExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //Even Number
            int x = 0;
            x = int.Parse(Console.ReadLine());

            if(x % 2 == 0)
                Console.WriteLine(x + " is even number");
            else
                Console.WriteLine(x + " is an odd number");
        }
    }
}
