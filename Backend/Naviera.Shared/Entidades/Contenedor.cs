using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Naviera.Shared.Entidades
{
    public class Contenedor
    {
        [Key]
        [Column(TypeName = "int")]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(45)")]
        public string Codigo { get; set; }
        public double CapMin { get; set; }
        public double CapMax { get; set; }
        public Area Area { get; set; }
        public int AreaId { get; set; }


        //public Contenido Contenido { get; set; }
    }
}
