using Microsoft.IdentityModel.Tokens;
using Naviera.API.Common;
using Naviera.API.Data;
using Naviera.API.Request;
using Naviera.API.Response;
using Naviera.API.Tools;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Naviera.API.Services
{
    public class UserService:IUserService
    {
        private readonly DataContext _context;
        private readonly IConfiguration _configuration;

        public UserService(DataContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;

        }

        public UserResponse Login(AuthRequest model)
        {
            UserResponse rpta = new UserResponse();
            string spassword = Encrypt.GetSHA256(model.Password);

            var usuario = _context.Usuarios;

            var login = (from u in usuario
                         where u.Password == spassword
                         && u.User == model.User
                         select new
                         {
                             user = u.User
                         }).ToList();
            string us = login[0].user;
            rpta = BuildToken(us);

            return rpta;
            
        }

        private UserResponse BuildToken(string user)
        {
            

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["jwtKey"]!));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiration = DateTime.UtcNow.AddDays(30);
            var token = new JwtSecurityToken(
                issuer: null,
                audience: null,
                //claims: claims,
                expires: expiration,
                signingCredentials: credentials);

            return new UserResponse
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Usuario = user,
            };
        }
    }
}
