using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope
{
    class Program
    {
        //The scope of the variable is global and it will be accessible globally.
        //For the globall variable to work in static methods it has to have the static keyword preceeds the declaration.

        static string name = "Daniel";
        static void Main(string[] args)
        {
            sayHI();
        }

        static void sayHI()
        {
            name = "Sam";
            Console.WriteLine("Hi, " + name);
        }
    }
}
