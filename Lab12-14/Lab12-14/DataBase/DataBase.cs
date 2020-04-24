using Lab12_14.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_14.DataBase
{
    class DataBase
    {
        ShopContext shopC = new ShopContext();

        public Shop GetShop()
        {
            shopC.Shops.Load();
            return shopC.Shops.Local[0];
        }

        public Cart GetCart()
        {
            shopC.Carts.Load();
            return shopC.Carts.Local[0];
        }

        public List<Stock> ShopStocks()
        {
            shopC.Shops.Load();
            return shopC.Shops.Local[0].products;
        }
        
        public List<Stock> CartStocks()
        {
            shopC.Carts.Load();
            return shopC.Carts.Local[0].products;
        }

        //List<Product> products = new List<Product>
        //{
        //    new Product("Car",9999.99),
        //    new Product("Laptop",200.90),
        //    new Product("Switch",10.43),
        //    new Product("Table",4.53),
        //    new Product("Milk",1)
        //};

        //List<Stock> stocks = new List<Stock>
        //{
        //    new Stock(products[0],2),
        //    new Stock(products[1],10),
        //    new Stock(products[2],100),
        //    new Stock(products[3],4),
        //    new Stock(products[4],999)
        //};

        //Shop shop = new Shop("DefenderShop", stocks);

        //Cart cart = new Cart(shop, "Client 1", 0, null);

        //foreach (Product product in products)
        //    shopC.Products.Add(product);

        //foreach (Stock stock in stocks)
        //    shopC.Stocks.Add(stock);

        //shopC.Shops.Add(shop);
        //shopC.Carts.Add(cart);

        //shopC.SaveChanges();
        //Info.Text = "Great";


        //shopC.SaveChanges();
        //shopC.Products.Load();
        //shopC.SaveChanges();

        //shopC.Products.Load();
        //Info.Text = shopC.Products.Local[0].Name;
        //shopC.Products.Remove(shopC.Products.Local[0]);
        //shopC.SaveChanges();
    }
}
