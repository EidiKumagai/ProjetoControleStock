using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoControleStock.Model
{
    [Table("Estoque")]
    public class Estoque
    {

        [Column(TypeName = "mediumint")]
        public int Id { get; set; }

        [StringLength(45)]
        [Required(ErrorMessage = "Codigo nao pode ser vazio !.")]
        public string Cod_Estoque { get; set; }

        public List<Entrada> Entradas { get; set; }

        public List<Saida> Saidas { get; set; }

        public int Total_Estoque { get; set; }

        public Estoque() {
            Entradas = new List<Entrada>();
            Saidas = new List<Saida>();
        }

    }
}
