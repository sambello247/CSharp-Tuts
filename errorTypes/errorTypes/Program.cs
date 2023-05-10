using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace errorTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 0;
            b = 1;
            c = 0;

            //a = ""; //Syntax Error

            c = b / a; // Runtime or Exception Errror. Can not divid by zero.

            Console.WriteLine(c);
        }
    }
}
