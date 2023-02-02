using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using ProductStore.Models;

namespace ProductStore.Controllers
{
    public class ProductsController : ApiController
    {
       
            static readonly IProductRepository repository = new ProductRepository();
            // GET api/values
            public IEnumerable<Product> GetAllProducts()
            {
                return repository.GetAll();
            }



            // GET api/values/5
            public Product GetProduct(int id)
            {
                Product item = repository.Get(id);
                if (item == null)
                {
                    throw new HttpResponseException(HttpStatusCode.NotFound);
                }

                return item;
            }
            public IEnumerable<Product> GetProductsByCategory(string category)
            {
                return repository.GetAll().Where(
                    p => string.Equals(p.Category, category, StringComparison.OrdinalIgnoreCase));

            }



            //Not the final Implementation



            public Product PostProduct(Product item)
            {
                item = repository.Add(item);
                return item;
            }
            public void PutProduct(int id, Product product)
            {
                product.Id = id;
                // if(!repository.Update(product))
                // {
                //     throw new HttpResponseException(HttpStatusCode.NotFound);
                // }
                repository.Update(product);
            }




            // POST api/values
            public void DeleteProduct(int id)
            {
                Product item = repository.Get(id);
                if (item == null)
                {
                    throw new HttpResponseException(HttpStatusCode.NotFound);
                }
                repository.Remove(id);
            }



            // PUT api/values/5


        }
    }
