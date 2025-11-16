using WebApiWithDI.Interface;

namespace WebApiWithDI
{
    public class UserRepository : IUserRepository
    {
        public Task<User> GetUserById(int id)
        {
            // Simulate fetching user from a data source
            return Task.FromResult(new User { Id = id, Name = "박서경" });
        }
    }
}
