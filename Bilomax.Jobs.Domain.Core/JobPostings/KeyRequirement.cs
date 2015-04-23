using System;
using Bilomax.Generic.Infrastructure.Domain;

namespace Hdwih.Jobs.Domain.Core.JobPostings
{
    public class KeyRequirement:EntityBase<int>,IPostingAttribute
    {
        public string Name { get; set; }
        public string RequirementDescription { get; set; }
        

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}