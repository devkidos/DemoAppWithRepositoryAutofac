using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoAppWithRepositoryAutofac.Core;
using DemoAppWithRepositoryAutofac.ViewModel;

namespace DemoAppWithRepositoryAutofac.Services.Services
{
    public class LoginService
    {
        public static VMLogin LoginByUsernamePassword(string Username, string Password)
        {
            return new VMLogin { UserId = Guid.NewGuid(), Username = "Demo" };
        }
    }
}
