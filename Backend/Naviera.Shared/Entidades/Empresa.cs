using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naviera.Shared.Entidades
{
    public class Empresa
    {
        [Key]
        [Column(TypeName = "int")]
        public int IdEmpresa { get; set; }
        public int Nit { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set; }
        [Required]
        [Column(TypeName = "varchar(45)")]
        public string Telefono { get; set; }
        public int Tercero { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
        public ICollection<Contacto> Contactos { get; set; }

    }
}
