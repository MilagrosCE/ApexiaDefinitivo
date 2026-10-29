using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Apexia.Core.Entidades
{
    [Table("usuarios")]
    internal class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdUsuarios")]
        public int IdUsuarios { get; set; }

        [Column("usuario")]
        [MaxLength(50)]
        public string Usuarios { get; set; }

        [Column("password_hash")]
        [MaxLength(255)]
        public string Password_hash { get; set; }

        [Column("activo")]
        public Boolean Activo { get; set; }

        [Column("fecha_creacion")]
        public DateOnly Fecha_Creacion { get; set; }

        [Column("ultimo_acceso")]
        public DateTime Ultimo_Acceso { get; set; }
    }
}
