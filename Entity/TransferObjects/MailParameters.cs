using Microsoft.AspNetCore.Http;
using System.Text.Json.Serialization;

namespace Domain.TransferObjects
{
    public class MailParameters
    {
        public string toEmail{ get; set; } = string.Empty;
        [JsonIgnore]
        public string htmlBody { get; set; } = string.Empty;
        [JsonIgnore]
        public string Subject { get; set; } = string.Empty;
        [JsonIgnore]
        public string FilePath { get; set; } = string.Empty;
        //public string GUID { get; set; } = string.Empty;
        public IFormFile file { get; set; }
    }   
}
    