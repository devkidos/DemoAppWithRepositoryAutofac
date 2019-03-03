using DemoAppWithRepositoryAutofac.Core;
using DemoAppWithRepositoryAutofac.ViewModel;
using DemoAppWithRepositoryAutofac.ViewModel.Request;
using DemoAppWithRepositoryAutofac.ViewModel.Response;
using DevKido.Utilities;
using DevKido.Utilities.DataTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppWithRepositoryAutofac.Services.Contracts
{
    public interface ICountryService : IService<VMCountry>
    {
        Response<VMCountry> GetCountries(ApiRequest apiRequest);
        ResultResponse<DTResult<VMCountry>> GetCountryList(DTParameters param);
    }
}
