using ProjetoControleStock.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoControleStock.DAL
{
    class ProdutoDAO
    {

        private static ModelProduto ctx = new ModelProduto();


        public static bool cadastrarProdutos(Produto produto) {

            try
            {
                ctx.Produtos.Add(produto);
                ctx.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
         
        }
    }
}
