using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ProductStoreWithEFWebApi.Models;

namespace ProductStoreWithEFWebApi.DataAccessLayer
{
    public class MyProDAL:DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MyProduct>().ToTable("TblMyProduct");
            

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<MyProduct> MyProducts { get; set; }
    }
}