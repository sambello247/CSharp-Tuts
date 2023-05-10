using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arithmeticOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 6;
            int y = 2;
            int resultAdd, resultSubtract, resultMultiply, resultDivide, resultModulus;

            resultAdd = x + y;
            resultSubtract = x - y;
            resultMultiply = x * y;
            resultDivide = x / y;
            resultModulus = x % y;

            Console.WriteLine("Add: " + resultAdd);
            Console.WriteLine("Subtract: " + resultSubtract);
            Console.WriteLine("Multiply: " + resultMultiply);
            Console.WriteLine("Divide: " + resultDivide);
            Console.WriteLine("Remainder: " + resultModulus);
        }
    }
}
