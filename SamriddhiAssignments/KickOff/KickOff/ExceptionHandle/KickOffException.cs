using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;

namespace KickOff.ExceptionHandle
{
    public class KickOffException : Exception
    {
        public string ErrorCode { get; set; }
        public string ErrorDescription { get; set; }

        /*private static readonly ILog logger = log4net.LogManager.GetLogger(typeof(GlobalExceptionHandler));

        public override void Handle(ExceptionHandlerContext context)
        {
            //Write all exception handling logic here. Eg., Log into database/server, send mail.
            logger.Debug(context.Exception);

            context.Result = new TextPlainErrorResult
            {
                Request = context.ExceptionContext.Request,
                Content = "Oops! Sorry! Something went wrong." +
                      "Please contact support"
            };
        }

        private class TextPlainErrorResult : IHttpActionResult
        {
            public HttpRequestMessage Request { get; set; }

            public string Content { get; set; }

            public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
            {
                HttpResponseMessage response =
                                 new HttpResponseMessage(HttpStatusCode.InternalServerError);
                response.Content = new StringContent(Content);
                response.RequestMessage = Request;
                return Task.FromResult(response);
            }
        }*/
    }
}