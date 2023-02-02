using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApi2TableClient.Models
{
    public class Product
    {
        [Key]
        public int ProId { get; set; }
        public string ProName { get; set; }
        
        public int ProductPrice { get; set; }

        //customer collection
      //  public virtual ICollection<Customer> Customers { get; set; }
    }
}