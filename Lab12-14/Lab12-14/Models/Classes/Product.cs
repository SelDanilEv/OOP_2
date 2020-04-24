using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_14.Classes
{
    public class Product
    {
        public Product()
        {
        }

        public Product( string name, double cost)
        {
            Name = name;
            this.cost = cost;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double cost { get; set; }
    }
}
