using System.Threading.Tasks;
using System.Web.Mvc;
using FamilyTree.Core.Services;
using FamilyTree.Web.Attributes;

namespace FamilyTree.Web.Areas.Admin.Controllers
{
    [AdminAuthorize]

    public class CategoryController : Controller
    {
        private readonly ICategoryService _contactService;

        public CategoryController(ICategoryService contactService)
        {
            _contactService = contactService;
        }



        // GET: Admin/Category
        public async Task<ActionResult> Index()
        {
            var categoryList = await _contactService.GetAllAsync();
            return View(categoryList);
        }
    }
}