using HelloCoreMVC33.Models;
using Microsoft.EntityFrameworkCore;

namespace HelloCoreMVC33.Repository
{
    public interface IEmployeeRepository
    {
        DbSet<Employee> GetEmployees();
        Task<Employee> GetEmployee(int employeeId);
    }
}
