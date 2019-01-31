using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoAppWithRepositoryAutofac.Core;
using DemoAppWithRepositoryAutofac.Data.Repositories;
using DemoAppWithRepositoryAutofac.ViewModel;

namespace DemoAppWithRepositoryAutofac.Services.Services
{
    public class LoginService
    {
        public static VMLogin LoginByUsernamePassword(string Username, string Password)
        {
            var data = UserRepository.LoginUser(Username, Password);
            var datas = AutoMapper.Mapper.Map<User, VMLogin>(data);
            return datas;
        }
    }
}
