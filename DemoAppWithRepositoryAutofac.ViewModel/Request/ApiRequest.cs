using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppWithRepositoryAutofac.ViewModel.Request
{
    public class ApiRequest
    {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public string Search { get; set; }
    }
}
