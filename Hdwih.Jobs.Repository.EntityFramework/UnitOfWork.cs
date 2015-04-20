using Bilomax.Generic.Infrastructure.Domain;
using Bilomax.Generic.Infrastructure.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hdwih.Jobs.Repository.EntityFrameWork
{
   public class UnitOfWork: IUnitOfWork
    {
       private Dictionary<IAggregateRoot, IUnitOfWorkRepository> _amendedEntities;
       private Dictionary<IAggregateRoot, IUnitOfWorkRepository> _removedEntities;
       private Dictionary<IAggregateRoot, IUnitOfWorkRepository> _addedEntities;
       public void RegisterAmended(IAggregateRoot entity, IUnitOfWorkRepository unitOfWorkRepository)
       {
           _amendedEntities = new Dictionary<IAggregateRoot, IUnitOfWorkRepository>();
           _amendedEntities.Add(entity, unitOfWorkRepository);
       }


       public void RegisterNew(IAggregateRoot entity, IUnitOfWorkRepository unitOfWorkRepository)
       {
           throw new NotImplementedException();
       }

       public void RegisterRemoved(IAggregateRoot entity, IUnitOfWorkRepository unitOfWorkRepository)
       {
           throw new NotImplementedException();
       }

       public void Commit()
       {
           throw new NotImplementedException();
       }
    }
}
