using System;
using System.Net;

namespace API.Middleware
{
    public class StatusCodeException :Exception
    {
        public HttpStatusCode Code { get; set; }
        public string Error { get; set; }
        public int Id { get; set; }

        public StatusCodeException(HttpStatusCode Code, string Error) : base(Error)
        {
            this.Code = Code;
        }
        //public StatusCodeException(HttpStatusCode Code, string Error)
        //{
        //    this.Code = Code;
        //    this.Error = Error;
        //}

    }
}