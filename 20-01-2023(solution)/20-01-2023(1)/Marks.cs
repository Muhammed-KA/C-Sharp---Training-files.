using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_01_2023_1_
{
    internal class Marks
    {
        public string Name { get; set; }
        public int Mark1 { get; set; }
        public int Mark2 { get; set; }
        public int TotalMark { get { return Mark1 + Mark2; } }

        public override string ToString()
        {
            return $"Name:-{Name} \nMark1:-{Mark1} \nMark2:-{Mark2} \nToatal Marks:-{TotalMark}";
        }
    }
}
