using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 10; i++)
            {
                //Console.WriteLine("First loop i = " + i);

                for(int j = 1; j<=10; j++)
                {
                    Console.Write("0 ");
                    //Console.WriteLine("Second loop j = " + j);
                }

                Console.WriteLine();
            }
        }
    }
}
