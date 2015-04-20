using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bilomax.Generic.Infrastructure.Domain;
using Hdwih.Jobs.Domain.Core.RepositoryInterfaces;


namespace Hdwih.Jobs.Domain.Core
{
   public class HdwihRecruit: GenericUser
   {
       
       IPersonResumeRepository _pRepository;
       private UserAccountProfile _accountProfile;
       public HdwihRecruit (IPersonResumeRepository pRepository)
       {
           _pRepository = pRepository;
          
       }

       public string UserId { get; set; }
       public UserAccountProfile AccountProfile
       {
           get { return _accountProfile; }
           set { _accountProfile = value; }
       }

       public IEnumerable<PersonResume> GetAllResumes()
       {
          return  _pRepository.GetAllResumes();

       }

       public void TagPosting(JobPosting posting, bool tagtype)
       {
           
       }
       public void SignOut()
       {

       }

       public void SignIn()
       {

       }


       public void DeleteAccount()
       {

       }

       public void AddResume()
       {

       }

       public void EditResume()
       {

       }
       public void DeleteResume()
       {

       }

       public void SubscribeToPostingFeeds()
       {
           
       }

       public void UnSubscribeToPostingFeeds()
       {
           
       }

       public void DownloadResume()
       {
           
       }

       public void ForwardResumeTo()
       {
           
       }


    }
}
