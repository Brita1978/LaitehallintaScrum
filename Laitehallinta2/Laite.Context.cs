﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Laitehallinta2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SeurantaEntities : DbContext
    {
        public SeurantaEntities()
            : base("name=SeurantaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Henkilot> Henkilot { get; set; }
        public virtual DbSet<Laitteet> Laitteet { get; set; }
        public virtual DbSet<Logi> Logi { get; set; }
        public virtual DbSet<Tilat> Tilat { get; set; }
    }
}
