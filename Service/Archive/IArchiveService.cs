using Microsoft.AspNetCore.Http;

namespace Service
{
    public interface IArchiveService
    {
        public Task<Response> ReturnFile(ReturnFileDTO dto, string path, User user);
       // public Task<Response> ConvertTo(string format, string input, string output);
    }
}
    