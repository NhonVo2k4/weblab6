﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace weblab6.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class lab6Entities : DbContext
    {
        public lab6Entities()
            : base("name=lab6Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblBill> tblBills { get; set; }
        public virtual DbSet<tblCustumer> tblCustumers { get; set; }
        public virtual DbSet<tblDetailBill> tblDetailBills { get; set; }
        public virtual DbSet<tblProduct> tblProducts { get; set; }
        public virtual DbSet<tblStaff> tblStaffs { get; set; }
        public virtual DbSet<tblStyle> tblStyles { get; set; }
        public virtual DbSet<tblSupplierProduct> tblSupplierProducts { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
    }
}