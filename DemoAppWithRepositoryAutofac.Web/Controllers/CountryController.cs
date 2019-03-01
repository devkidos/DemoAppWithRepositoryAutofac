using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using DemoAppWithRepositoryAutofac.Common;
using DemoAppWithRepositoryAutofac.ViewModel;
using DemoAppWithRepositoryAutofac.ViewModel.Request;
using DemoAppWithRepositoryAutofac.ViewModel.Response;
using Newtonsoft.Json;

namespace DemoAppWithRepositoryAutofac.Web.Controllers
{
    public class CountryController : Controller
    {
        private IHttpClientService httpClientService;
         
        public CountryController(IHttpClientService httpClientService)
        {
            this.httpClientService = httpClientService;
        }
        public ActionResult Index()
        {
            dynamic dynamicObject = new ExpandoObject();
            dynamicObject.PageNumber = 1;
            dynamicObject.PageSize = 10;
            dynamicObject.Search = "";
            var data = SearchCountries(dynamicObject);

            return View(data);
        }

        [HttpPost]
        public ActionResult Index(int currentPageIndex)
        {
            dynamic dynamicObject = new ExpandoObject();
            dynamicObject.PageNumber = currentPageIndex;
            dynamicObject.PageSize = 10;
            dynamicObject.Search = "";
            var data = SearchCountries(dynamicObject);
            ViewBag.currentPage = currentPageIndex;
            return View(data);
        }

        private Response<VMCountry> SearchCountries(ExpandoObject dynamicObject)
        { 
            var rersult = httpClientService.Post<Response<VMCountry>>("countries", dynamicObject,  null);
             
            return rersult;
        }
    }
}