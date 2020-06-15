using System;

namespace Snippet_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Product objProduct = new Product("Hard Disk", 101);
            objProduct.Price = 354.25F;
            objProduct.Display();
        }
    }
}
