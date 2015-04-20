using Bilomax.Generic.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hdwih.Jobs.Domain.Core
{
  public  class PositionDuty: EntityBase<int>
    {
        public string PositionDutyId { get; set; }
        public string DutyDescription { get; set; }


        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
