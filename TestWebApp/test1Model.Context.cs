﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestWebApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class test1Entities : DbContext
    {
        public test1Entities()
            : base("name=test1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C____ANS001> C____ANS001 { get; set; }
        public virtual DbSet<C____ANS002> C____ANS002 { get; set; }
        public virtual DbSet<C____ANS003> C____ANS003 { get; set; }
        public virtual DbSet<C____ANS004> C____ANS004 { get; set; }
        public virtual DbSet<C____ANS005> C____ANS005 { get; set; }
        public virtual DbSet<C____ANS006> C____ANS006 { get; set; }
        public virtual DbSet<C____ANS007> C____ANS007 { get; set; }
        public virtual DbSet<C____ANS008> C____ANS008 { get; set; }
        public virtual DbSet<C____REQ001> C____REQ001 { get; set; }
        public virtual DbSet<C____REQ002> C____REQ002 { get; set; }
        public virtual DbSet<C____REQ003> C____REQ003 { get; set; }
        public virtual DbSet<C____REQ004> C____REQ004 { get; set; }
        public virtual DbSet<C____REQ008> C____REQ008 { get; set; }
        public virtual DbSet<C____TEMP002> C____TEMP002 { get; set; }
        public virtual DbSet<C___CARD> C___CARD { get; set; }
        public virtual DbSet<C___CONSTANT_PARTNER> C___CONSTANT_PARTNER { get; set; }
        public virtual DbSet<C___CONSTANT_UNIVERSAL> C___CONSTANT_UNIVERSAL { get; set; }
        public virtual DbSet<C___EXPORT_MAP> C___EXPORT_MAP { get; set; }
        public virtual DbSet<C___HOLIDAY> C___HOLIDAY { get; set; }
        public virtual DbSet<C___PARTNER> C___PARTNER { get; set; }
        public virtual DbSet<C___PARTNER_TYPE> C___PARTNER_TYPE { get; set; }
    }
}