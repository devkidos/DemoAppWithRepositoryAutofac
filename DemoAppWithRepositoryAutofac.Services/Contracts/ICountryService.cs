using DemoAppWithRepositoryAutofac.Core;
using DemoAppWithRepositoryAutofac.ViewModel;
using DemoAppWithRepositoryAutofac.ViewModel.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppWithRepositoryAutofac.Services.Contracts
{
    public interface ICountryService : IService<VMCountry>
    {
        IEnumerable<VMCountry> GetCountries(ApiRequest apiRequest);
    }
}
