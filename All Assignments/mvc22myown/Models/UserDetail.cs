using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvc22myown.Models
{
    public class UserDetail
    {
        [Key]
        [Required(ErrorMessage = "Enter Your UserName")]
        //search for data Annotations for validating password , email in Google
        public string UserName { get; set; }
        [Required(ErrorMessage = "Enter Your Password")]
        public string Password { get; set; }
       
    }
}