using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naviera.Shared.Entidades
{
    public class Barco
    {
        [Key]
        [Column(TypeName = "int")]
        public int Id { get; set; }
        [Column(TypeName = "int")]
        public int Cap_carga { get; set; }
        [Column(TypeName = "int")]
        public int Cap_personal { get; set; }
        [Column(TypeName = "int")]
        public int Tamaño { get; set; }
        public double Peso { get; set; }
        [Required]
        [Column(TypeName = "varchar(45)")]
        public string Nombre { get; set; }
        [Required]
        [Column(TypeName = "varchar(45)")]
        public string Codigo { get; set; }

        public ICollection<Area> Areas { get; set; }
        public ICollection<Viaje> Viajes { get; set; }
    }
}
