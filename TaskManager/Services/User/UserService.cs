using Microsoft.EntityFrameworkCore;
using TaskManager.Data;
using TaskManager.Models;
using TaskManager.Services.User.Request;

namespace TaskManager.Services.User
{
    public class UserService : DbContext, IUserService
    {
        private readonly IApplicationDbContext _context;
        public UserService(IApplicationDbContext context)
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

        public Models.User AddUser(CreateUser command)
        {
            var user = new Models.User 
            {
                FirstName = command.FirstName,
                LastName = command.LastName,
                Email = command.Email,
                PhoneNumber = command.PhoneNumber,
                Password = command.Password,
                RegistrationDate = DateTime.Now
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            return user;

        }
    }
}
