namespace TaskManager.Services.User
{
    public interface IUserService
    {
        IEnumerable<Models.User> GetAllUsers();
        Models.User FindUserById(int id);
    }
}
