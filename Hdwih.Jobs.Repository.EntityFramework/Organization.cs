namespace Hdwih.Jobs.Repository.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Organization")]
    public partial class Organization
    {
        public Organization()
        {
            Addresses = new HashSet<Address>();
            JobPostings = new HashSet<JobPosting>();
            PersonOrganizations = new HashSet<PersonOrganization>();
        }

        public long OrganizationId { get; set; }

        [Required]
        [StringLength(100)]
        public string OrganizationName { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime InsertDateTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime LastUpdateTime { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }

        public virtual ICollection<JobPosting> JobPostings { get; set; }

        public virtual ICollection<PersonOrganization> PersonOrganizations { get; set; }
    }
}
