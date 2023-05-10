using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope
{
    class Dogs
    {

        //The scope of the variable is global and it will be accessible globally.

        string dogBreed;
        string dogName;
        string dogColor;
       

        public void trainDog()
        {
            //The scope of the variable is local and it will only be accessible in this function.
            string trainerName;
            trainerName = "Daniel";
        }

        public void feedDog()
        {
            string foodName;
   
        }
    }
}
