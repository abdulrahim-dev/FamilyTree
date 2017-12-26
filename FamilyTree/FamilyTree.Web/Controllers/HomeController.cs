using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FamilyTree.Data;

namespace FamilyTree.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //Only FOr Initialise the database
            //DatabaseInitializer sd=new DatabaseInitializer();
            //sd.Initialize(new FamilyTreeDbContext());
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}