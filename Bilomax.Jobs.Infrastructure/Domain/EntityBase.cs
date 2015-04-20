using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilomax.Generic.Infrastructure.Domain
{
    /// <summary>
    /// Before persisting an entity, you will call its 
    /// GetBrokenRules method and check for a count of 0. 
    /// The GetBrokenRules method clears the last collection 
    /// of BusinessRules before calling the Validate method, which 
    /// the business entity will implement. The Validate method adds
    /// BusinessRules to the inner collection using the AddBrokenRule 
    /// helper method. 
    /// </summary>
    /// <typeparam name="Tid"></typeparam>
   public abstract class EntityBase<Tid>
    {
       private List<BusinessRule> _brokenRules = new List<BusinessRule>();
       public Tid id { get; set; }
       protected abstract void Validate();
       public IEnumerable<BusinessRule> GetBrokenRules()
       {
           _brokenRules.Clear();
           Validate();
           return _brokenRules;
       }
       protected void AddBrokenRule(BusinessRule businessRule)
       {
           _brokenRules.Add(businessRule);
       }
       public override bool Equals(object entity)
       {
           return entity != null && entity is EntityBase<Tid> && this==(EntityBase<Tid>)entity ;
       }
       public override int GetHashCode()
       {
           return this.id.GetHashCode();
       }
       public static bool operator ==(EntityBase<Tid> entity1, EntityBase<Tid> entity2)
       {
           if((object)entity1==null && (object)entity2==null)
           {
               return true;
           }
           if ((object)entity1==null || (object)entity2==null)
           {
               return false;
           }

           if(entity1.id.ToString()==entity2.id.ToString())
           {
               return true;
           }


           return false;
       }

       public static bool operator !=(EntityBase<Tid> entity1,EntityBase<Tid> entity2)
       {
           return (!(entity1 == entity2));
       }
    }
}
