using Microsoft.AspNetCore.Mvc;
using Naviera.API.Data;

namespace Naviera.API.Controllers
{
    [ApiController]
    [Route("/api/viajes")]
    public class ViajesController : ControllerBase
    {
        private readonly DataContext _context;
        public ViajesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAction()
        {
            var lst = _context.Viajes.ToList();
            return Ok(lst);
        }

        //[HttpGet("{id:int}")]
        //public Task<IActionResult> GetBarcos(int id)
        //{
        //    va
        //}
    }
}
