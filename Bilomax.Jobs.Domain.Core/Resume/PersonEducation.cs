using Bilomax.Generic.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hdwih.Jobs.Domain.Core.Resume
{
   public class PersonEducation: EntityBase<int>, IResumeAttribute
   {
        public string Name { get; set; }
        public int PersonEducationId { get; set; }
        public EducationInstitutation Institution { get; set; }
        public EducationLevel HighestEducationLevel { get; set; }
        public decimal GradePointAverage { get; set; }
        public string DegreeScpecification { get; set; }
        public List<Award> AwardsReceived { get; set; }

       protected override void Validate()
       {
           throw new NotImplementedException();
       }

       
   }
}
