using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoAppWithRepositoryAutofac.Core;
using DemoAppWithRepositoryAutofac.Data.Contracts;
using DemoAppWithRepositoryAutofac.Services.Contracts;
using DemoAppWithRepositoryAutofac.ViewModel;
using DemoAppWithRepositoryAutofac.ViewModel.Request;
using DemoAppWithRepositoryAutofac.ViewModel.Response;

namespace DemoAppWithRepositoryAutofac.Services.Services
{
    public class UserService : IUserService
    { 
        private IUserRepository userRepository;
  
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository; 
        }
        public void Delete(VMLogin entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VMLogin> GetAllRecords(ApiRequest apiRequest)
        {
            throw new NotImplementedException();
        }

        public VMLogin GetById(object id)
        {
            throw new NotImplementedException();
        }

        public Response<VMLogin> Insert(VMLogin entity)
        {
            throw new NotImplementedException();
        }

        public void Update(VMLogin entity)
        {
            throw new NotImplementedException();
        }
    }
}
