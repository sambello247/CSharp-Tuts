using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    class Program
    {
        static void Main(string[] args)
        {
            Person perOne = new Person();
            perOne.FirstName = "Sam";
            perOne.LastName = "Bello";
            perOne.Country = "Nigeria";

            Person perTwo = new Person();
            perTwo.FirstName = "Teejay";
            perTwo.LastName = "Bello";
            perTwo.Country = "Canada";

            Console.WriteLine(perOne.FirstName);
            Console.WriteLine(perTwo.FirstName);



        }
    }

    class Person
    {
        string firstName;
        string lastName;
        DateTime birthDate;
        string country;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public DateTime BirthDate { get; set; }

        public string Country { get; set; }

    }
}
