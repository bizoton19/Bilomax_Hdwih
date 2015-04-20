using Bilomax.Generic.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hdwih.Jobs.Domain.Core
{
    public abstract class Person : EntityBase<int>,IAggregateRoot
    {
        
        public int PersonId { get; set;}
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public Gender Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string LastName { get; set; }
        public List<Address> CurrentAddresses { get; set; } 
        public string EmailAddress { get; set; }
        public List<PhoneNumber> CurrentPhoneNumbers { get; set; }
        

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
