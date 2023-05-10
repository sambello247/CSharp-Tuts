using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5] { 1, 10, 100, 1000, 10000 };
            //numbers[0] = 1;
            //numbers[1] = 10;
            //numbers[2] = 100;

            Console.WriteLine(numbers);

            //Display all array value with a loop
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }


            //string[] weekDays = new string[7] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };


            //Console.WriteLine(weekDays[1]);

            //Display all array value with a loop
            //for (int j = 0; j < weekDays.Length; j++)
            //{
            //    Console.WriteLine(weekDays[j]);
            //}



            string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            //Display all array value with a loop
            //for (int j = 0; j < weekDays.Length; j++)
            //{
            //    Console.WriteLine(weekDays[j]);
            //}

            foreach (string weekDay in weekDays)
            {
                Console.WriteLine(weekDay);
            }

        }
    }
}
