using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoAppWithRepositoryAutofac.ViewModel.Request;
using DemoAppWithRepositoryAutofac.ViewModel.Response;

namespace DemoAppWithRepositoryAutofac.Services.Contracts
{
    public interface IService<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAllRecords(ApiRequest apiRequest);
        TEntity GetById(object id);
        Response<TEntity> Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
