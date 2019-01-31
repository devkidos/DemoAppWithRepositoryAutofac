using DemoAppWithRepositoryAutofac.Core;
using DemoAppWithRepositoryAutofac.Data;
using DemoAppWithRepositoryAutofac.Data.Contracts;
using DemoAppWithRepositoryAutofac.Services.Contracts;
using DemoAppWithRepositoryAutofac.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppWithRepositoryAutofac.Services.Services
{
    public class CountryService : ICountryService
    {
        private IDataRepository<Country>  countryRepository;
        private ICountryRepository  ccountryRepository;

        public CountryService(IDataRepository<Country> countryRepository, ICountryRepository ccountryRepository)
        {
            this.countryRepository = countryRepository;
            this.ccountryRepository = ccountryRepository;
        }

        public void Delete(VMCountry entity)
        {
            throw new NotImplementedException();
            // countryRepository.Delete(user);
        }
 

        public IEnumerable<VMCountry> GetAllRecords()
        {
            //var data = ccountryRepository.Search();  //Custom method
            var data= countryRepository.RetrieveAllRecordsAsync();  //Generic Method 

            var datas = AutoMapper.Mapper.Map<IEnumerable<Country>, IEnumerable<VMCountry>>(data);
            return datas;
        }

        public VMCountry GetById(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VMCountry> GetCountries()
        { 
            var data =  ccountryRepository.Search();  //Custom method
            // return countryRepository.RetrieveAllRecordsAsync();  //Generic Method 

            var datas = AutoMapper.Mapper.Map<IEnumerable<Country>, IEnumerable<VMCountry>>(data);
            return datas;
        }

        public Country GetCountry(Guid id)
        {
            // return countryRepository.GetById(id);
            return new Country();
        }

        public void Insert(VMCountry entity)
        {
            throw new NotImplementedException();
        }

        public void InsertCountry(Country user)
        {
           // countryRepository.Insert(user);
        }

        public void Update(VMCountry entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateCountry(Country user)
        {
            //countryRepository.Update(user);
        } 
    }
}
