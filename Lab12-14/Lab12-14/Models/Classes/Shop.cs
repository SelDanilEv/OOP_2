using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_14.Classes
{
    public class Shop
    {
        public Shop()
        {
        }

        public Shop(string name, List<Stock> products)
        {
            Name = name;
            this.products = products;
        }
        

        public int Id { get; set; }
        public String Name { get; set; }
        public List<Stock> products { get; set; }
    }
}
