﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebPrinter.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PrinterStockEntities : DbContext
    {
        public PrinterStockEntities()
            : base("name=PrinterStockEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ColorUnit> ColorUnits { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Finishing> Finishings { get; set; }
        public virtual DbSet<Machine_Printer> Machine_Printer { get; set; }
        public virtual DbSet<Owner> Owners { get; set; }
        public virtual DbSet<Stock_Paper> Stock_Paper { get; set; }
        public virtual DbSet<Sys_Print> Sys_Print { get; set; }
        public virtual DbSet<Type_Finishing> Type_Finishing { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<Job_Type> Job_Type { get; set; }
        public virtual DbSet<Transfer> Transfers { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<DetailDataPrinter> DetailDataPrinters { get; set; }
        public virtual DbSet<HeadDataPrinter> HeadDataPrinters { get; set; }
    }
}
