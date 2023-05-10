using System;

namespace assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int x = rand.Next(1, 13);
            string monthName = "";

        
            switch (x)
            {
                case 1:
                    monthName = "January - 31 days";
                    break;
                case 2:
                    monthName = "February - 28/29 days";
                    break;
                case 3:
                    monthName = "March - 31 days";
                    break;
                case 4:
                    monthName = "April - 30 days";
                    break;
                case 5:
                    monthName = "May - 31 days";
                    break;
                case 6:
                    monthName = "June - 30 days";
                    break;
                case 7:
                    monthName = "July - 31 days";
                    break;
                case 8:
                    monthName = "August - 31 days";
                    break;
                case 9:
                    monthName = "September - 30 days";
                    break;
                case 10:
                    monthName = "October - 31 days";
                    break;
                case 11:
                    monthName = "November - 30 days";
                    break;
                case 12:
                    monthName = "December - 31 days";
                    break;


            }

            Console.WriteLine(monthName);
        }
    }
}
