namespace Hdwih.Jobs.Repository.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PositionDuty")]
    public partial class PositionDuty
    {
        public long PositionDutyId { get; set; }

        public long? JobPostingId { get; set; }

        public long? PositionId { get; set; }

        [Required]
        [StringLength(500)]
        public string DutyDescrption { get; set; }

        [StringLength(25)]
        public string DutyLocation { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime InsertDateTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime LastUpdateTime { get; set; }

        public virtual EmploymentPosition EmploymentPosition { get; set; }

        public virtual JobPosting JobPosting { get; set; }
    }
}
