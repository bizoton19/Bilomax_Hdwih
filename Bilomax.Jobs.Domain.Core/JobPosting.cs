using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hdwih.Jobs.Domain.Core
{
  public  class JobPosting
    {
      public int PostingId { get; set; }
      JobPosting Title { get; set; }
     
      PostingDetails PostingDetails { get; set; }
    }
}
