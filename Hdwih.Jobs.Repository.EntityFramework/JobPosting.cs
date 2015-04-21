namespace Hdwih.Jobs.Repository.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JobPosting")]
    public partial class JobPosting
    {
        public JobPosting()
        {
            JobPostingNotes = new HashSet<JobPostingNote>();
            KeyRequirements = new HashSet<KeyRequirement>();
            Qualifications = new HashSet<Qualification>();
            RequiredDocuments = new HashSet<RequiredDocument>();
        }

        public long JobPostingId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime PostingDate { get; set; }

        [StringLength(10)]
        public string ClosingDate { get; set; }

        public long? OrganizationId { get; set; }

        public bool? IsSecurityClearanceNeeded { get; set; }

        public decimal? MaximumSalary { get; set; }

        public decimal? MinimumSalary { get; set; }

        [Required]
        [StringLength(10)]
        public string IsTravelRequired { get; set; }

        [Required]
        public string Summary { get; set; }

        [Required]
        [StringLength(50)]
        public string JobPostingTitle { get; set; }

        public string Benefits { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime LastUpdateTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime InsertDateTime { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual ICollection<JobPostingNote> JobPostingNotes { get; set; }

        public virtual ICollection<KeyRequirement> KeyRequirements { get; set; }

        public virtual PositionDuty PositionDuty { get; set; }

        public virtual ICollection<Qualification> Qualifications { get; set; }

        public virtual ICollection<RequiredDocument> RequiredDocuments { get; set; }
    }
}
