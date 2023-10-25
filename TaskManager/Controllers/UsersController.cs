using Microsoft.AspNetCore.Mvc;
using TaskManager.Models;
using TaskManager.Services.User;
using TaskManager.Services.User.Request;

namespace TaskManager.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult GetAllUsers()
        {
            var users = _userService.GetAllUsers();

            return Ok(users);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult FindUserById([FromRoute] int Id)
        {
            var user = _userService.FindUserById(Id);
            return Ok(user);
        }

        [HttpPost]
        public ActionResult<User> CreateUser(CreateUser command)
        {
            var user = _userService.AddUser(command);

            return Ok(user);
        }
    }
}
