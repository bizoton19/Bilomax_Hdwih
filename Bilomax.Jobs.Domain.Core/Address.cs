using Bilomax.Generic.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hdwih.Jobs.Domain.Core
{
   public  class Address: EntityBase<int>
    {
        public int AddressId { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public Country Country { get; set; }



        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
