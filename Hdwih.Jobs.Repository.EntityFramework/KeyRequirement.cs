namespace Hdwih.Jobs.Repository.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KeyRequirement
    {
        [Key]
        public long RequirementId { get; set; }

        public long JobPostingId { get; set; }

        [Required]
        [StringLength(50)]
        public string RequirementDescription { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime InsertDateTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime LastUpdateTime { get; set; }

        public virtual JobPosting JobPosting { get; set; }
    }
}
