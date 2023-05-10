using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cunstructors
{

    
    class Program
    {

      
    }

    // Create a Car class
    class Car
    {

        /* 
         * A constructor is a special method that has the same name with class it is used to initialize objects. The advantage of a constructor, is that it is called when an object of a class is created. It can be used to set initial values for fields:

         * 
         
        */


        public string model;  // Create a field

        // Create a class constructor for the Car class
        public Car() //Same name with its class.
        {
            model = "Mustang"; // Set the initial value for model
        }

        static void Main(string[] args)
        {
            Car Ford = new Car();  // Create an object of the Car Class (this will call the constructor)
            Console.WriteLine(Ford.model);  // Print the value of model
        }
    }

    // Outputs "Mustang"
}
