using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Apexia.Core.Entidades
{
    [Table("roles")]
    internal class Rol
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdRol")]
        public int IdRol { get; set; }

        [Column("nombre")]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Column("descripcion")]
        [MaxLength(255)]
        public string Descripcion { get; set; }
    }
}
