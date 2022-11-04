namespace Service.ContractServices
{
    public interface ICategoryAndSubCategoryServices
    {
        public Task<Response> CreateSubCategory(SubCategoryDTO dto, string path);
        public Task<Response> CreateCategory(string categoryName);
        public Task<Response> GetSubCategory(int Id);
        public Task<Response> GetSubCategoryFile(int Id);
        public Task<Response> ReceiveFinalText(string rtfText, string contractName, string path);
    }
}
    