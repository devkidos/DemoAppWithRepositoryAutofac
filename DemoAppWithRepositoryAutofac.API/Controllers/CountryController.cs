using DemoAppWithRepositoryAutofac.Core;
using DemoAppWithRepositoryAutofac.Services.Contracts;
using DemoAppWithRepositoryAutofac.ViewModel;
using DemoAppWithRepositoryAutofac.ViewModel.Request;
using DevKido.Utilities;
using DevKido.Utilities.DataTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Results;

namespace DemoAppWithRepositoryAutofac.API.Controllers
{
    public class DataTableResponse<T>
    {
        public int draw { get; set; }
        public long recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<T> data { get; set; }
        public string error { get; set; }
    }
    //[Authorize]
    public class CountryController : ApiController
    { 
        ICountryService countryService;
        public CountryController(ICountryService _countryService)
        {
            countryService = _countryService;
        }

        [HttpPost]
        [Route("countries")]
        public HttpResponseMessage GetCountries(ApiRequest apiRequest)
        {
            var countries = countryService.GetCountries(apiRequest);
            return Request.CreateResponse(HttpStatusCode.OK, countries);
        }

        [HttpPost] 
        public HttpResponseMessage Post(VMCountry vMCountry)
        {
            var response = countryService.Insert(vMCountry);
            return Request.CreateResponse(response);
        }

        [HttpGet]
        [Route("GetCountryList")]
        public DTResult<VMCountry> GetCountryList(DTParameters param)
        { 
            var datalist = countryService.GetCountryList(param);
             
            return new DTResult<VMCountry>
            {
                recordsTotal =datalist.Datas.recordsTotal,
                recordsFiltered = datalist.Datas.recordsTotal,
                data = datalist.Datas.data.ToList()
            }; 
        } 
        
    }
}
