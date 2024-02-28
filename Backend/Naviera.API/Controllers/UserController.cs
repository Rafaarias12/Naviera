using Microsoft.AspNetCore.Mvc;
using Naviera.API.Request;
using Naviera.API.Response;
using Naviera.API.Services;

namespace Naviera.API.Controllers
{
    [ApiController]
    [Route("/api/usuarios")]

    public class UserController : ControllerBase
    {
        private readonly IUserService user;
        public UserController(IUserService _user)
        {
            user = _user;
        }
        [HttpPost("login")]
        public ActionResult User(AuthRequest model)
        {
            UserResponse rpta = new UserResponse();
            rpta = user.Login(model);
            return Ok(rpta);
        }
    }
}
