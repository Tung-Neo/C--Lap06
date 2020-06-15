using System;

namespace Snippet_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Crocodile objCrocodile = new Crocodile();
            string terCroc = objCrocodile.EatTerrestrial();
            Console.WriteLine(terCroc);
            string marCroc = objCrocodile.EatMarine();
            Console.WriteLine(marCroc);
        }
    }
}
