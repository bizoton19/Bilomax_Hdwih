using System;
using System.Collections.Generic;
using Bilomax.Generic.Infrastructure.Domain;

namespace Hdwih.Jobs.Domain.Core.JobPostings
{
    public class JobPostingTitle:EntityBase<int>, IPostingAttribute
    {
        public JobPostingTitle()
        {
        }
        public string Name { get; set; }
        public JobPosting JobPosting { get; set; }
        public DateTime PostingDate { get; set; }
        public string ClosingDate { get; set; }
        public long? OrganizationId { get; set; }
        public bool? IsSecurityClearanceNeeded { get; set; }
        public decimal? MaximumSalary { get; set; }
        public decimal? MinimumSalary { get; set; }
        public string IsTravelRequired { get; set; }
        public Organization Organization { get; set; }
        public string Summary { get; set; }
        public string Benefits { get; set; }


        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}