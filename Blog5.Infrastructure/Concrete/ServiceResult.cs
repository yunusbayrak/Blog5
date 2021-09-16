using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog5.Infrastructure.Concrete
{
    public class ServiceResult<T> : ServiceResult
    {
        public T Data { get; set; }
    }

    public class ServiceResult
    {
        public ServiceResultStatus Status { get; set; }
        public string Message { get; set; }
        public string ErrorMessage { get; set; }
    }
}
