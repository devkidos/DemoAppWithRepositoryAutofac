using DemoAppWithRepositoryAutofac.Core;
using DemoAppWithRepositoryAutofac.ViewModel.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppWithRepositoryAutofac.Data
{
    public interface IDataRepository<TEntity> where TEntity : class 
    {
        IEnumerable<TEntity> RetrieveAllRecordsAsync(ApiRequest apiRequest);
        TEntity GetById(object id);
        TEntity Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        // IQueryable<TEntity> Table { get; }
        IQueryable<TEntity> GetQuery();
    }
}
