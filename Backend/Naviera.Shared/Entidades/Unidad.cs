using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naviera.Shared.Entidades
{
    public class Unidad
    {
        [Key]
        [Column(TypeName = "int")]
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string DesCorta { get; set; }
        public ICollection<Contenido> Contenido { get; set; }
    }
}
