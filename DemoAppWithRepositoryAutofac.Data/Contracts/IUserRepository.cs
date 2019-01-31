using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoAppWithRepositoryAutofac.Core;

namespace DemoAppWithRepositoryAutofac.Data.Contracts
{
    public interface IUserRepository : IDataRepository<User>
    {
        User Login(string username, string password);
    }
}
