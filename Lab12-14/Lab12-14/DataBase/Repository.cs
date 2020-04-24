using Lab12_14.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_14.DataBase
{
    interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Create(T item);
        void Update(T item);
        void Delete(int id);
    }

    public class CartRepository : IRepository<Cart>
    {
        private ShopContext db;

        public CartRepository(ShopContext context)
        {
            this.db = context;
        }

        public IEnumerable<Cart> GetAll()
        {
            db.Products.Load();
            db.Stocks.Load();
            return db.Carts;
        }

        public Cart Get(int id)
        {
            db.Products.Load();
            db.Stocks.Load();
            return db.Carts.Find(id);
        }
        public Cart Get(string CartName)
        {
            return db.Carts.Local.First(x => x.CartName == CartName);
        }

        public void Create(Cart Cart)
        {
            db.Carts.Add(Cart);
        }

        public void Update(Cart Cart)
        {
            db.Entry(Cart).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Cart Cart = db.Carts.Find(id);
            if (Cart != null)
                db.Carts.Remove(Cart);
        }
    }

    public class ShopRepository : IRepository<Shop>
    {
        private ShopContext db;

        public ShopRepository(ShopContext context)
        {
            this.db = context;
        }

        public IEnumerable<Shop> GetAll()
        {
            db.Products.Load();
            db.Stocks.Load();
            return db.Shops;
        }

        public Shop Get(int id)
        {
            db.Products.Load();
            db.Stocks.Load();
            return db.Shops.Find(id);
        }
        public Shop Get(string ShopName)
        {
            return db.Shops.Local.First(x => x.Name == ShopName);
        }

        public void Create(Shop Shop)
        {
            db.Shops.Add(Shop);
        }

        public void Update(Shop Shop)
        {
            db.Entry(Shop).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Shop Shop = db.Shops.Find(id);
            if (Shop != null)
                db.Shops.Remove(Shop);
        }
    }

    public class StockRepository : IRepository<Stock>
    {
        private ShopContext db;

        public StockRepository(ShopContext context)
        {
            this.db = context;
        }

        public IEnumerable<Stock> GetAll()
        {
            db.Products.Load();
            return db.Stocks;
        }

        public Stock Get(int id)
        {
            db.Products.Load();
            return db.Stocks.Find(id);
        }

        public Stock Get(string StockName)
        {
            db.Products.Load();
            return db.Stocks.Local.First(x => x.Name == StockName);
        }

        public void Create(Stock Stock)
        {
            db.Stocks.Add(Stock);
        }

        public void Update(Stock Stock)
        {
            db.Entry(Stock).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Stock Stock = db.Stocks.Find(id);
            if (Stock != null)
                db.Stocks.Remove(Stock);
        }
    }

    public class ProductRepository : IRepository<Product>
    {
        private ShopContext db;

        public ProductRepository(ShopContext context)
        {
            this.db = context;
        }

        public IEnumerable<Product> GetAll()
        {
            return db.Products;
        }

        public Product Get(int id)
        {
            return db.Products.Find(id);
        }
        public Product Get(string ProductName)
        {
            return db.Products.Local.First(x => x.Name == ProductName);
        }

        public void Create(Product Product)
        {
            db.Products.Add(Product);
        }

        public void Update(Product Product)
        {
            db.Entry(Product).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Product Product = db.Products.Find(id);
            if (Product != null)
                db.Products.Remove(Product);
        }
    }
}
