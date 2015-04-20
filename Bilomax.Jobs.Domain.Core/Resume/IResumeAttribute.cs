using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hdwih.Jobs.Domain.Core
{
    public interface IResumeAttribute
    {
         int id { get; set; }
         string Name { get;set;}
    }
}
