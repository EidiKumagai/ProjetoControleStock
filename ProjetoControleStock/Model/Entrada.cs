using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoControleStock.Model
{
    [Table("Entrada")]
    public class Entrada
    {
        [Column(TypeName = "mediumint")]
        public int Id { get; set; }

        [StringLength(45)]
        [Required(ErrorMessage = "Codigo nao pode ser vazio !.")]
        public string Cod_Entrada { get; set; }

        [Required(ErrorMessage = "Fornecedor nao pode ser vazio !.")]
        public Fornecedor fornecedor { get; set; }

        [Required(ErrorMessage = "Produto nao pode ser vazio !.")]
        public Produto produto { get; set; }

        [Required(ErrorMessage = "Quantidade nao pode ser vazio !.")]
        public int qtde_Entrada { get; set; }


    }
}
