using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoAppWithRepositoryAutofac.ViewModel.Request;

namespace DemoAppWithRepositoryAutofac.Services.Contracts
{
    public interface IService<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAllRecords(ApiRequest apiRequest);
        TEntity GetById(object id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
