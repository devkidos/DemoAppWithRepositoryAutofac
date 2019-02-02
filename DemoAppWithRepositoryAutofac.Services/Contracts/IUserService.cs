using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoAppWithRepositoryAutofac.Core;
using DemoAppWithRepositoryAutofac.ViewModel;

namespace DemoAppWithRepositoryAutofac.Services.Contracts
{
    public interface IUserService : IService<VMLogin>
    {
         
    }
}
