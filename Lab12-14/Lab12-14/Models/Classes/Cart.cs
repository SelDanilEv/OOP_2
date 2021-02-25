using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_14.Classes
{
    public class Cart
    {
        public Cart()
        {
        }

        public Cart(Shop shop, string CartName, double sum, List<Stock> products)
        {
            this.shop = shop;
            this.CartName = CartName;
            this.sum = sum;
            this.products = products;
        }

        
        public int Id { get; set; }
        public Shop shop { get; set; }
        public string CartName { get; set; }
        public double sum { get; set; }
        public List<Stock> products { get; set; }
    }
}
