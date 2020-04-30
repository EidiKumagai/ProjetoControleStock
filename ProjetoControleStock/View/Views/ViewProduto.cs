using ProjetoControleStock.DAL;
using ProjetoControleStock.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoControleStock.View.ViewProdutos
{
    class ViewProduto
    {

        public void viewCadastroProduto(Produto produto) {

            produto = new Produto();
            Console.Clear();
            Console.WriteLine("-- Cadastrar produto --");

            Console.WriteLine("Digite o codigo do produto: ");
            produto.Cod_Produto = Console.ReadLine();

            Console.WriteLine("Digite o nome do produto: ");
            produto.Nome = Console.ReadLine();

            Console.WriteLine("digite o preço do produto: ");
            string aux = Console.ReadLine();
            double result;
            result = Convert.ToDouble(aux);
            produto.Preco = result;


            if (ProdutoDAO.CadastrarProduto(produto))
            {
                Console.WriteLine("produto cadastrado!");
            }
            else
            {
                Console.WriteLine("erro, tente novamente!");
            }
        }

        public void ViewListarProdutos() {
            Console.Clear();
            List<Produto> listadeProdutos = new List<Produto>();
            listadeProdutos = ProdutoDAO.GetProdutos();
            Console.WriteLine("-- Listar Produto --");
            if (listadeProdutos.Count == 0)
            {
                Console.WriteLine("A lista de produtos esta vazia !");
            }
            else
            {
                foreach (Produto produtoCadastrado in ProdutoDAO.GetProdutos())
                {
                    Console.WriteLine("CODIGO-PRODUTO:" + produtoCadastrado.Cod_Produto);
                    Console.WriteLine("Nome:" + produtoCadastrado.Nome);
                    Console.WriteLine("Preco: " + produtoCadastrado.Preco);

                    Console.WriteLine("-----------------------------------");
                }

            }
        }
    }
}
