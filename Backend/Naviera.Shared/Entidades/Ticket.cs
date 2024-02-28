using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naviera.Shared.Entidades
{
    public class Ticket
    {
        [Key]
        [Column(TypeName = "int")]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(45)")]
        public string Codigo { get; set; }
        public Viaje Viaje { get; set; }
        public int ViajeId { get; set; }
        public Empresa Empresa { get; set; }
        public int EmpresaId { get; set; }
        public Contenedor Contenedor { get; set; }
        public int ContenedorId { get; set; }
        public Contenido Contenido { get; set; }
        public int ContenidoId { get; set; }
    }
}
