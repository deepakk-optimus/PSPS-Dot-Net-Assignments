using log4net;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Caching;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.Http.Filters;

namespace KickOff.Authentication
{

    public class KickOffAuthenticationAttribute : ActionFilterAttribute
    {
        private static readonly ILog logger = log4net.LogManager.GetLogger(typeof(KickOffAuthenticationAttribute));
        private int _timespan;
        private readonly bool _dependsOnIdentity;
        private readonly bool _invalidateCache;
        private bool _cacheEnabled = false;
        // cache repository
        private static readonly ObjectCache WebApiCache = MemoryCache.Default;


        public KickOffAuthenticationAttribute(bool dependsOnIdentity)
            : this(dependsOnIdentity, false)
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dependsOnIdentity"></param>
        /// <param name="invalidateCache">true to invalidate cache object</param>
        public KickOffAuthenticationAttribute(bool dependsOnIdentity, bool invalidateCache)
        {
            //_securityHelper = new SecurityHelper();
            _dependsOnIdentity = dependsOnIdentity;
            _invalidateCache = invalidateCache;

            ReadConfig();
        }

        private void ReadConfig()
        {
            if (!Boolean.TryParse(WebConfigurationManager.AppSettings["CacheEnabled"], out _cacheEnabled))
                _cacheEnabled = false;

            if (!Int32.TryParse(WebConfigurationManager.AppSettings["CacheTimespan"], out _timespan))
                _timespan = 18; // seconds
        }

        public override void OnActionExecuting(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            logger.Info("Authenticating user");
            if (actionContext.Request.Headers.Authorization == null)
            {
                actionContext.Response = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized);
                logger.Info("User not Authenticated");
            }
            else
            {
                try
                {
                    var auth = actionContext.Request.Headers.Authorization;
                    string authToken = null;
                    if (auth != null && auth.Scheme == "Basic")
                    {
                        authToken = auth.Parameter;
                    }
                    else
                    {
                        actionContext.Response = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.BadRequest);
                    }
                    string decodedToken = Encoding.UTF8.GetString(Convert.FromBase64String(authToken));
                    string username = decodedToken.Substring(0, decodedToken.IndexOf(":"));
                    string password = decodedToken.Substring(decodedToken.IndexOf(":") + 1);
                    logger.Info("user name = " + username);
                    logger.Info("password = " + password);

                    //here apply check on username password and on case of failure send 
                    if (!(username.Equals("samriddhi") && password.Equals("password"))) //c2FtcmlkZGhpOnBhc3N3b3Jk
                    {
                        actionContext.Response = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized);
                        logger.Info("User not Authenticated");

                    }

                    //caching
                    string _cachekey = string.Join(":", new string[]
                        {
                            actionContext.Request.RequestUri.OriginalString,
                            actionContext.Request.Headers.Accept.FirstOrDefault().ToString(),
                        });
                    if (WebApiCache.Contains(_cachekey))
                    {
                        //TraceManager.TraceInfo(String.Format("Cache contains key: {0}", _cachekey));

                        var val = (string)WebApiCache.Get(_cachekey);
                        if (val != null)
                        {
                            actionContext.Response = actionContext.Request.CreateResponse();
                            actionContext.Response.Content = new StringContent(val);
                            var contenttype = (MediaTypeHeaderValue)WebApiCache.Get(_cachekey + ":response-ct");
                            if (contenttype == null)
                                contenttype = new MediaTypeHeaderValue(_cachekey.Split(':')[1]);
                            actionContext.Response.Content.Headers.ContentType = contenttype;
                            return;
                        }
                    }
                }
                catch (Exception exception)
                {
                    logger.Debug(exception.Message.ToString());
                    logger.Info("User not Authenticated");
                    actionContext.Response = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.BadRequest);
                }
            }
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            actionExecutedContext.Response.Headers.CacheControl = new CacheControlHeaderValue
            {
                MaxAge = TimeSpan.FromSeconds(_timespan),
                MustRevalidate = true,
                Public = true
            };
            
            if (WebApiCache != null)
            {
                string _cachekey = string.Join(":", new string[]
                {
                            actionExecutedContext.Request.RequestUri.OriginalString,
                            actionExecutedContext.Request.Headers.Accept.FirstOrDefault().ToString(),
                });

                if (actionExecutedContext.Response != null && actionExecutedContext.Response.Content != null)
                {
                    string body = actionExecutedContext.Response.Content.ReadAsStringAsync().Result;

                    if (WebApiCache.Contains(_cachekey))
                    {
                        WebApiCache.Set(_cachekey, body, DateTime.Now.AddSeconds(_timespan));
                        WebApiCache.Set(_cachekey + ":response-ct", actionExecutedContext.Response.Content.Headers.ContentType, DateTime.Now.AddSeconds(_timespan));
                    }
                    else
                    {
                        WebApiCache.Add(_cachekey, body, DateTime.Now.AddSeconds(_timespan));
                        WebApiCache.Add(_cachekey + ":response-ct", actionExecutedContext.Response.Content.Headers.ContentType, DateTime.Now.AddSeconds(_timespan));
                    }
                }
        }
        }
    }
}