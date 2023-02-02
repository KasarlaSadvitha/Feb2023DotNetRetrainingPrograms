using Asp.netCoreIUDS.Models;
using Microsoft.EntityFrameworkCore;

namespace Asp.netCoreIUDS.Repository
{
    public interface ICompanyRepository
    {
        bool InsertNewCompany(Company c1);
        //{
        //    dalC.Companys.Add(c1);
        //    dalC.SaveChanges();
        //    return true;
        //}
        bool UpdateAllCompanyDetails(int id, Company comp);
        

        bool UpdateCompanyArea(int id, string area);
       // Company UpdateAllCompanyDetails(int id, Company c2);

        bool DeleteCompany(int id);

        DbSet<Company> GetAllCompanys();
    }
}
