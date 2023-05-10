using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moethods4_overloadedMethods_
{
    class Program
    {
        static void Main(string[] args)
        {
            string guestName = "";
            Console.WriteLine("Hello, Dear Guest, What is your name?");
            guestName = Console.ReadLine();

            if (guestName == string.Empty)
            {
                WelcomeGuest();
            }
            else
            {
                WelcomeGuest(guestName);
            }
        }


        static void WelcomeGuest()
        {
            Console.WriteLine("Okay, we hope you enjoy staying at our hotel");
        }

        static void WelcomeGuest(string guestName)
        {
            Console.WriteLine($"Thank you {guestName}, we hope you enjoy staying at our hotel");
        }
    }
}
