﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PodkopaevApp.Helper
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PodkopaevPolyclinicEntities : DbContext
    {
        public PodkopaevPolyclinicEntities()
            : base("name=PodkopaevPolyclinicEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DiseaseHistory> DiseaseHistory { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<MedicalCard> MedicalCard { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<Polis> Polis { get; set; }
        public virtual DbSet<RecipeList> RecipeList { get; set; }
        public virtual DbSet<RecordList> RecordList { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}