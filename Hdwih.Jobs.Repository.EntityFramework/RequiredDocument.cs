namespace Hdwih.Jobs.Repository.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RequiredDocument")]
    public partial class RequiredDocument
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long RequiredDocumentId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long JobPostingId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string RequiredDocumentName { get; set; }

        [StringLength(500)]
        public string RequiredDocumentDescription { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "datetime2")]
        public DateTime InsertDateTime { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "datetime2")]
        public DateTime LastUpdateTime { get; set; }

        public virtual JobPosting JobPosting { get; set; }
    }
}
