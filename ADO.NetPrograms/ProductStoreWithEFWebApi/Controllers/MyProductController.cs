using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using ProductStoreWithEFWebApi.Models;

namespace ProductStoreWithEFWebApi.Controllers
{
    public class MyProductController : ApiController
    {
        // GET: MyProduct
        static readonly MyProductRepository repository = new MyProductRepository();
        public IEnumerable<MyProduct> GetProducts()
        {
            return repository.getAllProducts();
         }
       public  void GetProductsById(int productId)
        {
            repository.GetProductById(productId);
            
        }
       public  MyProduct GetByName(string productName)
        {
           return  repository.GetProductByName(productName);
        }

        public MyProduct PostProduct(MyProduct product)
        {
           return   repository.CreateProduct(product);
        }
        public void DeleteProduct(int productId)
        {
            repository.DeleteProduct(productId);
        }
       public MyProduct PutProduct(int id,int newprice)
        {
           return repository.UpdateWithNewPrice(newprice,id);
        }

    }
}