using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i >= 0; i--)
            {

                if (i == 2)
                    break; //Break when loop reaches 2
                Console.WriteLine("C# Rocks {0}", i);

            }
        }
    }
}
