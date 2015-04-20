using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bilomax.Generic.Infrastructure.Querying
{
   public class PropertyNameHelper
    {
       public static string ResolvePropertyName<T>(Expression<Func<T,object>> expression)
       {
           var memberExpr = expression.Body as MemberExpression;
           if (memberExpr ==null)
           {
               var u = expression.Body as UnaryExpression;
               memberExpr = u.Operand as MemberExpression;
           }

           return memberExpr.ToString().Substring(memberExpr.ToString().IndexOf(".") + 1);
       }
    }
}
