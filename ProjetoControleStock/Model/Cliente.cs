using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoControleStock.Model
{
    [Table("Cliente")]
    public class Cliente
    {
        [Column(TypeName = "mediumint")]
        public int id { get; set; }

        [StringLength(45)]
        [Required(ErrorMessage = "Codigo nao pode ser vazio !.")]
        public string Cod_Cliente { get; set; }

        [StringLength(45)]
        [Required(ErrorMessage = "Nome nao pode ser vazio !.")]
        public string Nome { get; set; }

        [StringLength(45)]
        [Required(ErrorMessage = "RazaoSocial nao pode ser vazio !.")]
        public string RazaoSocial { get; set; }

        [StringLength(45)]
        [Required(ErrorMessage = "Cpf/cnpj nao pode ser vazio !.")]
        public string CpforCnpj { get; set; }

        [StringLength(45)]
        public string Telefone { get; set; }

    }
}
