namespace Hdwih.Jobs.Repository.EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Hdwih_Entities : DbContext
    {
        public Hdwih_Entities()
            : base("name=Hdwih_Entities")
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Award> Awards { get; set; }
        public virtual DbSet<EducationInstitution> EducationInstitutions { get; set; }
        public virtual DbSet<EmploymentPosition> EmploymentPositions { get; set; }
        public virtual DbSet<JobPosting> JobPostings { get; set; }
        public virtual DbSet<JobPostingNote> JobPostingNotes { get; set; }
        public virtual DbSet<KeyRequirement> KeyRequirements { get; set; }
        public virtual DbSet<LanguageSpoken> LanguageSpokens { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<PersonAddress> PersonAddresses { get; set; }
        public virtual DbSet<PersonEducation> PersonEducations { get; set; }
        public virtual DbSet<PersonOrganization> PersonOrganizations { get; set; }
        public virtual DbSet<PersonReference> PersonReferences { get; set; }
        public virtual DbSet<PersonResume> PersonResumes { get; set; }
        public virtual DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public virtual DbSet<PositionDuty> PositionDuties { get; set; }
        public virtual DbSet<Qualification> Qualifications { get; set; }
        public virtual DbSet<RelationshipType> RelationshipTypes { get; set; }
        public virtual DbSet<SkillOrSpeciality> SkillOrSpecialities { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<UserAccountProfile> UserAccountProfiles { get; set; }
        public virtual DbSet<RequiredDocument> RequiredDocuments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .Property(e => e.AddressName)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.StreetAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.PersonAddresses)
                .WithRequired(e => e.Address)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Award>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Award>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<EducationInstitution>()
                .Property(e => e.InstitutionName)
                .IsUnicode(false);

            modelBuilder.Entity<EducationInstitution>()
                .HasMany(e => e.Addresses)
                .WithOptional(e => e.EducationInstitution)
                .HasForeignKey(e => e.EducationInstituationId);

            modelBuilder.Entity<EducationInstitution>()
                .HasMany(e => e.PersonEducations)
                .WithRequired(e => e.EducationInstitution)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmploymentPosition>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<EmploymentPosition>()
                .Property(e => e.SupervisorPhone)
                .IsUnicode(false);

            modelBuilder.Entity<EmploymentPosition>()
                .Property(e => e.SupervisorName)
                .IsUnicode(false);

            modelBuilder.Entity<EmploymentPosition>()
                .HasMany(e => e.Awards)
                .WithRequired(e => e.EmploymentPosition)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmploymentPosition>()
                .HasMany(e => e.PositionDuties)
                .WithOptional(e => e.EmploymentPosition)
                .HasForeignKey(e => e.PositionId);

            modelBuilder.Entity<JobPosting>()
                .Property(e => e.ClosingDate)
                .IsFixedLength();

            modelBuilder.Entity<JobPosting>()
                .Property(e => e.MaximumSalary)
                .HasPrecision(7, 2);

            modelBuilder.Entity<JobPosting>()
                .Property(e => e.MinimumSalary)
                .HasPrecision(7, 2);

            modelBuilder.Entity<JobPosting>()
                .Property(e => e.IsTravelRequired)
                .IsFixedLength();

            modelBuilder.Entity<JobPosting>()
                .Property(e => e.Summary)
                .IsUnicode(false);

            modelBuilder.Entity<JobPosting>()
                .Property(e => e.JobPostingTitle)
                .IsUnicode(false);

            modelBuilder.Entity<JobPosting>()
                .Property(e => e.Benefits)
                .IsUnicode(false);

            modelBuilder.Entity<JobPosting>()
                .HasMany(e => e.JobPostingNotes)
                .WithRequired(e => e.JobPosting)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<JobPosting>()
                .HasMany(e => e.KeyRequirements)
                .WithRequired(e => e.JobPosting)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<JobPosting>()
                .HasOptional(e => e.PositionDuty)
                .WithRequired(e => e.JobPosting);

            modelBuilder.Entity<JobPosting>()
                .HasMany(e => e.Qualifications)
                .WithRequired(e => e.JobPosting)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<JobPosting>()
                .HasMany(e => e.RequiredDocuments)
                .WithRequired(e => e.JobPosting)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<JobPostingNote>()
                .Property(e => e.NoteTitle)
                .IsUnicode(false);

            modelBuilder.Entity<JobPostingNote>()
                .Property(e => e.NoteBody)
                .IsUnicode(false);

            modelBuilder.Entity<KeyRequirement>()
                .Property(e => e.RequirementDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Organization>()
                .Property(e => e.OrganizationName)
                .IsUnicode(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.PersonOrganizations)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PersonAddresses)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PersonOrganizations)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PersonReferences)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.UserAccountProfiles)
                .WithRequired(e => e.Person)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PhoneNumbers)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PersonResumes)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PersonEducation>()
                .HasMany(e => e.Awards)
                .WithOptional(e => e.PersonEducation)
                .HasForeignKey(e => new { e.PersonResumeId, e.EducationInstitutionId });

            modelBuilder.Entity<PersonResume>()
                .Property(e => e.Introduction)
                .IsUnicode(false);

            modelBuilder.Entity<PersonResume>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PersonResume>()
                .HasMany(e => e.EmploymentPositions)
                .WithRequired(e => e.PersonResume)
                .HasForeignKey(e => e.ResumeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PersonResume>()
                .HasMany(e => e.LanguageSpokens)
                .WithRequired(e => e.PersonResume)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PersonResume>()
                .HasMany(e => e.PersonEducations)
                .WithRequired(e => e.PersonResume)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PersonResume>()
                .HasMany(e => e.PersonReferences)
                .WithRequired(e => e.PersonResume)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PersonResume>()
                .HasMany(e => e.SkillOrSpecialities)
                .WithRequired(e => e.PersonResume)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhoneNumber>()
                .Property(e => e.AreaCode)
                .IsUnicode(false);

            modelBuilder.Entity<PhoneNumber>()
                .Property(e => e.PhoneType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PositionDuty>()
                .Property(e => e.DutyDescrption)
                .IsUnicode(false);

            modelBuilder.Entity<PositionDuty>()
                .Property(e => e.DutyLocation)
                .IsUnicode(false);

            modelBuilder.Entity<Qualification>()
                .Property(e => e.QualificationTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Qualification>()
                .Property(e => e.QualificationDescription)
                .IsUnicode(false);

            modelBuilder.Entity<RelationshipType>()
                .Property(e => e.RelationshipTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<RelationshipType>()
                .Property(e => e.RelationshipTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<RelationshipType>()
                .HasMany(e => e.PersonOrganizations)
                .WithRequired(e => e.RelationshipType1)
                .HasForeignKey(e => e.RelationshipType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RelationshipType>()
                .HasMany(e => e.PersonReferences)
                .WithRequired(e => e.RelationshipType1)
                .HasForeignKey(e => e.RelationshipType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SkillOrSpeciality>()
                .Property(e => e.SkillOrSpecialtyDescription)
                .IsUnicode(false);

            modelBuilder.Entity<RequiredDocument>()
                .Property(e => e.RequiredDocumentName)
                .IsUnicode(false);

            modelBuilder.Entity<RequiredDocument>()
                .Property(e => e.RequiredDocumentDescription)
                .IsUnicode(false);
        }
    }
}
