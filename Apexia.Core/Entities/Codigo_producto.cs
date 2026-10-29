using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Apexia.Core.Entidades
{
    [Table("codigo_producto")]
    public class Codigo_producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdCodigoProducto")]
        public int IdCodigoProducto { get; set; }

        [Column("codigo_barra")]
        [MaxLength(20)]
        public string? CodigoBarra { get; set; }

    }
}
