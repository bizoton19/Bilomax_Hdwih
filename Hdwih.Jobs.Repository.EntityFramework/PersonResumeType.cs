namespace Hdwih.Jobs.Repository.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PersonResumeType")]
    public partial class PersonResumeType
    {
        public PersonResumeType()
        {
            PersonResumes = new HashSet<PersonResume>();
        }

        [Key]
        public short ResumeTypeId { get; set; }

        [Required]
        [StringLength(15)]
        public string ResumeTypeTitle { get; set; }

        [Required]
        [StringLength(400)]
        public string ResumeTypeDescription { get; set; }

        public virtual ICollection<PersonResume> PersonResumes { get; set; }
    }
}
