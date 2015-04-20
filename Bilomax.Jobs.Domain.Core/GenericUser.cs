using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hdwih.Jobs.Domain.Core
{
  public  class GenericUser: Person
    {
        public UserAccountProfile UserAccount { get; set; }
        
        
    }
}
