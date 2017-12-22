using System.Web.Mvc;

namespace FamilyTree.Web.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        /// <summary>
        /// Here, we need to specify the routing inside the area 
        /// </summary>
        /// <param name="context"></param>
        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_",
                "admin",
                new { controller = "Home", action = "Index" },
                namespaces: new[] { "FamilyTree.Web.Areas.Admin.Controllers" }
            );

            context.MapRoute(
                "Admin_default",
                "admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "FamilyTree.Web.Areas.Admin.Controllers" }
            );
        }
    }
}