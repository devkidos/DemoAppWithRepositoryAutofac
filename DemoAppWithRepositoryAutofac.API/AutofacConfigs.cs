using Autofac;
using Autofac.Integration.WebApi;
using DemoAppWithRepositoryAutofac.Data;
using DemoAppWithRepositoryAutofac.Data.Contracts;
using DemoAppWithRepositoryAutofac.Data.Repositories;
using DemoAppWithRepositoryAutofac.Services.Contracts;
using DemoAppWithRepositoryAutofac.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace DemoAppWithRepositoryAutofac.API
{
    public class AutofacConfigs
    {
        public static void Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            //Add Service mapping
            builder.RegisterType<CountryService>().As<ICountryService>();

            //Add data mapping
            //builder.RegisterGeneric(typeof(DataRepository<>)).As(typeof(IDataRepository<>)).InstancePerDependency();
            builder.RegisterType<CountryRepository>().As<ICountryRepository>();


            var container = builder.Build();
            var resolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = resolver;
        }
    }
}