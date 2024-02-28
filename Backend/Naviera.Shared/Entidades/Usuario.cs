using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naviera.Shared.Entidades
{
    public class Usuario
    {
        [Key]
        [Column(TypeName = "int")]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(45)")]
        public string User { get; set; }
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string Password { get; set; }
        [Column(TypeName = "int")]
        public int Estado { get; set; }
    }
}
