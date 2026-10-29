using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Apexia.Core.Entidades
{
    [Table("pagos")]
    internal class Pago
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdPago")]
        public int IdPago { get; set; }

        [Column("forma_pago")]
        [MaxLength(50)]
        public string FormaPago { get; set; }

        [Column("fecha_hora")]
        public DateTime Fecha_hora { get; set; }

        [Column("monto")]
        public decimal Monto { get; set; }

        [Column("medio_pago")]
        [MaxLength(50)]
        public string Medio_Pago { get; set; }

        [Column("obvservacion")]
        public string Observacion { get; set; }
    }
}
