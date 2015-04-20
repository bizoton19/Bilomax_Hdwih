﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hdwih.Jobs.Repository.EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Hdwih_Model : DbContext
    {
        public Hdwih_Model()
            : base("name=Hdwih_Model")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Award> Awards { get; set; }
        public virtual DbSet<EducationInstitution> EducationInstitutions { get; set; }
        public virtual DbSet<EmploymentPosition> EmploymentPositions { get; set; }
        public virtual DbSet<JobPosting> JobPostings { get; set; }
        public virtual DbSet<LanguageSpoken> LanguageSpokens { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<PersonAddress> PersonAddresses { get; set; }
        public virtual DbSet<PersonEducation> PersonEducations { get; set; }
        public virtual DbSet<PersonReference> PersonReferences { get; set; }
        public virtual DbSet<PersonResume> PersonResumes { get; set; }
        public virtual DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public virtual DbSet<PositionDuty> PositionDuties { get; set; }
        public virtual DbSet<SkillOrSpeciality> SkillOrSpecialities { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
