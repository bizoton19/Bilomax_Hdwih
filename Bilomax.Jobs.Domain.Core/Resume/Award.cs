using Bilomax.Generic.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hdwih.Jobs.Domain.Core.Resume
{
   public class Award: EntityBase<int>, IResumeAttribute
    {
        
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ReceivedDate { get; set; }
        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
