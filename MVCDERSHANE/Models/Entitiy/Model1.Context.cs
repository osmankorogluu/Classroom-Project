﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCDERSHANE.Models.Entitiy
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbMvcDershaneEntities1 : DbContext
    {
        public DbMvcDershaneEntities1()
            : base("name=DbMvcDershaneEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TBLBOLUM> TBLBOLUM { get; set; }
        public virtual DbSet<TBLDERS> TBLDERS { get; set; }
        public virtual DbSet<TBLODEV> TBLODEV { get; set; }
        public virtual DbSet<TBLOGRENCİ> TBLOGRENCİ { get; set; }
        public virtual DbSet<TBLVELİ> TBLVELİ { get; set; }
        public virtual DbSet<TBLADMİN> TBLADMİN { get; set; }
        public virtual DbSet<TBLİLETİSİM> TBLİLETİSİM { get; set; }
    }
}