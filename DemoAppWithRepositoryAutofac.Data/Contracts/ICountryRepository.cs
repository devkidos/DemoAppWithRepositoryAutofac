using DemoAppWithRepositoryAutofac.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppWithRepositoryAutofac.Data.Contracts
{
    public interface ICountryRepository : IDataRepository<Country>
    {
    }
}
