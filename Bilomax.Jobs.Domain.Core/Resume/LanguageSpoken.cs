using Bilomax.Generic.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hdwih.Jobs.Domain.Core.Resume
{
   public class LanguageSpoken: EntityBase<int>, IResumeAttribute
    {
       
        public string  Name { get; set; }

       protected override void Validate()
       {
           throw new NotImplementedException();
       }
    }
}
