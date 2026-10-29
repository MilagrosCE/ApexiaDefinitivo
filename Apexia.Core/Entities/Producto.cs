using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Apexia.Core.Entidades
{
    [Table("productos")]
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdProducto")]
        public int IdProducto { get; set; }

        [Column("nombre")]
        [MaxLength(100)]
        public string Nombre { get; set; }

        [Column("descripcion")]
        public string Descripcion { get; set; }

        [Column("precio_venta")]
        public decimal PrecioVenta { get; set; }

        [Column("activo")]
        public bool Activo { get; set; }

        [Column("fecha_alta")]
        public DateTime FechaAlta { get; set; }

        [ForeignKey("IdCodigoProducto")]
        public int IdCodigoProducto { get; set; }

        [ForeignKey("IdCategoria")]
        public int IdCategoria { get; set; }
 
    }
}

