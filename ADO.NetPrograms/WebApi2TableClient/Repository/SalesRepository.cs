using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi2TableClient.DataAccessLayer;

namespace WebApi2TableClient.Models
{
    public class SalesRepository : ISalesRepository
    {
        MyCPDAL dal = new MyCPDAL();
        public IEnumerable<Customer> GetAllCustomers()
        {
            return dal.Customers.ToList();
        }

        public Product GetProductById(int id)
        {
            Product p = dal.Products.Find(id);
            return p;
        }
        public IEnumerable<Customer> GetCustomerswithproductId(int ProductId)
        {
           // Product product = dal.Products.Find(ProductId);
            
            var custs = dal.Customers.Where((p) => p.CustProductId == ProductId).ToList();
            return custs;
        }

        public IEnumerable<Customer> GetCustomerswithproductName(string proName)
        {
            //var custs = dal.Customers.Where(p => p.Product.ProName == proName).ToList();
            //return custs;
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetCustomerswithGreaterproductprice(int Proprice)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetProductwhoseCustID(int custId)
        {
            throw new NotImplementedException();
        }
    }
}