using Domain.ContractChoice;

namespace Repository
{
    public class CategoryAndSubCategoryRepository : ICategoryAndSubCategoryRepository
    {
        private readonly AppDbСontext _context;

        public CategoryAndSubCategoryRepository(AppDbСontext context)
        {
            _context = context;
        }

        public async Task<Category> CreateCategory(string categoryName)
        {
            var category = new Category
            {
                CategoryName = categoryName,
            };
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<SubCategory> CreateSubCategory(string subCategoryName, string sampleInstance, int categoryId)
        {
            var subCtgr = new SubCategory
            {
                SubCategoryName = subCategoryName,
                CategoryId = categoryId,
                SampleInstance = sampleInstance,
            };
            await _context.SubCategories.AddAsync(subCtgr);
            await _context.SaveChangesAsync();
            return subCtgr;
        }

        public async Task<SubCategory> GetSubCategory(int Id)
        {
            var subcategory = await _context.SubCategories.FindAsync(Id);
            if (subcategory != null)
                return subcategory;
            else return null;
        }

        public async Task<string> GetSubCategoryFile(int Id)
        {
            var FileString = await _context.SubCategories.FindAsync(Id);
            if (FileString != null)
                return FileString.SampleInstance;
            else return null;
        }
    }
}
