namespace WebApiWithDI.Interface
{
    public interface IUserService
    {
        Task<User> GetUser(int id);
    }
}
