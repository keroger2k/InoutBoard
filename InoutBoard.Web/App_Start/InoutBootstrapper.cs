[assembly: WebActivator.PostApplicationStartMethod(typeof(InoutBoard.Web.App_Start.InoutBootstrapper), "PreAppStart")]

namespace InoutBoard.Web.App_Start
{
    using InoutBoard.Core.Infrastructure.Providers;
    using InoutBoard.Core.Infrastructure.Repositories;
    using InoutBoard.Core.Infrastructure.Repositories.Implementation;
    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Web.Mvc;
    using System;
    using System.Configuration;
    using System.Data.Entity.Migrations;
    using System.Web.Hosting;
    using System.Web.Http;
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;
    using WebMatrix.WebData;

    public static class InoutBootstrapper
    {
        private const string SqlClient = "System.Data.SqlClient";
       
        public static void PreAppStart()
        {
            // Perform the required migrations
            DoMigrations();
            DoMvc4Stuff();

            // Start simplemembership
            WebSecurity.InitializeDatabaseConnection("Inout", "BoardUser", "Id", "Email", autoCreateTables: true);
        }

        private static void DoMigrations()
        {
            // Get the Inout connection string
            var connectionString = ConfigurationManager.ConnectionStrings["Inout"];

            if (String.IsNullOrEmpty(connectionString.ProviderName) ||
                !connectionString.ProviderName.Equals(SqlClient, StringComparison.OrdinalIgnoreCase))
            {
                return;
            }

            // Only run migrations for SQL server (Sql ce not supported as yet)
            var settings = new InoutBoard.Core.Migrations.MigrationsConfiguration();
            var migrator = new DbMigrator(settings);
            migrator.Update();
        }

        private static void DoMvc4Stuff() {
            AreaRegistration.RegisterAllAreas();
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();
        }
    }
}