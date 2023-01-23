using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_01_2023_3_
{
    internal class Person
    {
        public string Name;
        public int Mark4;

        public void Display() 
        {
            Console.WriteLine($"Name:- {Name}");
            Console.WriteLine($"Mark:- {Mark4}");
        }
    }
}
