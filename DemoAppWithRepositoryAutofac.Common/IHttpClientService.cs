﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppWithRepositoryAutofac.Common
{
    public interface IHttpClientService
    {
        T Get<T>(string apiUrl, string token);
        T Put<T>(string apiUrl, T model, string token);
        T Post<T>(string apiUrl, ExpandoObject dynamicObject, string token);
        T PostFormUrlEncoded<T>(string url, Dictionary<string, string> httpHeaderParams);

        Task<T> GetAsync<T>(string apiUrl, string token);
        Task<T> PutAsync<T>(string apiUrl, T model, string token);
        Task<T> PostAsync<T>(string apiUrl, ExpandoObject dynamicObject, string token);
        Task<T> PostFormUrlEncodedAsync<T>(string url, Dictionary<string, string> httpHeaderParams); 
    }
}
