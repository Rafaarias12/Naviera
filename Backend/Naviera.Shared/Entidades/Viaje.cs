using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naviera.Shared.Entidades
{
    public class Viaje
    {
        [Key]
        [Column(TypeName = "int")]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(45)")]
        public string Codigo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaInic { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaFinal { get; set; }
        [Required]
        [Column(TypeName = "varchar(45)")]
        public string Inicio { get; set; }
        [Required]
        [Column(TypeName = "varchar(45)")]
        public string Destino { get; set; }
        public Barco Barco { get; set; }
        public int BarcoId { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}
