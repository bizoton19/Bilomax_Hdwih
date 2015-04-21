namespace Hdwih.Jobs.Repository.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LanguageSpoken")]
    public partial class LanguageSpoken
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long LanguageId { get; set; }

        public long PersonResumeId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime InsertDateTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime LastUpdateTime { get; set; }

        public virtual PersonResume PersonResume { get; set; }
    }
}
