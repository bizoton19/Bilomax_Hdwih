namespace Hdwih.Jobs.Repository.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RelationshipType")]
    public partial class RelationshipType
    {
        public RelationshipType()
        {
            PersonOrganizations = new HashSet<PersonOrganization>();
            PersonReferences = new HashSet<PersonReference>();
        }

        public int RelationshipTypeId { get; set; }

        [Required]
        [StringLength(30)]
        public string RelationshipTypeName { get; set; }

        [StringLength(70)]
        public string RelationshipTypeDescription { get; set; }

        public DateTime InsertDateTime { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public virtual ICollection<PersonOrganization> PersonOrganizations { get; set; }

        public virtual ICollection<PersonReference> PersonReferences { get; set; }
    }
}
