using System.ComponentModel.DataAnnotations;

namespace Naviera.API.Request
{
    public class AuthRequest
    {
        [Required]
        public string User { get; set; }
        public string Password { get; set; }
    }
}
