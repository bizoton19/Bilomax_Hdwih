using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bilomax.Generic.Infrastructure.Domain;

namespace Hdwih.Jobs.Domain.Core
{
    /// <summary>
    /// This class represents a person's resumeas an object that contains an PositionDutyId, a Title, a list of previous and current positions
    /// held, languages spoken and references
    /// </summary>
   public class PersonResume: EntityBase<int>,IAggregateRoot
    {
       // public int PositionDutyId { get; set; }
        
        public string ResumeName { get; set; }
        public HdwihRecruit HdwihRecruit { get; set; }
        public Gender Gender { get { return this.HdwihRecruit.Gender; } }
        public string[] SkillsOrSpecialties { get; set; }
        public string FirstName { get { return this.HdwihRecruit.FirstName; } }
        public string MiddleName { get { return this.HdwihRecruit.MiddleName; } }
        public string LastName { get { return this.HdwihRecruit.LastName; } }
        public string EmailAddress { get {return this.HdwihRecruit.EmailAddress;}}
        public IEnumerable<Address> PersonAddresses { get { return this.HdwihRecruit.CurrentAddresses; } }
        public IEnumerable<PhoneNumber> PersonPhoneNumbers { get { return this.HdwihRecruit.CurrentPhoneNumbers; } }
        public IEnumerable<EmploymentPosition> EmploymentHistory { get; set; }
        public IEnumerable<Language> LanguagesSpoken { get; set; }
        public IEnumerable<Reference> References { get; set; }
        public IEnumerable<PersonEducation> EducationHistory { get; set; }
        
        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
