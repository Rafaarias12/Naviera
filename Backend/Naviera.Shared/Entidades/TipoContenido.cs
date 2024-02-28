using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naviera.Shared.Entidades
{
    public class TipoContenido
    {
        [Key]
        [Column(TypeName = "int")]
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public ICollection<Contenido> Contenidos { get; set; }
    }
}
