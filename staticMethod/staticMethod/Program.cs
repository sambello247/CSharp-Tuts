using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticMethod
{
    class Program
    {
         static void Main(string[] args)
        {

            // With static methods i dont need to create an instance of a class, with non-static methods i need to create an instance of a class.



            //Hi From Static Methods
            sayHi();

            //Hi From Non-Static Methods (You can see the instance of the class.)
            Person personOne = new Person();
            personOne.sayHi();
        }

        static void sayHi()
        {
            Console.WriteLine("Hi from static method");
        }
    }


    class Person
    {
        public void sayHi()
        {
            Console.WriteLine("Hi from non-static method");
        }
    }
}
