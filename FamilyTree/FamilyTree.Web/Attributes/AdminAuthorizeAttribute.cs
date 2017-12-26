using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FamilyTree.Web.Attributes
{
    public class AdminAuthorizeAttribute : AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {

            var context = filterContext.HttpContext;
            if (context.User != null && context.User.Identity != null)
            {
                if (context.User.Identity.IsAuthenticated)
                {
                    if (context.User.IsInRole("Admin"))
                    {
                        filterContext.Result = new RedirectToRouteResult(new
                       RouteValueDictionary(new { controller = "Home", action = "Index" }));
                    }
                }
                else
                {
                    filterContext.Result = new RedirectResult("/login");
                }
                
            }
            //else
            //{
            //    base.HandleUnauthorizedRequest(filterContext);
            //}
        }
        //
    }
}