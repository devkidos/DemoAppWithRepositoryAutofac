using DemoAppWithRepositoryAutofac.Core;
using DemoAppWithRepositoryAutofac.Data.Contracts;
using DemoAppWithRepositoryAutofac.ViewModel.Request;
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

        public IQueryable<Country> GetQuery()
        {
            return this.dataContext.Country.AsQueryable();
               
        }

        public Country Insert(Country entity)
        {
            this.dataContext.Country.Add(entity);
            var returnValue = this.dataContext.SaveChanges();
            if(returnValue >0)
            {
                return entity;
            }
            return new Country();
        }

        public IEnumerable<Country> RetrieveAllRecordsAsync(ApiRequest apiRequest)
        {
            return this.dataContext.Country
                .Where(c=>c.CountryName.Contains(apiRequest.Search) || (apiRequest.Search == "" || apiRequest.Search == null))
               .OrderBy(o => o.CountryName).ToList();
           // .OrderBy(o => o.CountryName).Skip(apiRequest.PageNumber * apiRequest.PageSize).Take(apiRequest.PageSize).ToList();
        }

        public IEnumerable<Country> Search()
        {
            // return this.dataContext.Country.Where(a=>a.CountryName.ToLower().Contains("u")).ToList();
            return this.dataContext.Country.ToList();
        }

        public void Update(Country entity)
        {
            throw new NotImplementedException();
        }
 
    }
}
