using Bilomax.Generic.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hdwih.Jobs.Domain.Core.Resume
{
   public class EducationInstitutation:EntityBase<int>
    {
        
        public string  Name { get; set; }
        public Address Address { get; set; }

       protected override void Validate()
       {
           throw new NotImplementedException();
       }
    }
}
