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
            dynamicObject.PageNumber = 0;
            dynamicObject.PageSize = 10;
            dynamicObject.Search = "";
            var data = SearchCountries(dynamicObject);

            return View(data);
        }

        private List<VMCountry> SearchCountries(ExpandoObject dynamicObject)
        {
            string apiUrl = "http://localhost/DemoAppWithRepositoryAutofac.API/";


            var rersult = httpClientService.Post<List<VMCountry>>(apiUrl, dynamicObject,  null);

            //string inputJson = JsonConvert.SerializeObject(dynamicObject);// (new JavaScriptSerializer()).Serialize(input);
            //WebClient client = new WebClient();
            //client.Headers["Content-type"] = "application/json";
            //client.Encoding = Encoding.UTF8;
            //string json = client.UploadString(apiUrl + "countries", inputJson);
            //List<VMCountry> countries = (new JavaScriptSerializer()).Deserialize<List<VMCountry>>(json);
            return rersult;
        }
    }
}