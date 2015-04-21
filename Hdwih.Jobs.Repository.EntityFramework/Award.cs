namespace Hdwih.Jobs.Repository.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Award")]
    public partial class Award
    {
        public long AwardId { get; set; }

        public long? PersonResumeId { get; set; }

        public long? EducationInstitutionId { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateReceived { get; set; }

        public long EmploymentPositionId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime InsertDateTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime LastUpdateTime { get; set; }

        public virtual PersonEducation PersonEducation { get; set; }

        public virtual EmploymentPosition EmploymentPosition { get; set; }
    }
}
