using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Models.Repositries
{
   public interface IRepository<TEntity>
   {
        Task<IList<TEntity>> ListAsync();
        TEntity FindAsync(int ? id);
        Task Add(TEntity entity);
        Task Delete(int id);
        List<Property> Search(Property term);
        Task Update(int id, TEntity entity);
    }
}
