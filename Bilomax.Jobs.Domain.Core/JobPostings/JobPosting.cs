using System;
using System.Collections.Generic;
using Bilomax.Generic.Infrastructure.Domain;
using Hdwih.Jobs.Domain.Core.JobPostings;
using Hdwih.Jobs.Domain.Core.Resume;

namespace Hdwih.Jobs.Domain.Core.JobPostings
{
    public class JobPosting : EntityBase<int>, IAggregateRoot
    {
        

        public JobPosting()
        {
            JobPostingNotes = new HashSet<JobPostingNote>();
            KeyRequirements = new HashSet<KeyRequirement>();
            Qualifications = new HashSet<Qualification>();
            RequiredDocuments = new HashSet<RequiredDocument>();
            
        }

        public long JobPostingId { get; set; }
        public JobPostingTitle Title { get; set; }
        public string Name { get { return Title.Name; } }
        public Organization Organization { get { return Title.Organization; } }
        public IEnumerable<JobPostingNote> JobPostingNotes { get; set; }
        public IEnumerable<KeyRequirement> KeyRequirements { get; set; }
        public PositionDuty PositionDuty { get; set; }
        public IEnumerable<Qualification> Qualifications { get; set; }
        public IEnumerable<RequiredDocument> RequiredDocuments { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}