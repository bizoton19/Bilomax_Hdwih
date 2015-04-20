using Bilomax.Generic.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hdwih.Jobs.Domain.Core.RepositoryInterfaces
{
    public interface IPersonRepository : IReadOnlyRepository<Person, int>
    {

    }
}
