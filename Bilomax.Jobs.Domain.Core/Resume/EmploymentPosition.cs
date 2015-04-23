using Bilomax.Generic.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Hdwih.Jobs.Domain.Core.Resume
{
   public class EmploymentPosition: EntityBase<int>, IResumeAttribute
    {
        private bool _isFullTimePosition;
        public int PositionId { get; set; }
        public string Name { get; set; }
        public Address Location { get; set; }
        public string SupervisorName { get; set; }
        public PhoneNumber SupervisorPhoneNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int NumberOfHoursWorkedPerWeek { get; set; }
        public bool IsVolonteerPosition { get; set; }
        public IList<PositionDuty> Duties { get; set; }
        public bool IsCurrentlyAtPosition { get; set; }

        public List<Award> AwardsReceived { get; set; }
        
   
        private void SetEndDate()
        {
            EndDate = IsCurrentlyAtPosition ? DateTime.Today : EndDate;
        }



        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
