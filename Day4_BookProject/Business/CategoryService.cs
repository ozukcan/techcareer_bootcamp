using Day4_BookProject.Data;

namespace Day4_BookProject.Business;

internal class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryService;

    public CategoryService()
    {
        _categoryService = new CategoryRepository();
    }

}
