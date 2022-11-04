namespace api.dogovor.alif.tj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryAndSubCategoryServices _categoryAndSubCategoryServices;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CategoryController(ICategoryAndSubCategoryServices categoryAndSubCategoryServices, IWebHostEnvironment webHostEnvironment)
        {
            _categoryAndSubCategoryServices = categoryAndSubCategoryServices;
            _webHostEnvironment = webHostEnvironment;
        }
        [HttpPost("CreateSubCategory")]
        public async Task<IActionResult> CreateSubCategory([FromForm] SubCategoryDTO dto)
        {
            var path = (Path.Combine(_webHostEnvironment.WebRootPath, $"{ DateTime.Today.ToString("D") }"));
            var createSubCategory = await _categoryAndSubCategoryServices.CreateSubCategory(dto, path);
            return createSubCategory.StatusCode == System.Net.HttpStatusCode.OK ? Ok(createSubCategory) : BadRequest(createSubCategory);
        }

        [HttpGet("GetSubcategory")]
        public async Task<IActionResult> GetSubcategory(int Id)
        {
            var subcategory = await _categoryAndSubCategoryServices.GetSubCategory(Id);
            return subcategory.StatusCode != System.Net.HttpStatusCode.OK ? BadRequest(subcategory) : Ok(subcategory.Message);
        }

        [HttpPost("CreateCategory")]
        public async Task<IActionResult> CreateCategory(string categoryName)
        {
            var category = await _categoryAndSubCategoryServices.CreateCategory(categoryName);
            return category.StatusCode == System.Net.HttpStatusCode.OK ? Ok(category) : BadRequest(category);
        }

        //[HttpGet("GetFile")]
        //public async Task<IActionResult> GetFile(int SubCategoryId)
        //{
        //    var subCategoryFile = await _categoryAndSubCategoryServices.GetSubCategoryFile(SubCategoryId);
        //    return subCategoryFile.StatusCode != System.Net.HttpStatusCode.OK ? NotFound(subCategoryFile) : Ok(subCategoryFile);
        //}

        //[HttpPost("ReceiveFinalText")]
        //public async Task<IActionResult> ReceiveFinalText([FromForm] TextDTO textDto)
        //{
        //    var path = (Path.Combine(_webHostEnvironment.WebRootPath, $"{ DateTime.Today.ToString("D") }"));
        //    var response = await _categoryAndSubCategoryServices.ReceiveFinalText(textDto.RTFtext, textDto.ContractName, path);
        //    return response.StatusCode == System.Net.HttpStatusCode.OK ? Ok(response) : BadRequest(response);
        //}
    }
}
