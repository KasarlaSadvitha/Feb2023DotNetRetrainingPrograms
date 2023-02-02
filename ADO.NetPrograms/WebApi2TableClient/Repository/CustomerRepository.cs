using System.Data.Entity;
using WebApi2TableClient.DataAccessLayer;
using WebApi2TableClient.Models;

namespace WebApi2TableClient.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public readonly MyCPDAL dalC = new MyCPDAL();
        public bool DeleteCompany(int id)
        {
            dalC.Customers.Remove(dalC.Customers.Find(id));
            dalC.SaveChanges();
            return true;
        }

        public DbSet<Customer> GetAllCustomers()
        {
            return dalC.Customers;
        }

        public bool InsertNewCustomer(Customer c1)
        {
            dalC.Customers.Add(c1);
            dalC.SaveChanges();
            return true;
        }

        public bool UpdateAllCustomerDetails(int id, Customer cus)
        {
            Customer s = dalC.Customers.Find(id);
            s.CustName = cus.CustName;
            s.CustProductId = cus.CustProductId;

            DeleteCompany( id);
            InsertNewCustomer(s);
            //dalC.Customers.;
            //dalC.SaveChanges();
            //products.RemoveAt(index);
            //products.Add(item);
            //return true;
            return true;
        }

        public bool UpdateCompanyName(int id, string name)
        {
            Customer c3 = dalC.Customers.Find(id);

            // dalC.Companys.Remove(c3);
            c3.CustName =name;
            //InsertNewCompany(c3);

            DeleteCompany(id);
            InsertNewCustomer(c3);
            //dalC.Update(c3);
            dalC.SaveChanges();
            return true;
        }
    }
}