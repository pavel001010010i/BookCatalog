using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Application.Common.Exeption
{
    public class RestException : Exception
    {
        public RestException(HttpStatusCode code, object? errors = null)
        {
            Code = code;
            Errors = errors;
        }

        public HttpStatusCode Code { get; }

        public object? Errors { get; set; }
    }
}
