namespace Hdwih.Jobs.Repository.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PersonOrganization")]
    public partial class PersonOrganization
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long OrganizationId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PersonId { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "datetime2")]
        public DateTime ContactDesignatedStartDate { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "datetime2")]
        public DateTime ContactDesignatedEndDate { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RelationshipType { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime InsertDateTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? LastUpdateTime { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual Person Person { get; set; }

        public virtual RelationshipType RelationshipType1 { get; set; }
    }
}
