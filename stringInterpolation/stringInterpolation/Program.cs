using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";

            Console.WriteLine("What is your name");
            name = Console.ReadLine();
            Console.WriteLine("Welcome Back {0}", name); // Using Placeholder
            Console.WriteLine("Welcome Back " + name); //Using Concatenation

            Console.WriteLine($"Welcome Back {name}"); //Using String Interpolation

        }
    }
}
