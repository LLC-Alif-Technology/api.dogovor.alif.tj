//using System.Data.SqlClient;

namespace api.dogovor.alif.tj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArchiveController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            string connectionString = "Data source = SHAHZOD; initial catalog = api.dogovor.alif.tj; integrated security = true";
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var ms = await db.QueryAsync<Archive>("SELECT a.Date, a.ContractName, a.ExecutorsEmail, a.ExecutorsFullName, a.DocumentType, a.FilePath from [Archives] a where a.Id = 1");
                return Ok(ms.ToList());
            }
        }
    } 
}
