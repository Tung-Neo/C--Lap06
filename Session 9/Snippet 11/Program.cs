using System;

namespace Snippet_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Car objCar = new Car();
            objCar.CarType = "Utility Vehicle";
            Ferrari objFer = new Ferrari();
            objFer.CarType = "Sports Car";
            Console.WriteLine("Car Type: " + objCar.CarType);
            Console.WriteLine("Ferrari Car Type: " + objFer.CarType);
        }
    }
}
