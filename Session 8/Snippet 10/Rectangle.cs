﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Snippet_10
{
    interface ICalculate
    {
        double Area();
    }
    class Rectangle : ICalculate
    {
        float length;
        float breadth;
        public Rectangle (float valOne, float valTwo)
        {
            length = valOne;
            breadth = valTwo;
        }
        public double Area()
        {
            return length * breadth;
        }
    }
}
