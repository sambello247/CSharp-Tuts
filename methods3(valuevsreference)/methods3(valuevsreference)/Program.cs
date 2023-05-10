using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods3_valuevsreference_
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstEmployee, secondEmployee;

            firstEmployee = "David Smith";
            secondEmployee = "Sophia Watson";

            Console.WriteLine($"Inside Main Methods \n-------------\n{firstEmployee} \n{secondEmployee} \n\n");

            ChangeNamesByValue(firstEmployee, secondEmployee);
            ChangeNamesByRef(ref firstEmployee, ref secondEmployee);


            //This is where the pass by value or reference is being affected.
            Console.WriteLine($"Inside Main Method \n----------------\n{firstEmployee} \n{secondEmployee}\n\n");

        }

        static void ChangeNamesByRef(  ref string firstEmp,  ref string secEmp)
        {
            //
            firstEmp = "Olivia Aaron";
            secEmp = "Alvaro Salazar";
            Console.WriteLine($"Outside Main Method by Ref \n---------------- \n{firstEmp} \n{secEmp} \n\n");
        }

        static void ChangeNamesByValue( string firstEmp, string secEmp)
        {
            firstEmp = "Olivia Aaron";
            secEmp = "Alvaro Salazar";
            Console.WriteLine($"Outside Main Method by Value \n---------------- \n{firstEmp} \n{secEmp} \n\n");
        }

    }
}
