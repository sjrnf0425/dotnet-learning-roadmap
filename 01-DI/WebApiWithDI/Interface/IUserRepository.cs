namespace WebApiWithDI.Interface
{
    public interface IUserRepository
    {
        Task<User>GetUserById(int id);
    }
}
