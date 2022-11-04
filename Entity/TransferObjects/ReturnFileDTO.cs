using Microsoft.AspNetCore.Http;

namespace Domain.TransferObjects
{
    public class ReturnFileDTO
    {
        public string ContractName { get; set; }
        //public string DocumentName { get; set; }
        public IFormFile file { get; set; }
        //public string format { get; set; }
        //public string GUID { get; set; }
    }
}
