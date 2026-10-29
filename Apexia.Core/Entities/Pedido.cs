using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Text;

namespace Apexia.Core.Entidades
{
    [Table("pedidos")]
    internal class Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdPedido")]
        public int IdPedido { get; set; }

        [Column("comentario")]
        [MaxLength(255)]
        public string Comentario { get; set; }

        [Column("fecha")]
        public DateOnly Fecha { get; set; }

        [Column("estado")]
        [MaxLength(50)]
        public String Estado { get; set; }

        [Column("subtotal")]
        public decimal Subtotal { get; set; }

        [Column("descuento")]
        public decimal Descuento { get; set; }

        [Column("total")]
        public decimal Total { get; set; }

    }
}
