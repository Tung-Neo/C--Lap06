using System;
using System.Collections.Generic;
using System.Text;

namespace Snippet_5
{
    class University
    {
        private static string department;
        private static string universityName;
        public static string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }
        public static string UniversityName
        {
            get
            {
                return universityName;
            }
            set
            {
                department = value;
            }
        }
    }
}
