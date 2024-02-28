using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naviera.Shared.Entidades
{
    public class Area
    {
        [Key]
        [Column(TypeName = "int")]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(45)")]
        public string Codigo { get; set; }
        public ICollection<Contenedor> Contenedor { get; set; }
        public int ContenedorId { get; set; }
        //public int IdBarco { get; set; }
        public Barco Barco { get; set; }
        public int BarcoId { get; set; }
    }
}
