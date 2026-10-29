using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Apexia.Core.Entidades
{
    [Table("categorias")]
    internal class Categoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdCategoria")]
        public int IdCategoria { get; set; }

        [Column("nombre")]
        [MaxLength(50)]
        public string? Nombre { get; set; }

        [Column("descripcion")]
        [MaxLength(255)]
        public string? Descripcion { get; set; }

        [Column("activo")]
        public bool Activo { get; set; }

    }
}