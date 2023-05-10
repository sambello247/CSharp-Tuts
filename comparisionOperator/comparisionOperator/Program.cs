using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comparisionOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;

            x = 5; y = 7;

            if (x == y)
                Console.WriteLine("X is equal to Y");
            else if (x != y) { 
                //Nested If
                if (x > y)
                    Console.WriteLine("X is greater than Y");
                else if (x < y)
                    Console.WriteLine("X is less than Y");
            }
        }
    }
}
