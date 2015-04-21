namespace Hdwih.Jobs.Repository.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhoneNumber")]
    public partial class PhoneNumber
    {
        public long PhoneNumberId { get; set; }

        [Required]
        [StringLength(4)]
        public string AreaCode { get; set; }

        public short CountryCode { get; set; }

        public long Number { get; set; }

        [Required]
        [StringLength(1)]
        public string PhoneType { get; set; }

        public long PersonId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime InsertDateTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime LastUpdateTime { get; set; }

        public virtual Person Person { get; set; }
    }
}
