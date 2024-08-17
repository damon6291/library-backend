using library_backend.Manager;
using library_backend.Mapper;
using library_backend.Models;
using library_backend.Models.Auth;
using library_backend.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace library_backend.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService userService;
        private readonly IAuthManager authManager;
        public AuthController(IUserService userService, IAuthManager authManager)
        {
            this.userService = userService;
            this.authManager = authManager;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDTO req)
        {
            var ret = new ReturnModel();
            var (res, msg) = await authManager.Login(req);

            if (!res) return Ok(ret.Fail());

            ret.Success(msg);

            return Ok(ret);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserDTO req)
        {
            var ret = new ReturnModel();

            var (res, msg) = await authManager.Register(req);

            if (!res) return Ok(ret.Fail(msg));

            ret.Success();

            return Ok(ret);
        }

        [HttpGet("refresh")]
        public async Task<IActionResult> Refresh()
        {
            var ret = new ReturnModel();
            var userId = userService.GetUserId();
            if (userId == null) return Ok(ret.Logout());

            var (res, msg) = await authManager.Refresh(userId.Value);

            if (!res) return Ok(ret.Fail(msg));

            ret.Success(new { token = msg });

            return Ok(ret);
        }

        [HttpGet("me")]
        [Authorize]
        public async Task<IActionResult> GetMe()
        {
            var ret = new ReturnModel();
            var userId = userService.GetUserId();
            if (userId == null) return Ok(ret.Logout());

            var user = await authManager.GetUser(userId.Value);
            if (user == null) return Ok(ret.Fail());

            ret.Success(UserMapper.UserToDTO(user));

            return Ok(ret);
        }
    }
}
