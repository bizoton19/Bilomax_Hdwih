namespace Hdwih.Jobs.Repository.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JobPostingNote")]
    public partial class JobPostingNote
    {
        [Key]
        public long NoteId { get; set; }

        public long JobPostingId { get; set; }

        [Required]
        [StringLength(40)]
        public string NoteTitle { get; set; }

        [Required]
        [StringLength(500)]
        public string NoteBody { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime InsertDateTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime LastUpdateTime { get; set; }

        public virtual JobPosting JobPosting { get; set; }
    }
}
