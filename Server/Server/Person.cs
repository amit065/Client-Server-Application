using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Person
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }


        public Person(string first, string second, string last)
        {
            FirstName = first;
            MiddleName = second;
            LastName = last;
        }
    }
}
