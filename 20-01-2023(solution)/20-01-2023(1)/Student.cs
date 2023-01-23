using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace _20_01_2023_1_
{
    internal class Student
    {
        public string Name { get; set; }
        private int _age;
        public int Age
        {
            get { return _age; }
            set {
                if (value >= 0 && value <= 100)
                {
                    _age = value;
                }
            }
        }
        
        public  void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}" );
        }
    }
}
