using System;

namespace Snippet_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog objDog = new Dog();
            Console.WriteLine(objDog.GetType().Name);
            objDog.Habitat();
        }
    }
}
