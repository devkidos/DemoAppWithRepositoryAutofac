﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DemoAppWithRepositoryAutofac.Common
{
    public partial class HttpClientService : IHttpClientService
    {
        public T Get<T>(string apiUrl, string token)
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

                    Uri uri = new Uri(apiUrl);
                    HttpResponseMessage httpResponseMessage = httpClient.GetAsync(uri).Result;
                    string response = httpResponseMessage.Content.ReadAsStringAsync().Result;

                    return JsonConvert.DeserializeObject<T>(response);
                }
            }
            catch
            {
                throw;
            }
        }
        public T Put<T>(string apiUrl, T model, string token)
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

                    Uri uri = new Uri(apiUrl);
                    string jsonBody = JsonConvert.SerializeObject(model);
                    var stringContent = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                    var result = httpClient.PutAsync(uri, stringContent).Result;

                    string response = result.Content.ReadAsStringAsync().Result;

                    return JsonConvert.DeserializeObject<T>(response);

                }
            }
            catch { throw; }
        }

        public T Post<T>(string apiUrl, ExpandoObject dynamicObject, string token = null)
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    if(!string.IsNullOrEmpty(token))
                        httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

                    Uri uri = new Uri(apiUrl);
                    string jsonBody = JsonConvert.SerializeObject(dynamicObject);
                    var stringContent = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                    var result = httpClient.PostAsync(uri, stringContent).Result;

                    string response = result.Content.ReadAsStringAsync().Result;

                    return JsonConvert.DeserializeObject<T>(response);

                }
            }
            catch { throw; }
        }
        public T PostFormUrlEncoded<T>(string url, Dictionary<string, string> httpHeaderParams)
        {
            using (var httpClient = new HttpClient())
            {
                using (var content = new FormUrlEncodedContent(httpHeaderParams))
                {
                    content.Headers.Clear();
                    content.Headers.Add("Content-Type", "application/x-www-form-urlencoded");

                    HttpResponseMessage response = httpClient.PostAsync(url, content).Result;

                    var responseResult = response.Content.ReadAsStringAsync().Result;

                    return JsonConvert.DeserializeObject<T>(responseResult);
                }
            }
        }
        public async Task<T> GetAsync<T>(string apiUrl, string token)
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

                    Uri uri = new Uri(apiUrl);
                    HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(uri);
                    string response = await httpResponseMessage.Content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<T>(response);
                }
            }
            catch
            {
                throw;
            }
        }
        public async Task<T> PutAsync<T>(string apiUrl, T model, string token)
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

                    Uri uri = new Uri(apiUrl);
                    string jsonBody = JsonConvert.SerializeObject(model);
                    var stringContent = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                    var result = await httpClient.PutAsync(uri, stringContent);

                    string response = await result.Content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<T>(response);

                }
            }
            catch { throw; }
        }
        public async Task<T> PostAsync<T>(string apiUrl, ExpandoObject dynamicObject, string token = null)
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    if (!string.IsNullOrEmpty(token))
                        httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

                    Uri uri = new Uri(apiUrl);
                    string jsonBody = JsonConvert.SerializeObject(dynamicObject);
                    var stringContent = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                    var result = await httpClient.PutAsync(uri, stringContent);

                    string response = await result.Content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<T>(response);

                }
            }
            catch { throw; }
        }
        public async Task<T> PostFormUrlEncodedAsync<T>(string url, Dictionary<string, string> httpHeaderParams)
        {
            using (var httpClient = new HttpClient())
            {
                using (var content = new FormUrlEncodedContent(httpHeaderParams))
                {
                    content.Headers.Clear();
                    content.Headers.Add("Content-Type", "application/x-www-form-urlencoded");

                    HttpResponseMessage response = await httpClient.PostAsync(url, content);

                    var responseResult = await response.Content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<T>(responseResult);
                }
            }
        }


    }
}
