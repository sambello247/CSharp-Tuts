using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    /*
     * In C#, it is possible to inherit fields and methods from one class to another. We group the "inheritance concept" into two categories:

            Derived Class (child) - the class that inherits from another class
            Base Class (parent) - the class being inherited from

       To inherit from a class, use the : symbol.
     
     */
    class Program
    {
        static void Main(string[] args)
        {
            Dogs dogOne = new Dogs();
            dogOne.dogBreed = "German Shepard"; // The class field was inherited from animal.
            
        }
    }

    //This is the base class
    class Animal
    {
        string animalName;
        DateTime animalBirthDate;

        public void FeedAnimal()
        {

        }

    }

    //This is the derived class
    class Dogs : Animal //Dog inherits from Animal using the : symbol;
    {
        public string dogBreed;
        public string dogIntelligence;
        public bool isEasyToTrain;

    }

    class Brids : Animal //Dog inherits from Animal using the : symbol;
    {
        public string birdColor;
        public string birdCountry;

    }
}
