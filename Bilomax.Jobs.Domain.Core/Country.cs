using Bilomax.Generic.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hdwih.Jobs.Domain.Core
{
  public  class Country:EntityBase<int>
    {
        public string Name { get; set; }
        public string Code { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
