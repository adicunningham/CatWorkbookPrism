using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CatWorkbookPrismPoc.Services.Contracts.Faults
{
    [DataContract]
    public class ServiceException
    {
        /// <summary>
        /// Exception Message
        /// </summary>
        [DataMember]
        public string Message { get; set; }

        /// <summary>
        /// If critical, user should redirect to error page and exception details should log
        /// </summary>
        [DataMember]
        public bool IsCritical { get; set; }
    }
}
