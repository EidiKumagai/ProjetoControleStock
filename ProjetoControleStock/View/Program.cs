using ProjetoControleStock.DAL;
using ProjetoControleStock.Model;
using ProjetoControleStock.View;
using ProjetoControleStock.View.ViewClientes;
using ProjetoControleStock.View.ViewFornecedores;
using ProjetoControleStock.View.ViewProdutos;
using ProjetoControleStock.View.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoControleStock
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            Fornecedor fornecedor = new Fornecedor();
            Cliente cliente = new Cliente();
            Entrada entrada = new Entrada();
            Estoque estoque = new Estoque();

            ViewCiente viewCliente = new ViewCiente();
            ViewEstoque viewEstoque = new ViewEstoque();
            ViewFornecedor viewFornecedor = new ViewFornecedor();
            ViewProduto viewProduto = new ViewProduto();
            ViewEntrada viewEntrada = new ViewEntrada();


            string Op;
            do
            {
                Console.Clear();
                Console.WriteLine("-- Controle de Estoque --");
                Console.WriteLine("\n0 - Sair");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Listar Cliente");
                Console.WriteLine("3 - Cadastrar Fornecedor");
                Console.WriteLine("4 - Listar Fornecedor");
                Console.WriteLine("5 - Cadastrar Produto");
                Console.WriteLine("6 - Listar Produto");
                Console.WriteLine("7 - Realizar Entrada ");
                Console.WriteLine("8 - Realizar Saida");

                Console.WriteLine("9 - Cadastrar Estoque");
                Console.WriteLine("10 - Visualizar Estoque");
                Console.WriteLine("Escolha uma Opção");
                Op = Console.ReadLine();

                switch (Op)
                {
                    case "1":
                        viewCliente.ViewCadastroCliente(cliente);
                        break;
                    case "2":
                        viewCliente.ViewListarClientes();
                        break;
                    case "3":
                        viewFornecedor.viewCadastrarFornecedor(fornecedor);
                        break;
                    case "4":
                        viewFornecedor.ViewListarFornecedores();
                        break;
                    case "5":
                        viewProduto.viewCadastroProduto(produto);
                        break;
                    case "6":
                        viewProduto.ViewListarProdutos();
                        break;
                    case "7":
                        viewEntrada.ViewCadastrarEntrada(entrada);
                        break;
                    case "8":
                        viewEntrada.ViewCadastrarEntrada(entrada);
                        break;
                    case "9":
                        //viewEstoque.ViewCadastrarEstoque(estoque);
                        break;
                    case "10":
                        viewEstoque.ViewVerEstoque();
                        break;
                        //case "6":
                        //    pessoa = new Pessoa();
                        //    Console.Clear();
                        //    Console.WriteLine("-- Retirar pessoa --");
                        //    Console.WriteLine("Digite o CPF da pessoa: ");
                        //    pessoa.CPF = Console.ReadLine();
                        //    pessoa = PessoaDAO.RetornarPessoasporCPF(pessoa);

                        //    if (pessoa != null)
                        //    {
                        //        Console.WriteLine("Nome:" + pessoa.Nome);
                        //        Console.WriteLine("Cpf: " + pessoa.CPF);
                        //        Console.WriteLine("-----------------------------------");
                        //        Console.WriteLine("Deseja Remover a pessoa?");
                        //        if (Console.ReadLine().ToLower().Equals("s"))
                        //        {
                        //            if (PessoaDAO.RetirarPessoa(pessoa))
                        //            {
                        //                Console.WriteLine("Removida com sucesso");
                        //            }
                        //            else
                        //            {
                        //                Console.WriteLine("Erro ao Remover esta Pessoa!");
                        //            }
                        //        }
                        //        else
                        //        {
                        //            Console.WriteLine("Pessoa Nao Removida");
                        //        }
                        //    }
                        //    else
                        //    {
                        //        Console.WriteLine("Pessoa não Cadastrada!");
                        //    }


                        //    break;
                        //case "7":
                        //    pessoa = new Pessoa();
                        //    Console.Clear();
                        //    Console.WriteLine("-- Alterar Pessoa --");
                        //    Console.WriteLine("Digite o CPF da pessoa: ");
                        //    pessoa.CPF = Console.ReadLine();
                        //    pessoa = PessoaDAO.RetornarPessoasporCPF(pessoa);

                        //    if (pessoa != null)
                        //    {
                        //        Console.WriteLine("Nome:" + pessoa.Nome);
                        //        Console.WriteLine("Cpf: " + pessoa.CPF);
                        //        Console.WriteLine("-----------------------------------");
                        //        Console.WriteLine("Deseja alterar a pessoa?");
                        //        if (Console.ReadLine().ToLower().Equals("s"))
                        //        {
                        //            Console.WriteLine("\nNome da Pessoa");
                        //            pessoa.Nome = Console.ReadLine();
                        //            Console.WriteLine("CPF");
                        //            pessoa.CPF = Console.ReadLine();
                        //            Console.WriteLine("Data de Nascimento");
                        //            pessoa.DataDeNascimento = Convert.ToDateTime(Console.ReadLine());
                        //            Console.WriteLine("Sexo");
                        //            pessoa.Sexo = Console.ReadLine();
                        //            Console.WriteLine("Telefone");
                        //            pessoa.Telfone = Console.ReadLine();


                        //            if (PessoaDAO.AlterarPessoa(pessoa))
                        //            {
                        //                Console.WriteLine("Alterada com sucesso");
                        //            }
                        //            else
                        //            {
                        //                Console.WriteLine("Erro ao Alterar esta Pessoa!");
                        //            }
                        //        }
                        //        else
                        //        {
                        //            Console.WriteLine("Pessoa Nao Removida");
                        //        }
                        //    }
                        //    else
                        //    {
                        //        Console.WriteLine("Pessoa não Cadastrada!");
                        //    }


                        //    break;


                }
                Console.ReadKey();
            } while (!Op.Equals("0"));
        }
    }
}
