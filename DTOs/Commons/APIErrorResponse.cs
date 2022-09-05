using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace contractor_management.DTOs.Commons
{
    public class APIErrorResponse<T> : APIResponse<T>
    {
        public APIErrorResponse(T data, string message, HttpStatusCode statusCode = HttpStatusCode.BadRequest)
        {
            Success = false;
            Message = message;
            StatusCode = statusCode;
        }
    }
}