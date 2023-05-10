using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arithmeticOperationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //5 + 2 = 7
            //5 - 2 = 3
            //5 * 2 = 10
            //5 / 2 = 2.5
            //5 % 2 = 1

            decimal x, y;
            decimal addResult, subtractResult, multiplicationResult, divisionResult, remainderResult;

            Console.WriteLine("Enter the first Value:");
            x = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the second Value:");
            y = Convert.ToDecimal(Console.ReadLine());

            addResult = x + y;
            subtractResult = x - y;
            multiplicationResult = x * y;
            divisionResult = x / y;
            remainderResult = x % y;

            Console.WriteLine(x + " + " + y + " = " + addResult);
            Console.WriteLine(x + " - " + y + " = " + subtractResult);
            Console.WriteLine(x + " * " + y + " = " + multiplicationResult);
            Console.WriteLine(x + " / " + y + " = " + divisionResult);
            Console.WriteLine(x + " % " + y + " = " + remainderResult);

        }
    }
}
