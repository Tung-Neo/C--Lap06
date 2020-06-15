using System;
using System.Collections.Generic;
using System.Text;

namespace Snippet_14
{
    class Student
    {
        string[] studName = new string[2];
        public virtual string this[int index]
        {
            get
            {
                return studName[index];
            }
            set
            {
                studName[index] = value;
            }
        }
    }
    class Resutl : Student
    {
        string[] resutl = new string[2];
        public override string this[int index]
        {
            get
            {
                return base[index];
            }
            set
            {
                base[index] = value;
            }
        }
    }
}
