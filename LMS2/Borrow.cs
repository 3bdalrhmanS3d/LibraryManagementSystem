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
    
    public partial class Borrow
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Borrow()
        {
            this.return_table = new HashSet<return_table>();
        }
    
        public int Borrow_ID { get; set; }
        public int book_id { get; set; }
        public int mem_id { get; set; }
        public System.DateTime issue_date { get; set; }
        public System.DateTime return_date { get; set; }
        public string state { get; set; }
    
        public virtual Book_table Book_table { get; set; }
        public virtual Member Member { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<return_table> return_table { get; set; }
    }
}