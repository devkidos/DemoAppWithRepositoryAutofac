using DemoAppWithRepositoryAutofac.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppWithRepositoryAutofac.Data
{
    public class DemoAppWithRepositoryAutofacDataContext : DbContext//, IDbContext
    {
        public DemoAppWithRepositoryAutofacDataContext()
            : base("DbConnectionString")
        {
             
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<DemoAppWithRepositoryAutofacDataContext>(null);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Country> Countries{ get; set; }

        public DbSet<User> Users { get; set; }

        //public new IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity
        //{
        //    return base.Set<TEntity>();
        //}
    }
}
