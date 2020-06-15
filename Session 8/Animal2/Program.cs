using System;

namespace Snippet_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion objLion = new Lion();
            objLion.AnimalSound();
            objLion.Eat();

            Cat objCat = new Cat();
            objCat.AnimalSound();
            objCat.Eat();

            Dog objDog = new Dog();
            objDog.AnimalSound();
            objDog.Eat();
        }
    }
}
