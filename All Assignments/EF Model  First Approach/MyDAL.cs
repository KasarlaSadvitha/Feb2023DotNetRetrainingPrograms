using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Model__First_Approach
{
    internal class MyDAL: DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("TblPersons");
            base.OnModelCreating(modelBuilder);
        }

        //DbSet will represent all the Persons that can be queried from the database
        public DbSet<Person> Persons { get; set; }
    }
}
