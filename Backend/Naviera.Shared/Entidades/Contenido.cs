using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naviera.Shared.Entidades
{
    public class Contenido
    {
        [Key]
        [Column(TypeName = "int")]
        public int Id { get; set; }
        public double Cantidad { get; set; }
        public double Peso { get; set; }
        public TipoContenido TipoContenido { get; set; }
        public int TipoContenidoId { get; set; }
        public Unidad Unidad { get; set; }
        public int UnidadId { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
        
    }
}
