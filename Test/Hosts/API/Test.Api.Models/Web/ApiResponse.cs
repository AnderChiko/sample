using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Test.Api.Models.Web
{
    public class ApiResponse
    {
        public HttpStatusCode HttpResponseCode { get; set; }
        public object? Data { get; set; }
        public string? Message { get; set; }

        public ApiResponse(HttpStatusCode httpResponseCode)
        {
            HttpResponseCode = httpResponseCode;
        }

    }
}
