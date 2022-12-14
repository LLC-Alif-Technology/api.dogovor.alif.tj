using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Repository
{
    public interface IUserRepository
    {
        public Task<EntityEntry<User>> InsertUser(RegisterDTO dto);
        public Task<User> GetUserbyEmail(string email);
        public Task<Role> GetUserRole(int Id); 
        public Task<UserCode> GetUserCodeCompared(string email);
        public Task<UserCode> InsertUserCode(string randomNumber, int UserId, DateTime date); 
        public Task UpdateCode(UserCode userCode, int NewCode);
        public Task<Response> GetUserByEmailAndCode(RandomNumberDTO dto);
        public Task<Response> UpdateUsersPassword(NewPasswordDTO dto);
    }
}
