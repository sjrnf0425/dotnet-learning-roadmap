using Microsoft.AspNetCore.Mvc;
using WebApiWithDI.Interface;

namespace WebApiWithDI
{
    [ApiController]
    [Route("api/users")]
    public class UserApiController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserApiController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _userService.GetUser(id);

            return Ok(user);
        }
    }
}
