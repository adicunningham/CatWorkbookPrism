using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CatWorkbookPrismPoc.Infrastructure
{
    public interface IService
    {
        string ServiceName { get; }
    }
}
