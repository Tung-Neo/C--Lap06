using System;

namespace Snippet_5
{
    interface IAnimal
    {
        void Habitat();
    }
    class Dog : IAnimal
    {
        public void Habitat()
        {
            Console.WriteLine("Can be housed with human beings");
        }
    }
}
