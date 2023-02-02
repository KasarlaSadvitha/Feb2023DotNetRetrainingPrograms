using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using mvc11.Models;

namespace mvc11.DataAccessLayer
{
    public class MyCompanyContext: DbContext //EmpDAL
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("TblMyEmployees");
            modelBuilder.Entity<UserDetails>().ToTable("TblMyUserDetails");

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<UserDetails> userDetails { get; set; }
    }
}