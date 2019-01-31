using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppWithRepositoryAutofac.ViewModel
{
    public class VMLogin
    {
        public Guid UserId { get; set; }
         
        public string usertype { get; set; }
         
        public string Username { get; set; }
         
        public string Password { get; set; }
           
        public string FirstName { get; set; }
         
        public string LastName { get; set; }
    }
}
