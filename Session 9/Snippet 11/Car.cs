using System;
using System.Collections.Generic;
using System.Text;

namespace Snippet_11
{
    class Car
    {
        string carType;
        public virtual string CarType
        {
            get
            {
                return carType;
            }
            set
            {
                carType = value;
            }
        }
    }
    class Ferrari : Car
    {
        string carType;
        public override string CarType
        {
            get
            {
                return base.CarType;
            }
            set
            {
                base.CarType = value;
                carType = value;
            }
        }
    }
}
