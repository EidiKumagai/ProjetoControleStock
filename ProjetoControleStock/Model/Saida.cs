using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoControleStock.Model
{
    [Table("Saida")]
    public class Saida
    {

        [Column(TypeName = "mediumint")]
        public int Id { get; set; }

        [StringLength(45)]
        [Required(ErrorMessage = "Codigo nao pode ser vazio !.")]
        public string Cod_Saida { get; set; }

        public int Qtde_Saida { get; set; }

        public Cliente Cliente { get; set; }

        public Produto Produto { get; set; }


    }
}
