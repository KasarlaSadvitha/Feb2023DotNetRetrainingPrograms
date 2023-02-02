using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using mvc22myown.Models;


namespace mvc22myown.DataAccessLayer
{
    public class StuDAL:DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("TblMyStudent");
            modelBuilder.Entity<UserDetail>().ToTable("TblMyUserDetail");

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
    }
}