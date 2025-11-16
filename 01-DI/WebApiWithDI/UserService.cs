using WebApiWithDI.Interface;
namespace WebApiWithDI
{
    public class UserService :IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public Task<User> GetUser(int id)
        {
            return _userRepository.GetUserById(id);
        }
    }
}
