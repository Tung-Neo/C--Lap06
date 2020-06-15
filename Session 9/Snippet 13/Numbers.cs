using System;
using System.Collections.Generic;
using System.Text;

namespace Snippet_13
{
    class Numbers
    {
        private int[] num = new int[3];
        public int this[int index]
        {
            get
            {
                return num[index];
            }
            set
            {
                num[index] = value;
            }
        }
    }
    class EvenNumbers : Numbers
    {
        public static void Main()
        {
            EvenNumbers objEven = new EvenNumbers();
            objEven[0] = 0;
            objEven[1] = 2;
            objEven[2] = 4;
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(objEven[i]);
            }
        }
    }
}
