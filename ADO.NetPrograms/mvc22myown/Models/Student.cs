using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvc22myown.Models
{
    public class Student
    {
        [Key]
        public int StuId { get; set; }
        [Required(ErrorMessage ="Enter Your Name")]
        [StringLength(10,ErrorMessage ="Name should  not be greater than 10")]
        public string StuName { get; set; }

        public string StuSubject { get; set; }
    }
}