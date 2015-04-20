using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bilomax.Generic.Infrastructure.Querying;

namespace Bilomax.Generic.Infrastructure.Domain
{
    public interface IReadOnlyRepository<T,Tid> where T : IAggregateRoot
    {
        T FindBy(Tid id);
        IEnumerable<T> FindAll();
        IEnumerable<T> FindBy(Query query);
        IEnumerable<T> FindBy(Query query, int index, int count);
    }
}
