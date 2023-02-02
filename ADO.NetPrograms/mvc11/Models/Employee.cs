using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace mvc11.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required (ErrorMessage="Enter First Name")]
        [FirstNameValidation]
        public string FirstName { get; set; }

        [StringLength(10,ErrorMessage ="Last Name length should not be greatr than 10")]
        public string LastName { get; set; }
        [Range(10000,30000)]
        public int? Salary { get; set; }
    }
    public class FirstNameValidation:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value , ValidationContext validationContext)
        {
            if(value== null)
            {
                return new ValidationResult("Please provide First Name");
            }
            else
            {
                if(value.ToString().Contains("@"))
                {
                    return new ValidationResult(" First Name should not contain @");
                }
            }
            return ValidationResult.Success;
        }
    }
}