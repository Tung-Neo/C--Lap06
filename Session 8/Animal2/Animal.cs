using System;

namespace Snippet_2
{
    abstract class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Every animal eats food in order to survive");
        }
        public abstract void AnimalSound();
    }
    class Lion : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Lion roars");
        }
    }
    class Cat : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Meow Meow");
        }
    }
    class Dog : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Gau Gau");
        }
    }
}
