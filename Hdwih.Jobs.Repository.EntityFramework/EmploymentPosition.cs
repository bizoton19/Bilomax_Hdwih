namespace Hdwih.Jobs.Repository.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmploymentPosition")]
    public partial class EmploymentPosition
    {
        public EmploymentPosition()
        {
            Awards = new HashSet<Award>();
            PositionDuties = new HashSet<PositionDuty>();
        }

        public long EmploymentPositionId { get; set; }

        public long? JobPostingId { get; set; }

        public long ResumeId { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(14)]
        public string SupervisorPhone { get; set; }

        [StringLength(30)]
        public string SupervisorName { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? EndDate { get; set; }

        public short NumberOWeeklyHours { get; set; }

        public bool? IsCurrentlyInPosition { get; set; }

        public bool IsVolunteerPosition { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime InsertDateTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime LastUpdateTime { get; set; }

        public virtual ICollection<Award> Awards { get; set; }

        public virtual ICollection<PositionDuty> PositionDuties { get; set; }

        public virtual PersonResume PersonResume { get; set; }
    }
}
