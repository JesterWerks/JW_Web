﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data.EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class JesterWerksContext : DbContext
    {
        public JesterWerksContext()
            : base("name=JesterWerksContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Bookings> Bookings { get; set; }
        public DbSet<Locations> Locations { get; set; }
        public DbSet<Rooms> Rooms { get; set; }
        public DbSet<Sessions> Sessions { get; set; }
    }
}
