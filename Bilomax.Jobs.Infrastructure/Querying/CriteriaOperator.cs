using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilomax.Generic.Infrastructure.Querying
{
   public enum CriteriaOperator
    {
       Equal,
       LesserThanOrEqual,
       Between,
       LesserThan,
       GreaterThan,
       GreaterThanOrEqual,
       Contains,
       BeginsWith,
       EndsWith,
       IsNull,
       IsTrue,
       IsFalse,
       NotApplicable
       
    }
}
