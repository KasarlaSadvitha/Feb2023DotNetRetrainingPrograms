using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvc11.Models
{
    public class UserDetails
    {
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}