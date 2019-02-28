using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppWithRepositoryAutofac.Common
{
    public interface IHttpClientService
    {
        T Get<T>(string apiMethod, string token);
        T Put<T>(string apiMethod, T model, string token);
        T Post<T>(string apiMethod, ExpandoObject dynamicObject, string token);
        T PostFormUrlEncoded<T>(string apiMethod, Dictionary<string, string> httpHeaderParams);

        Task<T> GetAsync<T>(string apiMethod, string token);
        Task<T> PutAsync<T>(string apiMethod, T model, string token);
        Task<T> PostAsync<T>(string apiMethod, ExpandoObject dynamicObject, string token);
        Task<T> PostFormUrlEncodedAsync<T>(string apiMethod, Dictionary<string, string> httpHeaderParams); 
    }
}
