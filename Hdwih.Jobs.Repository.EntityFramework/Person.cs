namespace Hdwih.Jobs.Repository.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Person")]
    public partial class Person
    {
        public Person()
        {
            PersonAddresses = new HashSet<PersonAddress>();
            PersonOrganizations = new HashSet<PersonOrganization>();
            PersonReferences = new HashSet<PersonReference>();
            UserAccountProfiles = new HashSet<UserAccountProfile>();
            PhoneNumbers = new HashSet<PhoneNumber>();
            PersonResumes = new HashSet<PersonResume>();
        }

        public long PersonId { get; set; }

        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(70)]
        public string LastName { get; set; }

        [StringLength(25)]
        public string MiddleName { get; set; }

        public short Gender { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime BirthDate { get; set; }

        [Required]
        [StringLength(50)]
        public string EmailAddress { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime InsertDateTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime LastUpdateTime { get; set; }

        public virtual ICollection<PersonAddress> PersonAddresses { get; set; }

        public virtual ICollection<PersonOrganization> PersonOrganizations { get; set; }

        public virtual ICollection<PersonReference> PersonReferences { get; set; }

        public virtual ICollection<UserAccountProfile> UserAccountProfiles { get; set; }

        public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; }

        public virtual ICollection<PersonResume> PersonResumes { get; set; }
    }
}
