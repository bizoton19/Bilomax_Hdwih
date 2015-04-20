using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bilomax.Generic.Infrastructure.Domain;

namespace Hdwih.Jobs.Domain.Core
{
  public  class RequiredDocument:EntityBase<int>
  {
      public string Name { get; set; }
      public string DocumentDescription { get; set; }


      protected override void Validate()
      {
          throw new NotImplementedException();
      }
  }
}
