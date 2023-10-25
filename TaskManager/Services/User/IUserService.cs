using TaskManager.Services.User.Request;

namespace TaskManager.Services.User
{
    public interface IUserService
    {
        IEnumerable<Models.User> GetAllUsers();
        Models.User FindUserById(int id);
        Models.User AddUser(CreateUser user);
    }
}
