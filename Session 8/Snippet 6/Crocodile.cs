using System;
using System.Collections.Generic;
using System.Text;

namespace Snippet_6
{
    interface ITerrestrialAnimal
    {
        void Eat();
    }
    interface IMarineAnimal
    {
        void Swim();
    }
    class Crocodile : ITerrestrialAnimal, IMarineAnimal
    {
        public void Eat()
        {
            Console.WriteLine("The Crocdile eats flesh");
        }
        public void Swim()
        {
            Console.WriteLine("The Crocodile can swim four times faster than an Olympic swimmer");
        }
    }
}
