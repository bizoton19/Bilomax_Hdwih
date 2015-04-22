namespace Hdwih.Jobs.Repository.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PersonResume")]
    public partial class PersonResume
    {
        public PersonResume()
        {
            EmploymentPositions = new HashSet<EmploymentPosition>();
            LanguageSpokens = new HashSet<LanguageSpoken>();
            PersonEducations = new HashSet<PersonEducation>();
            PersonReferences = new HashSet<PersonReference>();
            PersonResume1 = new HashSet<PersonResume>();
            SkillOrSpecialities = new HashSet<SkillOrSpeciality>();
        }

        public long PersonResumeId { get; set; }

        public long? ParentResumeId { get; set; }

        [StringLength(4000)]
        public string Introduction { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public long PersonId { get; set; }

        public short ResumeTypeId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime InsertDateTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime LastUpdateTime { get; set; }

        public virtual ICollection<EmploymentPosition> EmploymentPositions { get; set; }

        public virtual ICollection<LanguageSpoken> LanguageSpokens { get; set; }

        public virtual Person Person { get; set; }

        public virtual ICollection<PersonEducation> PersonEducations { get; set; }

        public virtual ICollection<PersonReference> PersonReferences { get; set; }

        public virtual ICollection<PersonResume> Resumes { get; set; }

        public virtual PersonResume ParentResume { get; set; }

        public virtual PersonResumeType PersonResumeType { get; set; }

        public virtual ICollection<SkillOrSpeciality> SkillOrSpecialities { get; set; }
    }
}
