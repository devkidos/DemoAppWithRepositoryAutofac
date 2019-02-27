using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using DemoAppWithRepositoryAutofac.ViewModel;
using DemoAppWithRepositoryAutofac.ViewModel.Request;

namespace DemoAppWithRepositoryAutofac.Web.Controllers
{
    public class CountryController : Controller
    { 
        public ActionResult Index()
        {
            var data = SearchCountries("");
            return View();
        }

        private static List<VMCountry> SearchCountries(string name)
        {
            string apiUrl = "http://localhost/DemoAppWithRepositoryAutofac.API/";
            var input = new
            {
                PageNumber= 0,
                PageSize= 10,
                Search= ""
            };
            string inputJson = (new JavaScriptSerializer()).Serialize(input);
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.UploadString(apiUrl + "countries", inputJson);
            List<VMCountry> countries = (new JavaScriptSerializer()).Deserialize<List<VMCountry>>(json);
            return countries;
        }
    }
}