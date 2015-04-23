using System;
using System.Collections.Generic;
using Bilomax.Generic.Infrastructure.Domain;

namespace Hdwih.Jobs.Domain.Core.Resume
{
    public class PersonResumeType : EntityBase<int>
    {
        //public PersonResumeType()
       // {
        //     PersonResumes = new HashSet<PersonResume>();
        //}

        public short ResumeTypeId { get; set; }
        public string ResumeTypeTitle { get; set; }
        public string ResumeTypeDescription { get; set; }
       // public virtual ICollection<PersonResume> PersonResumes { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}