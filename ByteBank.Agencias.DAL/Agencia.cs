namespace ByteBank.Agencias.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Agencia")]
    public partial class Agencia
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Numero { get; set; }

        [StringLength(50)]
        public string Nome { get; set; }

        [StringLength(100)]
        public string Descricao { get; set; }

        [StringLength(100)]
        public string Endereco { get; set; }

        [StringLength(50)]
        public string Telefone { get; set; }
    }
}
