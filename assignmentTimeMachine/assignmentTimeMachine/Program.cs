﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentTimeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Enter the day");
            int day = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the month");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the year");
            int year = int.Parse(Console.ReadLine());


            DateTime birthday = new DateTime(year, month, day);


            Console.WriteLine("This day should be {0:dddd }", birthday);
        }
    }
}
