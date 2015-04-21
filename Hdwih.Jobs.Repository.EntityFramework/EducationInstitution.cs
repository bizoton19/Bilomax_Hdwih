namespace Hdwih.Jobs.Repository.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EducationInstitution")]
    public partial class EducationInstitution
    {
        public EducationInstitution()
        {
            Addresses = new HashSet<Address>();
            PersonEducations = new HashSet<PersonEducation>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long EducationInstitutionId { get; set; }

        [Required]
        [StringLength(50)]
        public string InstitutionName { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime InsertDateTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime LastUpdateTime { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }

        public virtual ICollection<PersonEducation> PersonEducations { get; set; }
    }
}
