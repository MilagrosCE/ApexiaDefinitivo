using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Apexia.Core.Entidades
{
    [Table("Compras")]
    public class Compra
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdCompra")]
        public int IdCompra { get; set; }

        [Column("fecha")]
        public DateTime Fecha { get; set; }

        [Column("total")]
        public decimal Total { get; set; }

    }
}
