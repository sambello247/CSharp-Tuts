using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateTimeExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //First format: 30-09-2017 01:15:55
            DateTime currentDateTime = DateTime.Now;
            string firstFormat = string.Format("{0:dd-MM-yyyy HH:mm:ss }", currentDateTime);
            
            Console.WriteLine(firstFormat + "\n"); // \n Prints new line

            //Second format: Saturday of month september 2017
            string secondFormat = string.Format("{0:dddd 'of month' MMMM 'year' yyyy}", currentDateTime);

            Console.WriteLine(secondFormat + " \x0A");  // \x0A prints newline

            /*Third Format 
             * Day Saturday
             * Month September
             * Year 2017
             * */

            string thirdFormat = string.Format("{0:'Day' dddd \n'Month' MMMM \n'Year' yyyy}", currentDateTime);

            Console.WriteLine(thirdFormat + "\n"); // \n Prints new line
        }
    }
}
