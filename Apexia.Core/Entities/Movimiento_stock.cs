using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Text;

namespace Apexia.Core.Entidades
{
    [Table("movimiento_stock")]
    internal class Movimiento_stock
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdMovimientoStock")]
        public int IdMovimientoStock { get; set; }

        [Column("tipo_movimiento")]
        [MaxLength(50)]
        public string Tipo_Movimeinto { get; set; }

        [Column("cantidad")]
        public decimal Cantidad { get; set; }

        [Column("fecha_hora")]
        public DateTime Fecha_Hora { get; set; }

        [Column("motivo")]
        [MaxLength(255)]
        public string Motivo { get; set; }

    }
}
