using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApiEF22.Models;

namespace WebApiEF22.DataAccessLayer
{
    public class MyStuDAL:DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Student>().ToTable("MyStudentTable");
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Student> Students { get; set; }
    }
}