using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Apexia.Core.Entidades
{
    [Table("cliente")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdCliente")]
        public int IdCliente { get; set; }

        [Column("activo")]
        public bool Activo { get; set; }

        [ForeignKey("IdPersona")]
        public int IdPersona { get; set; }

    }
}
