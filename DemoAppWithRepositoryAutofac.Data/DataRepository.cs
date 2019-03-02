using DemoAppWithRepositoryAutofac.Core;
using DemoAppWithRepositoryAutofac.ViewModel.Request;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppWithRepositoryAutofac.Data
{
    public class DataRepository<TEntity> : IDataRepository<TEntity> where TEntity : class
    {
        private readonly IDbContext _context;
        private IDbSet<TEntity> _dbset;

        //public IQueryable<TEntity> Table => throw new NotImplementedException();

        //public DataRepository(IDbContext context)
        //{
        //    this._context = context;
        //}

        //public virtual IQueryable<TEntity> Table
        //{
        //    get
        //    {
        //        return this._entities;
        //    }
        //}

        //private IDbSet<TEntity> Entities
        //{
        //    get
        //    {
        //        if (_entities == null)
        //        {
        //            _entities = _context.Set<TEntity>();
        //            _dbset = context.Set<T>();
        //        }
        //        return _entities;
        //    }
        //}
        //public void Delete(TEntity entity)
        //{

        //    try
        //    {
        //        if (entity == null)
        //        {
        //            throw new ArgumentNullException("entity");
        //        }
        //        this.Entities.Remove(entity);
        //        this._context.SaveChanges();
        //    }
        //    catch (DbEntityValidationException dbEx)
        //    {
        //        var msg = string.Empty;

        //        foreach (var validationErrors in dbEx.EntityValidationErrors)
        //        {
        //            foreach (var validationError in validationErrors.ValidationErrors)
        //            {
        //                msg += Environment.NewLine + string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
        //            }
        //        }
        //        var fail = new Exception(msg, dbEx);
        //        throw fail;
        //    }

        //}

        //public TEntity GetById(object id)
        //{

        //    return this.Entities.Find(id);

        //}

        //public void Insert(TEntity entity)
        //{

        //    try
        //    {
        //        if (entity == null)
        //        {
        //            throw new ArgumentNullException("entity");
        //        }
        //        this.Entities.Add(entity);
        //        this._context.SaveChanges();
        //    }
        //    catch (DbEntityValidationException dbEx)
        //    {
        //        var msg = string.Empty;

        //        foreach (var validationErrors in dbEx.EntityValidationErrors)
        //        {
        //            foreach (var validationError in validationErrors.ValidationErrors)
        //            {
        //                msg += string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage) + Environment.NewLine;
        //            }
        //        }

        //        var fail = new Exception(msg, dbEx);
        //        throw fail;
        //    }

        //}

        //public IEnumerable<TEntity> RetrieveAllRecordsAsync()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(TEntity entity)
        //{

        //    try
        //    {
        //        if (entity == null)
        //        {
        //            throw new ArgumentNullException("entity");
        //        }
        //        this._context.SaveChanges();
        //    }
        //    catch (DbEntityValidationException dbEx)
        //    {
        //        var msg = string.Empty;
        //        foreach (var validationErrors in dbEx.EntityValidationErrors)
        //        {
        //            foreach (var validationError in validationErrors.ValidationErrors)
        //            {
        //                msg += Environment.NewLine + string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
        //            }
        //        }
        //        var fail = new Exception(msg, dbEx);
        //        throw fail;
        //    }

        //}
        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(object id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetQuery()
        {
            throw new NotImplementedException();
        }

        public TEntity Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> RetrieveAllRecordsAsync(ApiRequest apiRequest)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
