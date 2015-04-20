using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bilomax.Generic.Infrastructure.Domain;

namespace Hdwih.Jobs.Domain.Core
{
  public  class JobPosting: EntityBase<int>, IAggregateRoot
  {
      public int PostingId { get; set; }
      JobPosting Title { get; set; }
     
      PostingDetails PostingDetails { get; set; }

      protected override void Validate()
      {
          throw new NotImplementedException();
      }
  }
}
