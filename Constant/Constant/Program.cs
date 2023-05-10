using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constant
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constant variable can not be updated.
            const double gravityForce = 9.8;
            double PI = 3.14159265359;

            Console.WriteLine("Gravity Force is " + gravityForce + " and PI is " + PI);
        }
    }
}
