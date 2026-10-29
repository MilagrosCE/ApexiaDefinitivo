using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Apexia.Core.Entidades
{
    [Table("envios")]
    internal class Envio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdEnvio")]
        public int IdEnvio { get; set; }

        [Column("direccion")]
        [MaxLength(150)]
        public string Direccion { get; set; }

        [Column("costo")]
        public decimal Costo { get; set; }

        [Column("codigo_postal")]
        [MaxLength(10)]
        public string Codigo_Postal { get; set; }

        [Column("estado")]
        [MaxLength(50)]
        public string Estado { get; set; }
    }
}
