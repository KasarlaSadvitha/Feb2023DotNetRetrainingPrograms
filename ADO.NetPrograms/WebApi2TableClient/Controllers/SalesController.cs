using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApi2TableClient.Models;

namespace WebApi2TableClient.Controllers
{
    public class SalesController : ApiController
    {
        ISalesRepository repost = new SalesRepository();
        // GET: Sales

        public IEnumerable<Customer> GetAllCustomers()
        {
            return repost.GetAllCustomers();
        }
       
    }
}