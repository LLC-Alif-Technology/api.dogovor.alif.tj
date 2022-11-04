using Domain.ReturnMessage;
using Domain.TransferObjects;
using Domain.User;
using System.Security.Claims;

namespace Service.UserService
{
    public interface IUserService
    {
        public Task<Response> RegisterUser(RegisterDTO dto);
        public Task<Response> Login(AuthorizationDTO dto);
        public Task<User> UsersInformation(ClaimsIdentity claim);
        public Task<Response> SendEmailCode(string Email);
        public Task<Response> VerifyUser(RandomNumberDTO dto);
        public Task<Response> UpdateUserPassword(NewPasswordDTO dto);
    }
}
