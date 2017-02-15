using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApiCrudOperations.Controllers;
using WebApiCrudOperations.DAL;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.WebApi;
using log4net;

namespace WebApiCrudOperations
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            // register dependency resolver for WebAPI RC
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
            //DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();        
            container.RegisterType<IProjectRepository, ProjectRepository>();
            container.RegisterType<ICustomerRepository, CustomerRepository>();
            
            return container;
        }
    }
}