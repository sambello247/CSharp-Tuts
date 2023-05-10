using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleMethodExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            getName();
        }
        static void getName()
        {
            string name = Console.ReadLine();
            sayHi(name);

        }

        static void sayHi( string name)
        {
            Console.WriteLine($"Welcome back, {name}");

        }

    }
}
