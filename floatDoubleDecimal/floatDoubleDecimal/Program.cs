using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace floatDoubleDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            float fNo = 0.0f;   // Size: 4bytes. 
            double dNo = 0.0d;  // Size: 8bytes. 
            decimal mNo = 0.0m; // Size: 16bytes.  

            fNo = 1 / 3f; // Precision: 7 digits
            dNo = 1 / 3d; // Precision: 15-16 digits
            mNo = 1 / 3m; // Precision: 2829 decimal places


            Console.WriteLine("Float no is {0}", fNo);
            Console.WriteLine("Double no is {0}", dNo);
            Console.WriteLine("Decimal no is {0}", mNo);

        }
    }
}
