using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace contractor_management.DTOs.Commons
{
    public class APISuccessResponse<T> : APIResponse<T>
    {
        public APISuccessResponse(T data, HttpStatusCode statusCode = HttpStatusCode.OK)
        {
            Data = data;
            Success = true;
            StatusCode = statusCode;
        }
    }
}