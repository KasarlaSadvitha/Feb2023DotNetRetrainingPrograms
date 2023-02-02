using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApi2TableClient.Models;

namespace WebApi2TableClient.DataAccessLayer
{
    public class MyCPpDAL:DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("TblMyCustomer");
            modelBuilder.Entity<Product>().ToTable("TblMyProduct");

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}