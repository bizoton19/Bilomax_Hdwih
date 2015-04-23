using Bilomax.Generic.Infrastructure.Domain;

namespace Hdwih.Jobs.Domain.Core.JobPostings
{
    public class JobPostingNote:EntityBase<int>, IPostingAttribute
    {
        
        public string Name { get; set; }
        public string NoteBody { get; set; }
        public JobPosting JobPosting { get; set; }

        protected override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}