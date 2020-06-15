using System;

namespace Snippet_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Crocidile objCrocodile = new Crocidile();
            Console.WriteLine(objCrocodile.GetType().Name);
            objCrocodile.Habitat();
            objCrocodile.Eat();
            objCrocodile.Drink();
        }
    }
}
