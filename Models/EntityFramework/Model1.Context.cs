﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ObsSistem.Models.EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ObsSistemEntities5 : DbContext
    {
        public ObsSistemEntities5()
            : base("name=ObsSistemEntities5")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
     //   public virtual DbSet<TBL_AKADEMISYEN> TBL_AKADEMISYEN { get; set; }
  //      public virtual DbSet<TBL_BOLUM> TBL_BOLUM { get; set; }
      //  public virtual DbSet<TBL_DERS> TBL_DERS { get; set; }
        public virtual DbSet<TBL_DERS_ALMA> TBL_DERS_ALMA { get; set; }
    //    public virtual DbSet<TBL_IS_DENEYIMLERI> TBL_IS_DENEYIMLERI { get; set; }
        public virtual DbSet<TBL_MESAJ> TBL_MESAJ { get; set; }
        public virtual DbSet<TBL_NOT> TBL_NOT { get; set; }
    }
}