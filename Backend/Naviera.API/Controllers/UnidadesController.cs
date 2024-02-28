using Microsoft.AspNetCore.Mvc;
using Naviera.API.Data;

namespace Naviera.API.Controllers
{
    [ApiController]
    [Route("/api/unidades")]
    public class UnidadesController : ControllerBase
    {
        private readonly DataContext _context;
        public UnidadesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var lts = _context.Unidades.ToList();
            return Ok(lts);
        }
    }
}
