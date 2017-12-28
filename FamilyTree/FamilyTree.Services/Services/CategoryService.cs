using FamilyTree.Core.Data;
using FamilyTree.Core.Entities;
using FamilyTree.Core.Services;

namespace FamilyTree.Services.Services
{
    public class CategoryService:BaseService<Category>,ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork) :base(unitOfWork)
        {

        }
    }
}