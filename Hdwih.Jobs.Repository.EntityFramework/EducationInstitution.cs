//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hdwih.Jobs.Repository.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class EducationInstitution
    {
        public EducationInstitution()
        {
            this.Addresses = new HashSet<Address>();
            this.PersonEducations = new HashSet<PersonEducation>();
        }
    
        public long EducationInstitutionId { get; set; }
        public string InstitutionName { get; set; }
        public System.DateTime InsertDateTime { get; set; }
        public System.DateTime LastUpdateTime { get; set; }
    
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<PersonEducation> PersonEducations { get; set; }
    }
}