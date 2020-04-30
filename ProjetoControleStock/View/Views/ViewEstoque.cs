using ProjetoControleStock.DAL;
using ProjetoControleStock.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoControleStock.View.Views
{
    class ViewEstoque
    {
        //public void ViewCadastrarEstoque(Estoque estoque, Entrada entrada) {
        //    estoque = new Estoque();
        //    Console.Clear();
        //    Console.WriteLine("-- Cadastrar estoque --");

        //    Console.WriteLine("Digite o codigo do estoque: ");
        //    estoque.Cod_Estoque = Console.ReadLine();

        //    Console.WriteLine("Digite o total de estoque: ");
        //    string numero = Console.ReadLine();
        //    int quantidade;
        //    quantidade = Convert.ToInt16(numero);
        //    estoque.Total_Estoque = quantidade;

        //    estoque.Entradas.Add(entrada);

            


        //    if (EstoqueDAO.CadastrarEstoque(estoque))
        //    {
        //        Console.WriteLine("Estoque cadastrado!");
        //    }
        //    else
        //    {
        //        Console.WriteLine("erro, tente novamente!");
        //    }

        //}

        public void ViewVerEstoque() {
            Console.Clear();
            List<Estoque> listaEstoque = new List<Estoque>();
            listaEstoque = EstoqueDAO.getEstoque();
            Console.WriteLine("-- Visualizar Estoque --");
            if (listaEstoque.Count == 0)
            {
                Console.WriteLine("O estoque não esta criado ainda. Faça uma entrada para criar !");
            }
            else
            {
                foreach (Estoque estoque in EstoqueDAO.getEstoque())
                {
                    Console.WriteLine("CODIGO-ESTOQUE:" + estoque.Cod_Estoque);
                    Console.WriteLine("TOTAL NO ESTOQUE: " + estoque.Total_Estoque);
                    Console.WriteLine("-----------------------------------");
                }

            }
        }
    }
}
