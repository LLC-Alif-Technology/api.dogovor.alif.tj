using Microsoft.AspNetCore.Http;
namespace Domain.TransferObjects
{
    public class SubCategoryDTO
    {
        public IFormFile form { get; set; }
        public string SubCategoryName { get; set; }
        public int CategoryId { get; set; }
    }
}
