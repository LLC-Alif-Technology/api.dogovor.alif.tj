using Domain.Enum;

namespace api.dogovor.alif.tj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileDistributionController : ControllerBase
    {
        private readonly IArchiveService _archive;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IUserService _service;
        private readonly IMailService _mail;

        public FileDistributionController(
            IArchiveService archive,
                                   IWebHostEnvironment webHostEnvironment, 
                                   IUserService service, 
                                   IMailService mail)
        {
            _archive = archive;
            _webHostEnvironment = webHostEnvironment;
            _service = service;
            _mail = mail;
        }

        [HttpPost("SaveFile")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<IActionResult> SaveFile([FromForm] ReturnFileDTO returnFileDto)
        {
            var claim = User.Identity as ClaimsIdentity;
           
            if (claim == null) return BadRequest(System.Net.HttpStatusCode.BadRequest);
            
            var user = await _service.UsersInformation(claim);
            var path = (Path.Combine(_webHostEnvironment.WebRootPath, $"{ DateTime.Today.ToString("D") }"));
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            var returnfilePath = await _archive.ReturnFile(returnFileDto, path, user);

            return returnfilePath.StatusCode == HttpStatusCode.OK ? Ok(returnfilePath) : BadRequest(returnfilePath);


            //return returnfilePath == null ? 
            //    BadRequest("FilePath was returned as null!") : 
            //    File(System.IO.File.ReadAllBytes(returnfilePath), "application/octet-stream", returnFileDto.ContractName +  $".{returnFileDto.format}");
        }

        [HttpPost("SendFinalFileToEmail")]
        public async Task<IActionResult> SendFinalFileToEmail([FromForm] MailParameters dto)
        {
            var path = (Path.Combine(_webHostEnvironment.WebRootPath, $"{ DateTime.Today.ToString("D") }"));
            if(!Directory.Exists(path))
                Directory.CreateDirectory(path);
            dto.FilePath = path;
            var mail = await _mail.SendEmailAsync(dto, ExecutionWay.SendFile);
            return mail.StatusCode == HttpStatusCode.BadRequest ? BadRequest(mail) : Ok(mail); 
        }
    }   
}
