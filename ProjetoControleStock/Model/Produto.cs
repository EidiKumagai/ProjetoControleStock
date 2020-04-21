using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace ProjetoControleStock.Model
{
    public partial class Produto
    {
        
        public int id { get; set; }

        public string Nome { get; set; }

        
        public string Preco { get; set; }


    }
}
