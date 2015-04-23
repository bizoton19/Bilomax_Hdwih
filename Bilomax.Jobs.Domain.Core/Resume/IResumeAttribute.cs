using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hdwih.Jobs.Domain.Core.Resume
{
    public interface IResumeAttribute
    {
         int Id { get; set; }
         string Name { get;set;}
    }
}
