using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataTypeInDepth
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            x = int.MinValue;
            Console.WriteLine(x);

            uint y = uint.MinValue;
            Console.WriteLine(y);

            Console.WriteLine("Int is primitive:" + typeof(int).IsPrimitive + "\n");

            Console.WriteLine("Float is primitive:" + typeof(float).IsPrimitive + "\n");

            Console.WriteLine("Double is primitive:" + typeof(double).IsPrimitive + "\n");

            Console.WriteLine("Bollean is primitive:" + typeof(bool).IsPrimitive + "\n");

            Console.WriteLine("Decimal is primitive:" + typeof(decimal).IsPrimitive + "\n");

            Console.WriteLine("String is primitive:" + typeof(string).IsPrimitive + "\n");

        }
    }
}
