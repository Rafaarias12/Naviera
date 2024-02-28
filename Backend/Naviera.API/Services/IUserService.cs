using Naviera.API.Request;
using Naviera.API.Response;

namespace Naviera.API.Services
{
    public interface IUserService
    {
        public UserResponse Login(AuthRequest model);
    }
}
