using System;

namespace Snippet_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle objRectangle = new Rectangle(10.2F, 20.3F);
            if(objRectangle is ICalculate)
            {
                Console.WriteLine("Area of rectangle: {0:F2}", objRectangle.Area());
            }
            else
            {
                Console.WriteLine("Interface method not imlemented");
            }
        }
    }
}
