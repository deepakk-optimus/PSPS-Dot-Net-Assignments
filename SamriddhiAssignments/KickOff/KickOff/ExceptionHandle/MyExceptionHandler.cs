using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Results;
using System.ServiceModel.Dispatcher;
using System.Web.Http.ExceptionHandling;

namespace KickOff.ExceptionHandle
{
    /// <summary>
    /// 
    /// </summary>
    public class MyExceptionHandler : ExceptionHandler
    {
        public override void Handle(ExceptionHandlerContext context)
        {
            context.Result = new ResponseMessageResult(context.Request.CreateResponse(HttpStatusCode.InternalServerError, "We apologize but an unexpected error occured. Please try again later."));
            return;
            //Return a DTO representing what happened
            //context.Result = new System.Web.Http.Results.ResponseMessageResult(context.Request.CreateResponse(System.Net.HttpStatusCode.InternalServerError,
            //new ErrorInformation { Message = "We apologize but an unexpected error occured. Please try again later.", ErrorDate = DateTime.UtcNow }));

            //This is commented out, but could also serve the purpose if you wanted to only return some text directly, rather than JSON that the front end will bind to.
            //context.Result = new ResponseMessageResult(context.Request.CreateResponse(HttpStatusCode.InternalServerError, "We apologize but an unexpected error occured. Please try again later."));
        }
    }
    /* public async override Task HandleAsync(ExceptionHandlerContext context, CancellationToken cancellationToken)
     {
         const string genericErrorMessage = "An unexpected error occured";
         var response = context.Request.CreateResponse(HttpStatusCode.InternalServerError,
             new
             {
                 Message = genericErrorMessage
             });

         //response.Headers.Add(&quot; X - Error & quot;, genericErrorMessage);
         context.Result = new ResponseMessageResult(response);
     }
     private class ErrorInformation
     {
         public string Message { get; set; }
         public DateTime ErrorDate { get; set; }
     }

     public override void Handle(System.Web.Http.ExceptionHandling.ExceptionHandlerContext context)
     {

         //Return a DTO representing what happened
         context.Result = new System.Web.Http.Results.ResponseMessageResult(context.Request.CreateResponse(System.Net.HttpStatusCode.InternalServerError,
         new ErrorInformation { Message = "We apologize but an unexpected error occured. Please try again later.", ErrorDate = DateTime.UtcNow }));

         //This is commented out, but could also serve the purpose if you wanted to only return some text directly, rather than JSON that the front end will bind to.
         //context.Result = new ResponseMessageResult(context.Request.CreateResponse(HttpStatusCode.InternalServerError, "We apologize but an unexpected error occured. Please try again later."));
     }
}*/
}