using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_14.Classes
{
    public class Stock
    {
        public Stock()
        {
        }

        public Stock(Product product, int quantity)
        {
            Product = product;
            this.quantity = quantity;
        }

        public int Id { get; set; }
        public Product Product { get; set; }
        public int quantity { get; set; }

        [NotMapped]
        public string Name { get => Product.Name; set => Product.Name = value; }
        [NotMapped]
        public double cost { get => Product.cost; set => Product.cost = value; }
    }
}
