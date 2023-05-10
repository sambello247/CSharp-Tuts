using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentFrendlyConversationWithCsharp
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime cSharpAge = new DateTime(2002, 3, 1, 7, 0, 0);
            DateTime todayDate =  DateTime.Now;

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Nice meeting you {0}, My name is C#, How old are you? ", name);
            

            try
            {
                int age = int.Parse(Console.ReadLine());

                int cSharpYears = todayDate.Year - cSharpAge.Year;

                Console.WriteLine("{0} good, As for me i was born on {1: yyyy} which makes me {2} years old", age, cSharpAge, cSharpYears);
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Input");
            }

           

           

        }
    }
}
