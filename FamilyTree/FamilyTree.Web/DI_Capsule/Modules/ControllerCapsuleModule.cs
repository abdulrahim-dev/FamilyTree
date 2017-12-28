using System.Reflection;
using Autofac;
using Autofac.Integration.Mvc;

namespace FamilyTree.Web.DI_Capsule.Modules
{
    public class ControllerCapsuleModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            // Register the MVC Controllers
           
            builder.RegisterControllers(Assembly.Load("FamilyTree.Web"));

            // Register the Web API Controllers
            //builder.RegisterApiControllers(Assembly.GetCallingAssembly());
            //builder.RegisterApiControllers(Assembly.Load("FamilyTree.Web"));

        }
    }
}