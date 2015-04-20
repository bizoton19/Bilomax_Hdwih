using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilomax.Generic.Infrastructure.Domain
{
    /// <summary>
    /// value objects are objects that do not have 
    /// an identity and should be immutable. Value 
    /// objects will inherit from a separate base 
    /// type named ValueObjectBase. Because value 
    /// objects are immutable and cannot be changed, they 
    /// will need to be created in a valid state. If a value object is 
    /// not created in a valid state, an 
    /// exception of ValueObjectIsInvalidException will be throw
    /// </summary>
    public abstract class ValueObjectBase
    {
        private List<BusinessRule> _brokenRules = new List<BusinessRule>();
        public ValueObjectBase()
        {

        }

        protected abstract void Validate();
        public void ThrowExceptionIfInvalid()
        {
            _brokenRules.Clear();
            Validate();
            if(_brokenRules.Count()>0)
            {
                StringBuilder violatedRules = new StringBuilder();
                foreach(BusinessRule businessRule in _brokenRules)
                {
                    violatedRules.AppendLine(businessRule.Rule);
                    throw new ValueObjectIsInvalidException(violatedRules.ToString());
                }
            }
        }
        protected void AddBrokenRule(BusinessRule businessRule)
        {
            _brokenRules.Add(businessRule);
        }
    }
}
