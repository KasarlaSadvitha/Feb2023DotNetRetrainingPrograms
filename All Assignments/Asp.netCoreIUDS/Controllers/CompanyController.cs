using Microsoft.AspNetCore.Mvc;
using Asp.netCoreIUDS.Repository;
using Asp.netCoreIUDS.Models;
using Microsoft.EntityFrameworkCore;
using Asp.netCoreIUDS.DataAccessLayer;

namespace Asp.netCoreIUDS.Controllers
{
    public class CompanyController : Controller
    {
        //use task and Async await in Controller



        //POST means Create or Update 
        //The PUT method is most often used to update an existing resource.
        //post-create
        //put-update
        ICompanyRepository repo;
        public CompanyController(ComDALContext c)
        {
            repo = new CompanyRepository(c) ;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCompanysDetails ()
        {
            return View(await repo.GetAllCompanys().ToListAsync());
        }

        public ActionResult InsertNewCompany()
        {
            return View();
        }
        [HttpPost]
        public  IActionResult NewCompany(Company c1 )
        {
                repo.InsertNewCompany(c1);
            
                return RedirectToAction("GetAllCompanysDetails");
            
        }



        public ActionResult UpdateCompanyDetails()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateAllCompanyDetails(int id, Company c2)
        {
            repo.UpdateAllCompanyDetails(id, c2); //UpdateAllCompanyDetails(int id, Company c2)
            return RedirectToAction("GetAllCompanysDetails");
        }

    public ActionResult UpdateCompanyAreaAction()
        {
            return View();
        }

    [HttpPost]
        public IActionResult UpdateCompanyArea(int id, string area)
        {
            repo.UpdateCompanyArea(id, area);
            return RedirectToAction("GetAllCompanysDetails");
        }


        
        public IActionResult DeleteCompany()
        {
            return View();
        }


        [HttpDelete]
        [HttpPost]
        public IActionResult DeleteParticularCompany(int id)
        {
            repo.DeleteCompany(id);
            return RedirectToAction("GetAllCompanysDetails");
        }

    }
}
