using System;
using System.Collections.Generic;
using System.Text;

namespace Snippet_15
{
    class Acount
    {
        string[,] accountDetalis = new string[4, 2];
        public string this[int pos, int column]
        {
            get
            {
                return (accountDetalis[pos, column]);
            }
            set
            {
                accountDetalis[pos, column] = value;
            }
        }
    }
}
