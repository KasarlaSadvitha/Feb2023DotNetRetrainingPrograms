using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi2TableClient.DataAccessLayer;
using WebApi2TableClient.Models;

namespace WebApi2TableClient.Repository
{
    internal interface ICustomerRepository
    {
        DbSet<Customer> GetAllCustomers();
        bool InsertNewCustomer(Customer c1);
       
        bool UpdateAllCustomerDetails(int id, Customer cus);

        bool UpdateCompanyName(int id, string name);
        bool DeleteCompany(int id);

       
    }
}
