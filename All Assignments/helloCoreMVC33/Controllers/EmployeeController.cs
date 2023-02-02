using Microsoft.AspNetCore.Mvc;
using HelloCoreMVC33.Repository;
using HelloCoreMVC33.DataLayer;
using Microsoft.EntityFrameworkCore;

namespace HelloCoreMVC33.Controllers
{
    public class EmployeeController : Controller
    {

        IEmployeeRepository _repository;

        public EmployeeController(EmployeeContext context)
        {
            _repository = new EmployeeRepository(context);
        }
        public async Task<IActionResult> GetEmployees()
        {
            return View(await _repository.GetEmployees().ToListAsync());
        }
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            var employee = await _repository.GetEmployee(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

    }
}
