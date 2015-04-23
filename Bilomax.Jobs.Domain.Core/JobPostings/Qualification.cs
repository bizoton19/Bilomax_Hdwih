#region

using System;
using Bilomax.Generic.Infrastructure.Domain;

#endregion

namespace Hdwih.Jobs.Domain.Core.JobPostings
{
    public class Qualification : EntityBase<int>, IPostingAttribute
    {
        public string Name { get; set; }
        public long JobPostingId { get; set; }
        public string QualificationTitle { get; set; }
        public string QualificationDescription { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}