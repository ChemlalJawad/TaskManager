using Microsoft.AspNetCore.Mvc;
using TaskManager.Services.User;

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
        public IActionResult GetAllUsers()
        {
            var users = _userService.GetAllUsers();

            return Ok(users);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult FindProjectById([FromRoute] int Id)
        {
            var user = _userService.FindUserById(Id);
            return Ok(user);
        }
    }
}
