using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bilomax.Generic.Infrastructure.Domain;
using Hdwih.Jobs.Domain.Core.JobPostings;

namespace Hdwih.Jobs.Domain.Core
{
   public class Organization : EntityBase<int>, IAggregateRoot
   {
       private IList<JobPosting> _postings;
       public Organization()
       {
           _postings = new List<JobPosting>();
       }
       
        public string Name { get; set; }
        public Address Address { get; set; }

       public IEnumerable<JobPosting> GetAllJobPostings()
       {
           return new List<JobPosting>();
       }
        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
