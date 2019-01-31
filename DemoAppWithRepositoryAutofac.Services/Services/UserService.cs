﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoAppWithRepositoryAutofac.Core;
using DemoAppWithRepositoryAutofac.Data.Contracts;
using DemoAppWithRepositoryAutofac.Services.Contracts;
using DemoAppWithRepositoryAutofac.ViewModel;

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

        public IEnumerable<VMLogin> GetAllRecords()
        {
            throw new NotImplementedException();
        }

        public VMLogin GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(VMLogin entity)
        {
            throw new NotImplementedException();
        }

        public VMLogin LoginByUsernamePassword(string username, string password)
        {
            var data = userRepository.Login(username, password);  

            var datas = AutoMapper.Mapper.Map<User, VMLogin>(data);
            return datas; 
        }

        public void Update(VMLogin entity)
        {
            throw new NotImplementedException();
        }
    }
}