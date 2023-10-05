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
            await _accountManager.Create(addNewUserDto);
            return Ok("User Add");
        }

        [HttpPost("Login")]
        public async Task<ActionResult<UserDto>> Login( [FromBody]UserLoginCredentialsDto userLogin)
        {
            var user = await _accountManager.Login(userLogin);
            return Ok(user);
        }
            
    }
}
