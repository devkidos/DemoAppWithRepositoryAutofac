using DemoAppWithRepositoryAutofac.Core;
using DemoAppWithRepositoryAutofac.Services.Contracts;
using DemoAppWithRepositoryAutofac.ViewModel;
using DemoAppWithRepositoryAutofac.ViewModel.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoAppWithRepositoryAutofac.API.Controllers
{
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
    }
}
