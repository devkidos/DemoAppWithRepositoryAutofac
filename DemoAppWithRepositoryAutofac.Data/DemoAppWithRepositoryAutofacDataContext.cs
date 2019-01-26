using DemoAppWithRepositoryAutofac.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppWithRepositoryAutofac.Data
{
    public class DemoAppWithRepositoryAutofacDataContext : DbContext, IDbContext
    {
        public DemoAppWithRepositoryAutofacDataContext()
            : base("DbConnectionString")
        {
             
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity
        {
            return base.Set<TEntity>();
        }
    }
}
