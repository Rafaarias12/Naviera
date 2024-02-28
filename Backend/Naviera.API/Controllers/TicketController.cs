using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Naviera.API.Data;
using Naviera.API.Request;
using Naviera.Shared.Entidades;

namespace Naviera.API.Controllers
{
    [ApiController]
    [Route("/api/ticket")]
    public class TicketController : ControllerBase
    {
        private readonly DataContext _context;

        public TicketController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("Unidades")]
        public IActionResult GetUnidades()
        {
            var lst = _context.Unidades.ToList();
            return Ok(lst);
        }

        [HttpGet("Contenido")]
        public IActionResult GetTContenido()
        {
            var lst = _context.TipoContenidos.ToList();
            return Ok(lst);
        }

        [HttpGet("Empresa")]
        public IActionResult GetEmpresa()
        {
            var lst = _context.Empresa.ToList();
            return Ok(lst);
        }

        [HttpGet("Contenedor")]
        public IActionResult GetContenedor() {
            var lst = _context.Contenedores.ToList();
            return Ok(lst);
        }

        [HttpPost]
        public IActionResult Post(TicketResponse model)
        {
            Ticket ticket = new Ticket();
            Empresa empresa = new Empresa();
            Contenedor contenedor = new Contenedor();
            TipoContenido tipoContenido = new TipoContenido();
            Contenido contenido = new Contenido();
            int cont = 0;

            try
            {
                contenido.Cantidad = model.Cantidad;
                contenido.Peso = model.Peso;
                contenido.TipoContenidoId = model.TipoContenido;
                contenido.UnidadId = model.Unidad;
                _context.Contenidos.Add(contenido);
                _context.SaveChanges();

                cont = _context.Contenidos.OrderByDescending(x => x.Id).FirstOrDefault().Id;

                string codigo = "A" + Convert.ToString(cont + 1);
                ticket.Codigo = codigo;
                ticket.ViajeId = model.Viaje;
                ticket.EmpresaId = model.Empresa;
                ticket.ContenedorId = model.Contenedor;
                ticket.ContenidoId = cont;
                _context.Tickets.Add(ticket);
                _context.SaveChanges();

                return Ok(codigo);

            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }


        }
    }
}
