﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Snippet_4
{
    class Product
    {
        string productName;
        int productID;
        float price;
        public Product(string name, int val)
        {
            productName = name;
            productID = val;
        }
        public float Price
        {
            get
            {
                return price;
            }
            set
            {
                if(value < 0)
                {
                    price = 0;
                }
                else
                {
                    price = value;
                }
            }
        }
        public void Display()
        {
            Console.WriteLine("Product Name: " + productName);
            Console.WriteLine("Product ID: " + productID);
            Console.WriteLine("Price: " + price + "$");
        }
    }
}
