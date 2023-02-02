using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApi2TableClient.Models
{
    public class Customer
    {
        public  int Id { get; set; }
        public string CustName { get; set; }
        public int CustProductId { get; set; }
      //  public virtual Product Product { get;  set; }



       /* [ForeignKey("ProductId")]
        public string ProductId { get; set; }*/
    }
}