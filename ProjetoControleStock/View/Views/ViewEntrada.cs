using ProjetoControleStock.DAL;
using ProjetoControleStock.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoControleStock.View.Views
{
    class ViewEntrada
    {

        public void ViewCadastrarEntrada(Entrada entrada) {
            entrada = new Entrada();
            List<Produto> listadeprodutos = new List<Produto>();
            List<Fornecedor> listadeFornecedores= new List<Fornecedor>();
            List<Entrada> entradas = null;

            listadeprodutos = ProdutoDAO.GetProdutos();
            listadeFornecedores = FornecedorDAO.GetFornecedores();
            string aux,aux2;
            Produto produtoSelect = null;
            Fornecedor fornecedorSelect = null;
            Console.Clear();

            Console.WriteLine("-- Realizar Entrada --");

            Console.WriteLine("Digite o codigo da entrada");
            entrada.Cod_Entrada = Console.ReadLine();

            Console.WriteLine("Digite o codigo do produto");
            aux = Console.ReadLine();

            foreach (Produto produtoes in listadeprodutos)
            {
                if (produtoes.Cod_Produto.Equals(aux)) {
                    produtoSelect = produtoes;
                }
            }


            if (produtoSelect == null)
            {
                Console.WriteLine("Produto nao encontrado!");
            }
            else {
                entrada.produto = produtoSelect;
                Console.WriteLine("Digite o codigo do Fornecedor");
                aux2 = Console.ReadLine();

                foreach (Fornecedor fornecedores in listadeFornecedores)
                {
                    if (fornecedores.Cod_Fornecedor.Equals(aux2))
                    {
                        fornecedorSelect = fornecedores;
                    }
                }

                if (fornecedorSelect == null) {
                    Console.WriteLine("Fornecedor nao Encontrado !");
                }
                else {
                    entrada.fornecedor = fornecedorSelect;
                    Console.WriteLine("Informe a quantidade de entrada do: " + produtoSelect.Cod_Produto +"\n" + "do Fonecedor:" + fornecedorSelect.Nome);
                    string numero = Console.ReadLine();
                    int quantidade;
                    quantidade = Convert.ToInt16(numero);
                    entrada.qtde_Entrada = quantidade;

                    Estoque estoque = new Estoque();

                    estoque.Cod_Estoque = "STOCK-001";
                    estoque.Total_Estoque = entrada.qtde_Entrada;
                    estoque.Entradas.Add(entrada);

                    if (EntradaDAO.CadastrarEntrada(entrada))
                    {
                        Console.WriteLine("Entrada cadastrada");

                        if (EstoqueDAO.CadastrarEstoque(estoque))
                        {
                            Console.WriteLine("deu certo");
                        }
                        else {
                            Console.WriteLine("deu ruim");
                        }
                    }
                    else
                    {
                        Console.WriteLine("erro, tente novamente!");
                    }
                }

            }
        }
    }
}
