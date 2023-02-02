using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi2TableClient.Models;
using WebApi2TableClient.DataAccessLayer;

namespace WebApi2TableClient.Repository
{
    public class ProductRepository:IProductRepository
    {
        public readonly MyCPDAL dalC = new MyCPDAL();
        private int _nextId = 1;
        public IEnumerable<Product> GetAll()
        {
            return dalC.Products;
        }

        public Product Get(int id)
        {   Product p= dalC.Products.Find(id);
            return p;
        }

        public Product Add(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.ProId = _nextId++;
            dalC.Products.Add(item);
            return item;
        }



        public void Remove(int id)
        {
            Product p= dalC.Products.Find(id);
            dalC.Products.Remove(p );
        }

        public bool Update(Product item)
        {
            //if (item == null)
            //{
            //    throw new ArgumentNullException("item");
            //}
            //int index = dalC.Products.FindIndex(p => p.Id == item.Id);
            //if (index == -1)
            //{
            //    return false;
            //}
            Product p = dalC.Products.Find(item.ProId);
            dalC.Products.Remove(p);
            dalC.Products.Add(item);
            return true;
        }
    }
}