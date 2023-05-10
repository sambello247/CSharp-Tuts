using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Animals
    {
        // Encapsulation is a concept that binds together the data and methods that manipulate the data, and that keeps both safe from outside inteference and misused.
        // Data hiding or Information Hiding is a Process in which we hide internal data from outside the world.
        // Generally, in c# the encapsulation is used to prevent alteration of code (data) accidentally from the outside functions.

        private string privateVariable; public string publicVariable;
        protected string protectedVariable; internal string InternalVariable;

        private void TrainAnimalPrivate()
        {}
        public void TrainAnimalPublic()
        {}
        protected void TrainAnimalProtected()
        {}
        internal void TrainAnimalInternal()
        {}

    }

    class Dogs : Animals
    {
        Dogs dog = new Dogs();
        
        public void bark()
        {
            //The private field can not be access as it is used to prevent alteration of code (data) accidentally from the outside functions.

            dog.TrainAnimalProtected();
            dog.TrainAnimalPublic();
            dog.TrainAnimalInternal();

           

        }

    }

    class Cats : Animals
    {

    }
}
