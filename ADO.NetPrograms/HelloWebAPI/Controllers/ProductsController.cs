using HelloWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;


namespace HelloWebAPI.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
          {
            new Product{Id = 1 , Name = "Tomato Soup", Category =  "Groceries", Price = 10 },
            new Product{Id = 2 , Name = "Yoo", Category =  "Toys", Price = 20 },
            new Product{Id = 3 , Name = "Hammer", Category =  "Hardware", Price = 30 },



          };



        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }



        public Product GetProductByPrice(int price)
        {
            var product = products.FirstOrDefault((p) => p.Price == price);
            if (product == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return product;
        }



        public Product GetProductById(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return product;
        }
       

    }
}