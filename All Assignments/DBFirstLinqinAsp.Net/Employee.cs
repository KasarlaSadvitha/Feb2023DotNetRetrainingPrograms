//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBFirstLinqinAsp.Net
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public string Name { get; set; }
        public short ID { get; set; }
        public Nullable<decimal> Salary { get; set; }
        public short DID { get; set; }
    
        public virtual Department Department { get; set; }
    }
}
