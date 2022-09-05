using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace contractor_management.DTOs.Commons
{
    public class APIResponse<T>
    {
        public T? Data { get; set; }
        public bool Success { get; set; }
        public string? Message { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}