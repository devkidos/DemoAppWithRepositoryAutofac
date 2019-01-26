using DemoAppWithRepositoryAutofac.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppWithRepositoryAutofac.Services.Contracts
{
    public interface ICountryService
    {
        IEnumerable<Country> GetCountries();
        Country GetCountry(Guid id);
        void InsertCountry(Country user);
        void UpdateCountry(Country user);
        void DeleteCountry(Country user);
    }
}
