using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Controllers.Models.ViewModel
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public bool ShowRequestID => !string.IsNullOrEmpty(RequestId);
    }
}
