using Domain.ContractChoice;

namespace Repository
{
    public interface ICategoryAndSubCategoryRepository
    {
        public Task<SubCategory> CreateSubCategory(string subCategoryName, string sampleInstance, int categoryId/*SubCategory subCategory*/);
        public Task<Category> CreateCategory(string categoryName);
        public Task<SubCategory> GetSubCategory(int Id);
        public Task<string> GetSubCategoryFile(int Id);
        
    }
}
