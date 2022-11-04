using Domain;
using Microsoft.AspNetCore.Http;

namespace Repository.Email
{
    public interface IMailService
    {
        //public Task<Response> SendEmailAsync(MailParameters dto);
        public Task<Response> SendEmailAsync(MailParameters dto, Method method = default);
    }
}
