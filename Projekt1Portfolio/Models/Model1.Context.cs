﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projekt1Portfolio.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MyPortfolio5DbEntities : DbContext
    {
        public MyPortfolio5DbEntities()
            : base("name=MyPortfolio5DbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tbl_About> Tbl_About { get; set; }
        public virtual DbSet<Tbl_Category> Tbl_Category { get; set; }
        public virtual DbSet<Tbl_Education> Tbl_Education { get; set; }
        public virtual DbSet<Tbl_Experience> Tbl_Experience { get; set; }
        public virtual DbSet<Tbl_Message> Tbl_Message { get; set; }
        public virtual DbSet<Tbl_Profile> Tbl_Profile { get; set; }
        public virtual DbSet<Tbl_Services> Tbl_Services { get; set; }
        public virtual DbSet<Tbl_Skill> Tbl_Skill { get; set; }
        public virtual DbSet<Tbl_Testimonial> Tbl_Testimonial { get; set; }
        public virtual DbSet<Tbl_Work> Tbl_Work { get; set; }
        public virtual DbSet<Tbl_Admin> Tbl_Admin { get; set; }
        public virtual DbSet<SocialMedia> SocialMedia { get; set; }
    }
}
