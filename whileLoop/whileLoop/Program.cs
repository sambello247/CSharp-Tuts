using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            while(x <= 10)
            {
                Console.WriteLine("This is line no. {0}", x);
                x++;
            }
        }
    }
}
