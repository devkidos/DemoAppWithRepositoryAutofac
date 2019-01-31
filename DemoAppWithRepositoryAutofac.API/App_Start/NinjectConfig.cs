using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DemoAppWithRepositoryAutofac.Data.Contracts;
using DemoAppWithRepositoryAutofac.Data.Repositories;
using DemoAppWithRepositoryAutofac.Services.Contracts;
using DemoAppWithRepositoryAutofac.Services.Services;
using Ninject;

namespace DemoAppWithRepositoryAutofac.API
{
    public static class NinjectConfig
    {
        public static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();

            try
            {
                kernel.Bind<IUserRepository>().To<UserRepository>();
                kernel.Bind<IUserService>().To<UserService>();
                return kernel;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}