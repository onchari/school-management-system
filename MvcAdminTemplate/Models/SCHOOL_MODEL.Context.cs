﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcAdminTemplate.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class merry_cliff_academyEntities : DbContext
    {
        public merry_cliff_academyEntities()
            : base("name=merry_cliff_academyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<attendance> attendances { get; set; }
        public virtual DbSet<classroom> classrooms { get; set; }
        public virtual DbSet<classroom_student> classroom_student { get; set; }
        public virtual DbSet<course> courses { get; set; }
        public virtual DbSet<exam_results> exam_results { get; set; }
        public virtual DbSet<exam_type> exam_type { get; set; }
        public virtual DbSet<exam> exams { get; set; }
        public virtual DbSet<grade> grades { get; set; }
        public virtual DbSet<parent> parents { get; set; }
        public virtual DbSet<student> students { get; set; }
        public virtual DbSet<teacher> teachers { get; set; }
    }
}
