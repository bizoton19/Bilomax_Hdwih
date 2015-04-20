using Bilomax.Generic.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hdwih.Jobs.Domain.Core
{
   public class Language: EntityBase<int>, IResumeAttribute
    {
        public int LanguageId { get; set; }
        public string  Name { get; set; }

       protected override void Validate()
       {
           throw new NotImplementedException();
       }
    }
}
