using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Apexia.Core.Entidades
{
    [Table("detalle_compra")]
    public class Detalle_compra
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdDetalleCompra")]
        public int IdDetalleCompra { get; set; }

        [Column("cantidad")]
        public int Cantidad { get; set; }

        [Column("precio_costo")]
        public decimal PrecioCosto { get; set; }

        [Column("subtotal")]
        public decimal Subtotal { get; set; }

        [ForeignKey("IdCompra")]
        public int IdCompra { get; set; }

        [ForeignKey("IdProducto")]
        public int IdProducto { get; set; }

    }
}
