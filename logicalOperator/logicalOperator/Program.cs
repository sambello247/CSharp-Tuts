using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // AND Operator
            bool hasLicence = true;
            bool knowHowToDrive = false;

            if (hasLicence && knowHowToDrive)
            {
                Console.WriteLine("You are good to go");
            }
            else if (hasLicence == true && knowHowToDrive == false)
            {
                Console.WriteLine("Cheater!!!");
            }

            else if (hasLicence == false && knowHowToDrive == true)
            {
                Console.WriteLine("You need to get a licence");
            }
            else
            {
                Console.WriteLine("This is not gonna happen");
            }

            //OR Operator
            bool wentForSwim = false;
            bool tookAShower = false;

            if (!wentForSwim || tookAShower)
            {
                Console.WriteLine("Pal you are so wet");
            }
            else
            {
                Console.WriteLine("You are not wet");
            }

        }
    }
}
