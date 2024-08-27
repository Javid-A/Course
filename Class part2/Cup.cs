using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_part2
{
    internal class Cup : Product
    {
        public string Name = null!;
        public double Price;

        public Cup(int id, string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
