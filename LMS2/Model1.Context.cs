﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities1 : DbContext
    {
        public Entities1()
            : base("name=Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Auther_table> Auther_tables { get; set; }
        public virtual DbSet<AutherAndBook> AutherAndBooks { get; set; }
        public virtual DbSet<Book_table> Book_table { get; set; }
        public virtual DbSet<Borrow> Borrows { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<record_history> record_histories { get; set; }
        public virtual DbSet<return_table> return_tables { get; set; }
        public virtual DbSet<Subject_table> Subject_table { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}