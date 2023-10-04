using GoldenPaths.Domain.Dtos;
using GoldenPaths.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace GoldenPaths.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountManager _accountManager;

        public AccountController(IAccountManager accountManager)
        {
            _accountManager = accountManager;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateUser([FromBody, FromForm]AddNewUserDto addNewUserDto)
        {
            await Task.Delay(1);
            return Ok("User Add");
        }

        [HttpPost("Login")]
        public async Task<ActionResult<UserDto>> Login( [FromBody]UserLoginCredentialsDto userLogin)
        {
            await Task.Delay (1);
            var user = new UserDto("Jesus Cristo", "jusus.cristo@nazaremail.com", new DateOnly());
            return Ok(user);
        }
            
    }
}
