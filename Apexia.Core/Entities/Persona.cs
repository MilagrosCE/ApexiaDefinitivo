using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Apexia.Core.Entidades
{
    [Table("persona")]
    public class Persona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdPersona")]
        public int IdPersona{ get; set; }

         [Column ("apellido")]
         [MaxLength(50)]
         public string Apellido { get; set; }

        [Column("nombre")]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Column("dni")]
        [MaxLength(10)]
        public string dni { get; set; }

        [Column("telefono")]
        [MaxLength(20)]
        public string telefono { get; set; }

        [Column("email")]
        [MaxLength(100)]
        [EmailAddress(ErrorMessage = "El correo electrónico no es válido.")]
        public string email { get; set; }

        [Column("direccion")]
        [MaxLength(100)]
        public string direccion { get; set; }

        [Column("fecha_alta")]
        public DateTime FechaAlta { get; set; }

        [Column("activo")]
        public bool Activo { get; set; }

    }
}
