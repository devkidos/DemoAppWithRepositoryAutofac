using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoAppWithRepositoryAutofac.Core;
using DemoAppWithRepositoryAutofac.Data.Contracts;

namespace DemoAppWithRepositoryAutofac.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DemoAppWithRepositoryAutofacDataContext dataContext;


        public UserRepository(DemoAppWithRepositoryAutofacDataContext context)
        {
            this.dataContext = context;
        }
        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public User GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(User entity)
        {
            throw new NotImplementedException();
        }
  
        public IEnumerable<User> RetrieveAllRecordsAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
        public static User LoginUser(string username, string password)
        {
            using (var db = new DemoAppWithRepositoryAutofacDataContext())
            {
                return db.Users.Where(u => u.Username == username && u.Password == password).FirstOrDefault();
            } 
        }
    }
}
