using TaskManager.Data;

namespace TaskManager.Services.User
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;
        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Models.User FindUserById(int id)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == id);
            if (user == null)
            {
                throw new EntityNotFoundException("User n'a pas été trouvé");
            }
            return user;
        }

        public IEnumerable<Models.User> GetAllUsers()
        {
            var users = _context.Users.ToList();
            return users;
        }
    }
}
