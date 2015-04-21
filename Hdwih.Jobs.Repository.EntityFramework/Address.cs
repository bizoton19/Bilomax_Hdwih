namespace Hdwih.Jobs.Repository.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Address")]
    public partial class Address
    {
        public Address()
        {
            PersonAddresses = new HashSet<PersonAddress>();
        }

        public long AddressId { get; set; }

        public long? OrganizationId { get; set; }

        public long? EducationInstituationId { get; set; }

        [Required]
        [StringLength(15)]
        public string AddressName { get; set; }

        public short AddressType { get; set; }

        [Required]
        [StringLength(100)]
        public string StreetAddress { get; set; }

        [Required]
        [StringLength(20)]
        public string City { get; set; }

        [Required]
        [StringLength(12)]
        public string PostalCode { get; set; }

        public int CountryId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime InsertDateTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime LastUpdateTimeStamp { get; set; }

        public virtual EducationInstitution EducationInstitution { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual ICollection<PersonAddress> PersonAddresses { get; set; }
    }
}
