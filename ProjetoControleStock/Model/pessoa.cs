namespace ProjetoControleStock.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("control_stock.pessoa")]
    public partial class Pessoa
    {
        [Column(TypeName = "mediumint")]
        public int id { get; set; }

        [StringLength(45)]
        public string Nome { get; set; }

        [StringLength(45)]
        public string CPF { get; set; }

        public DateTime? DatadeNascimento { get; set; }

        [StringLength(45)]
        public string Sexo { get; set; }

        [StringLength(45)]
        public string Telefone { get; set; }
    }
}
