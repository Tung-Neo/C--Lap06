using System;
using System.Collections.Generic;
using System.Text;

namespace Snippet_7
{
    interface ITerrestrialAnimal
    {
        string Eat();
    }
    interface IMarineAnimal
    {
        string Eat();
    }
    class Crocodile : ITerrestrialAnimal, IMarineAnimal
    {
        string ITerrestrialAnimal.Eat()
        {
            string terCroc = "Crocodile eats other animal";
            return terCroc;
        }
        string IMarineAnimal.Eat()
        {
            string marCroc = "Crocodile eats fish and marine animals";
            return marCroc;
        }
        public string EatTerrestrial()
        {
            ITerrestrialAnimal objTerAnimal;
            objTerAnimal = this;
            return objTerAnimal.Eat();
        }
        public string EatMarine()
        {
            IMarineAnimal objMarAnimal;
            objMarAnimal = this;
            return objMarAnimal.Eat();
        }
    }
}
