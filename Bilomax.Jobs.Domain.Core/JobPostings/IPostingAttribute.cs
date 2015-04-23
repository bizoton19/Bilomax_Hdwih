using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hdwih.Jobs.Domain.Core.JobPostings
{
  public  interface IPostingAttribute
    {
      int Id { get; set; }
      string Name { get; set; }
    }
}
