using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
    class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public override string ToString()
        {
            return string.Format("Name: {0}\nAge: {1}", name, age);
        }
    }
}
