using System.Collections.Generic;
using Hdwih.Jobs.Domain.Core.JobPostings;
using Hdwih.Jobs.Domain.Core.RepositoryInterfaces;
using Hdwih.Jobs.Domain.Core.Resume;

namespace Hdwih.Jobs.Domain.Core
{
    public class HdwihRecruit : GenericUser
    {
        private readonly IPersonResumeRepository _pRepository;

        public HdwihRecruit(IPersonResumeRepository pRepository)
        {
            _pRepository = pRepository;
        }

        public string UserId { get; set; }
        public UserAccountProfile AccountProfile { get; set; }

        public IEnumerable<PersonResume> GetAllResumes()
        {
            return _pRepository.GetAllResumes();
        }

        public void TagPosting(JobPosting posting, bool tagtype)
        {
        }

        

        public void SubscribeToPostingFeeds()
        {
        }

        public void UnSubscribeToPostingFeeds()
        {
        }

       
    }
}