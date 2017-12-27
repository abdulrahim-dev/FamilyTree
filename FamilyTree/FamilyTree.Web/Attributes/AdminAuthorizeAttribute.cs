using System.Web.Mvc;
using System.Web.Routing;

namespace FamilyTree.Web.Attributes
{
    public class AdminAuthorizeAttribute : AuthorizeAttribute
    {

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            var context = filterContext.HttpContext;
            if (context.User != null && context.User.Identity != null)
            {
                if (context.User.Identity.IsAuthenticated)
                {
                    if (!context.User.IsInRole("Admin"))
                    {
                        filterContext.Result = new RedirectResult("/");
                    }
                }
                else
                {
                    filterContext.Result = new RedirectResult("/login");
                }

            }
        }
        //
    }
}