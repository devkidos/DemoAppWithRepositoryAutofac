using DemoAppWithRepositoryAutofac.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppWithRepositoryAutofac.Data
{
    public interface IDataRepository<TEntity> where TEntity : BaseEntity
    {
        IEnumerable<TEntity> RetrieveAllRecordsAsync();
        TEntity GetById(object id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        //IQueryable<TEntity> Table { get; }
    }
}
