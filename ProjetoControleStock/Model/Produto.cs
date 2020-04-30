using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoControleStock.Model
{
    [Table("Produto")]
    public class Produto
    {
        [Column(TypeName = "mediumint")]
        public int id { get; set; }

        [StringLength(45)]
        [Required(ErrorMessage = "Codigo nao pode ser vazio !.")]
        public string Cod_Produto { get; set; }


        [StringLength(45)]
        [Required(ErrorMessage = "Nome nao pode ser vazio !.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preço nao pode ser vazio !.")]
        public double Preco { get; set; }



        


    }
}
