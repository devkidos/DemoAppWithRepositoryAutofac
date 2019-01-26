using DemoAppWithRepositoryAutofac.Core;
using DemoAppWithRepositoryAutofac.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppWithRepositoryAutofac.Data.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly DemoAppWithRepositoryAutofacDataContext dataContext;


        public CountryRepository(DemoAppWithRepositoryAutofacDataContext context)
        {
            this.dataContext = context;
        }

        public void Delete(Country entity)
        {
            throw new NotImplementedException();
        }

        public Country GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Country entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Country> RetrieveAllRecordsAsync()
        {
            return this.dataContext.Countries.ToList();
        }

        public IEnumerable<Country> Search()
        {
            return this.dataContext.Countries.Where(a=>a.CountryName.Contains("u"));
        }

        public void Update(Country entity)
        {
            throw new NotImplementedException();
        }
    }
}
