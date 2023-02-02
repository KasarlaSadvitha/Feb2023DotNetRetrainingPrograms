using System.ComponentModel.DataAnnotations;

namespace Asp.netCoreIUDS.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyArea { get; set; }
        public int CompanyNBranches { get; set; }
    }
}
