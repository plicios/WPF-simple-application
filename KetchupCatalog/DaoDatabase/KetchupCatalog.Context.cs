﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gorny.KetchupCatalog.DaoDatabase
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KetchupCatalogDatabaseEntities : DbContext
    {
        public KetchupCatalogDatabaseEntities()
            : base("name=KetchupCatalogDatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Ketchup> Ketchups { get; set; }
        public virtual DbSet<Producer> Producers { get; set; }
    }
}
