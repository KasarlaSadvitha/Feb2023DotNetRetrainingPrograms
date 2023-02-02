using Asp.netCoreIUDS.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace Asp.netCoreIUDS.DataAccessLayer
{
    public class ComDALContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ComDALContext(DbContextOptions<ComDALContext> options) : base(options)
        { 
        }
        public Microsoft.EntityFrameworkCore.DbSet<Company> Companys { get; set; }
    }
}
