namespace Hdwih.Jobs.Repository.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserAccountProfile")]
    public partial class UserAccountProfile
    {
        [Key]
        public long AccountId { get; set; }

        public long UserId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ClosedDate { get; set; }

        public int? AccountTypeId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime InsertDateTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime LastUpdateTime { get; set; }

        public virtual Person Person { get; set; }
    }
}
