using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Apexia.Core.Entidades
{
    [Table("detalle_pedido")]
    internal class Detalle_pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdDetallePedido")]
        public int IdDetallePedido { get; set; }

        [Column ("cantidad")]
        public int Cantidad { get; set; }

        [Column("precio_unitario")]
        public decimal Precio_unitario { get; set; }

        [Column("subtotal")]
        public decimal Subtotal { get; set; }

    }
}
