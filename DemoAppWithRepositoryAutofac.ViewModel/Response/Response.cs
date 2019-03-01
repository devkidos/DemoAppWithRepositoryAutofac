using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppWithRepositoryAutofac.ViewModel.Response
{
    public class Response<T>
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public List<T> Datas { get; set; }
        public Int64 PageCount { get; set; }
        public int CurrentPage { get; set; }
    }
}
