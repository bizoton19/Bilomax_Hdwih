using Bilomax.Generic.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hdwih.Jobs.Domain.Core
{
   public class PhoneNumber: EntityBase<int>
    {
        public int PhoneNumberId { get; set; }
        public int? CountryCode { get; set; }
        public int? AreaCode { get; set; }
        public int? Number { get; set; }
        public PhoneType PhoneType { get; set; }
       //TODO: implement extension method

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
