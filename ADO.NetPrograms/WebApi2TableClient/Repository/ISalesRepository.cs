using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi2TableClient.Models
{
    internal interface ISalesRepository
    {
        IEnumerable<Customer> GetAllCustomers();
        Product GetProductById(int id);

        IEnumerable<Customer> GetCustomerswithproductId(int proid);


        IEnumerable<Customer> GetCustomerswithproductName(string proName);

        IEnumerable<Customer> GetCustomerswithGreaterproductprice(int Proprice);

        IEnumerable<Customer> GetProductwhoseCustID(int custId);
        







       
    }
}
