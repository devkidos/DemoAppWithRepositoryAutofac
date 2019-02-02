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
            this.dataContext.Country.Add(entity);
            this.dataContext.SaveChanges();
        }

        public IEnumerable<Country> RetrieveAllRecordsAsync()
        {
            return this.dataContext.Country.ToList();
        }

        public IEnumerable<Country> Search()
        {
            return this.dataContext.Country.Where(a=>a.CountryName.ToLower().Contains("u")).ToList();
        }

        public void Update(Country entity)
        {
            throw new NotImplementedException();
        }
    }
}
