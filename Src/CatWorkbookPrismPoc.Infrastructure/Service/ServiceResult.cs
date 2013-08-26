using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatWorkbookPrismPoc.Infrastructure.Service
{
    public class ServiceResult<T> : EventArgs
    {
        public T Object
        {
            get; private set;
        }

        public ServiceResult(T obj)
        {
            Object = obj;
        }
    }
}
