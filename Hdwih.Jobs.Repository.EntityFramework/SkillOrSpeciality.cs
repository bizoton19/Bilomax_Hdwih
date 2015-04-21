namespace Hdwih.Jobs.Repository.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SkillOrSpeciality")]
    public partial class SkillOrSpeciality
    {
        [Key]
        public long SkillOrSpecialtyId { get; set; }

        public long PersonResumeId { get; set; }

        [Required]
        [StringLength(50)]
        public string SkillOrSpecialtyDescription { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime InsertDateTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime LastUpdateTime { get; set; }

        public virtual PersonResume PersonResume { get; set; }
    }
}
