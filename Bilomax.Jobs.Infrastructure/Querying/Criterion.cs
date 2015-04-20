using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Bilomax.Generic.Infrastructure.Querying
{
  public  class Criterion
    {
      private string _propertyName;
      private object _value;
      private CriteriaOperator _criteriaOperator;

      public Criterion(string propertyName, object value, CriteriaOperator criteriaOperator)
      {
          _propertyName = propertyName;
          _value = value;
          _criteriaOperator = criteriaOperator;
      }

      public string ProperTyName
      {
          get { return _propertyName; }

      }
      public object Value { get{ return _value; }}
      public CriteriaOperator criterionOperator { get { return _criteriaOperator; } }
      
      /// <summary>
      /// Adding the propertyName Resolver to the Criterion class will allow calling code
      /// to create Criterion objects as follow:
      /// Query.Add(Criterion.Create<Customer>(c=>c.LastName, lastName, CriteriaOperator.Equal));
      /// </summary>
      /// <typeparam name="T"></typeparam>
      /// <param name="expression"></param>
      /// <param name="value"></param>
      /// <param name="criteriaOperator"></param>
      /// <returns></returns>
      public static Criterion Create<T> (Expression<Func<T,object>> expression, object value, CriteriaOperator criteriaOperator)
      {
          string propertyName = PropertyNameHelper.ResolvePropertyName<T>(expression);
          Criterion currentCriterion = new Criterion(propertyName, value, criteriaOperator);
          return currentCriterion;
      }
    }
}
