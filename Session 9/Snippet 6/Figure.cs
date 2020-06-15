using System;
using System.Collections.Generic;
using System.Text;

namespace Snippet_6
{
    public abstract class Figure
    {
        public abstract float DimensionOne
        {
            set;
        }
        public abstract float DimensionTwo
        {
            set;
        }
    }
    class Rectangle : Figure
    {
        float dimensionOne;
        float dimensionTwo;
        public override float DimensionOne
        {
            set
            {
                if(value <= 0)
                {
                    dimensionOne = 0;
                }
                else
                {
                    dimensionOne = value;
                }
            }
        }
        public override float DimensionTwo
        {
            set
            {
                if(value <= 0)
                {
                    dimensionTwo = 0;
                }
                else
                {
                    dimensionTwo = value;
                }
            }
        }
        float Area()
        {
            return dimensionOne * dimensionTwo;
        }
        static void Main(string[] args)
        {
            Rectangle objRec = new Rectangle();
            objRec.DimensionOne = 20;
            objRec.DimensionTwo = 4.233F;
            Console.WriteLine("Area of Rectangle: " + objRec.Area());
        }
    }
}
