using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;
using System.Web.Http.Filters;
using System.Web.Http.Tracing;

namespace KickOff.ExceptionHandle
{
    public class MethodExceptionHandlingFilter : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            //We can log this exception message to the file or database.  
            var response = new HttpResponseMessage(HttpStatusCode.InternalServerError)
            {
            Content = new StringContent("An unhandled exception was thrown by service"),  
                    ReasonPhrase = "Internal Server Error.Please Contact your Administrator.",
            };
            string exceptionMessage = string.Empty;
            if (actionExecutedContext.Exception.InnerException == null)
            {
                exceptionMessage = actionExecutedContext.Exception.Message;
            }
            else if(actionExecutedContext.Exception is KickOffException)
            {
                var exception = actionExecutedContext.Exception as KickOffException;
                var res = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent("KickOffException"),
                    ReasonPhrase = "Internal Server Error.Please Contact your Administrator.",
                };
                response = res;
            }
            else
            {
                exceptionMessage = actionExecutedContext.Exception.InnerException.Message;
            }
            

            //response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            actionExecutedContext.Response = response;
        }

    }
}