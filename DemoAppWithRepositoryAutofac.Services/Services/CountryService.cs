using DemoAppWithRepositoryAutofac.Core;
using DemoAppWithRepositoryAutofac.Data;
using DemoAppWithRepositoryAutofac.Data.Contracts;
using DemoAppWithRepositoryAutofac.Services.Contracts;
using DemoAppWithRepositoryAutofac.ViewModel;
using DemoAppWithRepositoryAutofac.ViewModel.Request;
using DemoAppWithRepositoryAutofac.ViewModel.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppWithRepositoryAutofac.Services.Services
{
    public class CountryService : ICountryService
    { 
        private ICountryRepository  countryRepository;

        public CountryService(ICountryRepository countryRepository)
        { 
            this.countryRepository = countryRepository;
        }

        public void Delete(VMCountry entity)
        {
            throw new NotImplementedException();
            // countryRepository.Delete(user);
        }
 

        public IEnumerable<VMCountry> GetAllRecords(ApiRequest apiRequest)
        {
            //var data = ccountryRepository.Search();  //Custom method
            var data= countryRepository.RetrieveAllRecordsAsync(apiRequest);  //Generic Method 

            var datas = AutoMapper.Mapper.Map<IEnumerable<Country>, IEnumerable<VMCountry>>(data);
            return datas;
        }

        public VMCountry GetById(object id)
        {
            throw new NotImplementedException();
        }

        public Response<VMCountry> GetCountries(ApiRequest apiRequest)
        {
            int maxRows = 10;
            Response<VMCountry> response = new Response<VMCountry>();
            // var data =  ccountryRepository.Search();  //Custom method
            var data =  countryRepository.RetrieveAllRecordsAsync(apiRequest);  //Generic Method 

            var datas = AutoMapper.Mapper.Map<IEnumerable<Country>, IEnumerable<VMCountry>>(data);
            response.Datas = datas.OrderBy(o => o.CountryName).Skip((apiRequest.PageNumber-1) * apiRequest.PageSize).Take(apiRequest.PageSize).ToList(); ;
            double pageCount = (double)((decimal)datas.Count() / Convert.ToDecimal(maxRows));
            response.PageCount = (int)Math.Ceiling(pageCount);

            response.CurrentPage = apiRequest.PageNumber;
            return response;
        }

        public Country GetCountry(Guid id)
        {
            // return countryRepository.GetById(id);
            return new Country();
        }

        public Response<VMCountry> Insert(VMCountry entity)
        {
            Response<VMCountry> response = new Response<VMCountry>();
            try
            {
                entity.CountryId = Guid.NewGuid();
                var model = AutoMapper.Mapper.Map<VMCountry, Country>(entity);
                var data = countryRepository.Insert(model);
                if (data != null)
                {
                    response.Code = "success";
                    response.Data = entity;
                }
            }
            catch (Exception ex)
            {
                response.Code = "fail";
                response.Message = ex.Message;
            } 
            return response;
        }

        public void InsertCountry(Country user)
        {
            countryRepository.Insert(user);
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
