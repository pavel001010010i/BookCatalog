using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Exeption
{
    public class Response
    {
        public static object Cookies { get; set; }
        public string? Status { get; set; }
        public string? Message { get; set; }
    }
}
