using DemoAppWithRepositoryAutofac.Core;
using DemoAppWithRepositoryAutofac.Data;
using DemoAppWithRepositoryAutofac.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppWithRepositoryAutofac.Services.Services
{
    public class CountryService : ICountryService
    {
        private IDataRepository<Country> countryRepository; 

        public CountryService(IDataRepository<Country> countryRepository)
        {
            this.countryRepository = countryRepository; 
        }

        public void DeleteCountry(Country user)
        {
            countryRepository.Delete(user);
        }

        public IQueryable<Country> GetCountries()
        {
            return countryRepository.Table;
        }

        public Country GetCountry(Guid id)
        {
            return countryRepository.GetById(id);
        }

        public void InsertCountry(Country user)
        {
            countryRepository.Insert(user);
        }

        public void UpdateCountry(Country user)
        {
            countryRepository.Update(user);
        }
    }
}
