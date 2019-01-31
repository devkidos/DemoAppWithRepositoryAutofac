using DemoAppWithRepositoryAutofac.Core;
using DemoAppWithRepositoryAutofac.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoAppWithRepositoryAutofac.API.Controllers
{
   [Authorize]
    public class CountryController : ApiController
    {
        
        ICountryService countryService;
        public CountryController(ICountryService _countryService)
        {
            countryService = _countryService;
        }

        [HttpGet]
        [Route("countries")]
        public HttpResponseMessage GetCountries()
        {
            var employees = countryService.GetCountries();
            return Request.CreateResponse(HttpStatusCode.OK, employees);
        }
    }
}
