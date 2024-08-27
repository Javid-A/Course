using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_part2
{
    internal class Product
    {
        public int Id;
        public DateTime CreatedAt;
        public DateTime ModifiedAt;

        public Product(int id):this()
        {
            Id = id;
        }
        public Product()
        {
            CreatedAt = DateTime.Now;
            ModifiedAt = DateTime.Now;
        }
    }
}
