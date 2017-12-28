using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using FamilyTree.Web.DI_Capsule;
using FamilyTree.Web.Mapping;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(FamilyTree.Web.Startup))]
namespace FamilyTree.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            //Mapping
            var mappingDefinitions = new MappingDefinitions();
            mappingDefinitions.Initialise();

            //Remove the same code from global.asax file
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();
            WebApiConfig.Register(config);
            app.UseWebApi(config);

            // Initialise Dependancy Injection Modules
            new WebCapsule().Initialise(config);
        }
    }
}