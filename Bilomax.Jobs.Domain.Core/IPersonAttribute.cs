using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hdwih.Jobs.Domain.Core
{
   public interface IPersonAttribute
   {
       string Name { get; set; }
       int Id { get; set; }
   }
}
