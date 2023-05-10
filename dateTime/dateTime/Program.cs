using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime myDate = new DateTime(); //New date object
            //DateTime myDate = DateTime.Today; //Todays date without time

            DateTime myDate = DateTime.Now; //Todays date with time
            Console.WriteLine(myDate.ToShortDateString()); //Short Date string
            Console.WriteLine(myDate.ToLongDateString()); // Long Date string
            Console.WriteLine(myDate.AddDays(5)); // Add days to the current date
            Console.WriteLine(myDate.AddYears(2)); // Add years to the current year

            string formattedDate = string.Format("Date is {0:yyyy, MMMM dddd HH mm ss tt}", myDate);

            Console.WriteLine(formattedDate);



        }
    } 
}
