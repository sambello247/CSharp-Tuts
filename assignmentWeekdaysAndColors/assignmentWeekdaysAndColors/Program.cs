using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentWeekdaysAndColors
{
    class Program
    {
        static void Main(string[] args)
        {

            //Assignment Not Completed as the question is not clear

            DateTime todayDate = DateTime.Today;

            Console.WriteLine(todayDate.Day);

            


            Console.WriteLine("Choose a Day 1-7");

            int inputDay = int.Parse(Console.ReadLine());

            

            switch (inputDay)
            {
                case 1:
                    Console.WriteLine("{0:dddd}: Green", todayDate);
                    break;

                case 2:
                    Console.WriteLine("{0:dddd}: Blue", todayDate);
                    break;

                case 3:
                    Console.WriteLine("{0:dddd}: Gray", todayDate);
                    break;

                case 4:
                    Console.WriteLine("{0:dddd}: Red", todayDate);
                    break;

                case 5:
                    Console.WriteLine("{0:dddd}: Orange", todayDate);
                    break;

                case 6:
                    Console.WriteLine("{0:dddd} White", todayDate);
                    break;

                case 7:
                    Console.WriteLine("{0:dddd} Yellow", todayDate);
                    break;
            }
        }
    }
}
