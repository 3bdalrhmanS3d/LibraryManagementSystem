//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMS2
{
    using System;
    using System.Collections.Generic;
    
    public partial class return_table
    {
        public int Return_ID { get; set; }
        public int Borrow_ID { get; set; }
        public System.DateTime Return_date { get; set; }
        public string Statues { get; set; }
    
        public virtual Borrow Borrow { get; set; }
    }
}
