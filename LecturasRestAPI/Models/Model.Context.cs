﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LecturasRestAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LecturasContext : DbContext
    {
        public LecturasContext()
            : base("name=LecturasContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Lectura> Lecturas { get; set; }
        public virtual DbSet<Medidor> Medidores { get; set; }
        public virtual DbSet<ModeloDeMedidor> ModelosDeMedidor { get; set; }
        public virtual DbSet<TipoDeValor> TiposDeValor { get; set; }
        public virtual DbSet<ValorLeido> ValoresLeidos { get; set; }
    }
}
