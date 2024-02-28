using Naviera.Shared.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Naviera.API.Request
{
    public class TicketResponse
    {

        public int Empresa { get; set; }
        public double Cantidad { get; set; }
        public double Peso { get; set; }
        public int TipoContenido { get; set; }
        public int Unidad { get; set; }
        public int Contenedor { get; set; }
        public int Viaje { get; set; }

    }
}
