﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Bootstrap.AutoMapper;
using Bootstrap.Ninject;
using Bootstrap;
using Bootstrap.Extensions;
using Bootstrap.Extensions.StartupTasks;
using PlaygroundReservations.Models;

namespace PlaygroundReservations
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }

        protected void Application_Start()
        {
            InitBootstrapper();
            AreaRegistration.RegisterAllAreas();

            this.SetDatabaseInitilizer();
            // Use LocalDB for Entity Framework by default
            //Database.DefaultConnectionFactory = new SqlConnectionFactory("Data Source=(localdb)\v11.0; Integrated Security=True; MultipleActiveResultSets=True");

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);

            BundleTable.Bundles.RegisterTemplateBundles();
        }

        private void SetDatabaseInitilizer()
        {
            System.Data.Entity.Database
                .SetInitializer(new PlaygroundReservationsDataInitializer());
        }

        private void InitBootstrapper()
        {
            Bootstrapper
                //.With.Ninject()
                .With.AutoMapper()
                //.And.AutoMapper()
                .And.StartupTasks()
            .Start();
        }
    }
}