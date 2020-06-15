using System;
using System.Collections.Generic;
using System.Text;

namespace Snippet_8
{
    interface IAnimal
    {
        void Drink();
    }
    interface ICarnivorous
    {
        void Eat();
    }
    interface IReptile : IAnimal, ICarnivorous
    {
        void Habitat();
    }
    class Crocidile : IReptile
    {
        public void Drink()
        {
            Console.WriteLine("Drink fresh water");
        }
        public void Habitat()
        {
            Console.WriteLine("Can stay in Water and Land");
        }
        public void Eat()
        {
            Console.WriteLine("Eats Flesh");
        }
    }
}
