using Asp.netCoreIUDS.DataAccessLayer;
using Asp.netCoreIUDS.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Asp.netCoreIUDS.Repository
{
    public class CompanyRepository :ICompanyRepository
    {
        public readonly ComDALContext dalC;
        public CompanyRepository(ComDALContext _dalC)
        {
            dalC = _dalC;
        }

        public bool DeleteCompany(int id)
        {
            
            dalC.Companys.Remove(dalC.Companys.Find(id));
            dalC.SaveChanges();
                  return true;
        }

        public  DbSet<Company> GetAllCompanys()
        {
            return dalC.Companys;
        }

        public bool InsertNewCompany(Company c1)
        {
            dalC.Companys.Add(c1);
            dalC.SaveChanges();
             return true;
        }
        public bool UpdateAllCompanyDetails(int id, Company comp)
        {
            Company s = dalC.Companys.Find(id);
            s.CompanyName = comp.CompanyName;
            s.CompanyArea = comp.CompanyArea;
            s.CompanyNBranches = comp.CompanyNBranches;
            dalC.Update(s);
           dalC.SaveChanges();
            return true;
        }

        //public Company UpdateAllCompanyDetails(int id, Company c2)
        //{
        //    DeleteCompany(id);
        //    c2.CompanyId = id;
        //    dalC.Companys.Add(c2);
        //    dalC.SaveChanges();
        //    return c2;
        //}

        public bool UpdateCompanyArea(int id, string area)
        {
            Company c3=dalC.Companys.Find(id);

            // dalC.Companys.Remove(c3);
            c3.CompanyArea = area;
            //InsertNewCompany(c3);
            dalC.Update(c3);
            dalC.SaveChanges();
            return true;
        }
        // public  bool InsertCompany(Company c1)
        //  {
        //       dalC.Companys.Add(c1);
        //       dalC.SaveChanges();
        //       return true;
        //  }

        //  public  Company UpdateCompanyArea(int id, string area)
        //  {
        //      Company c3= dalC.Companys.Find(id);      
        //     // c3.CompanyArea = area;
        //      dalC.Companys.Remove(c3);
        //      c3.CompanyArea = area;
        //     // InsertCompany(c3);
        //      return c3;
        //  }
        //public  Company UpdateAllCompanyDetails(int id, Company c2) // unable to use Task here
        //  {
        //      DeleteCompany(id);
        //      c2.CompanyId = id;
        //      dalC.Companys.Add(c2);
        //      dalC.SaveChanges();
        //      return  c2;

        //  }

        //  public bool DeleteCompany(int id)
        //  {
        //      dalC.Companys.Remove(dalC.Companys.Find(id));
        //      return true;
        //  }

        //  public DbSet<Company> GetAllCompanys()
        //  {
        //      return dalC.Companys;
        //  }

        // 
    }
}
