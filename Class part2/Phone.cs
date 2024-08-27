using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_part2
{
    internal class Phone:Product
    {
        public string Brand;
        public string Model;

        public Phone(int id, string brand, string model):base(id)
        {
            Brand = brand;
            Model = model;
        }
    }
}
