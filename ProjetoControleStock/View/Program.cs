using ProjetoControleStock.DAL;
using ProjetoControleStock.Model;
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
            //Produto produto = new Produto();
            Fornecedor fornecedor = new Fornecedor();
            Cliente cliente = new Cliente();


            
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
                Console.WriteLine("6 - Realizar Entrada ");
                Console.WriteLine("7 - Realizar Saida");
                Console.WriteLine("8 - Visualizar Estoque");
                Console.WriteLine("Escolha uma Opção");
                Op = Console.ReadLine();

                switch (Op)
                {
                    case "1":
                        //pessoa = new Pessoa();
                        cliente = new Cliente();
                        Console.Clear();

                        Console.WriteLine("-- Cadastrar Cliente --");

                        
                        Console.WriteLine("\nDigite o Codigo do cliente");
                        cliente.Cod_Cliente = Console.ReadLine();
                     
                        Console.WriteLine("\nDigite o nome");
                        cliente.Nome = Console.ReadLine();
                        
                        Console.WriteLine("\nDigite o CPF/CNPJ");
                        cliente.CpforCnpj = Console.ReadLine();

                        Console.WriteLine("\nDigite o razao Social");
                        cliente.RazaoSocial = Console.ReadLine();

                        Console.WriteLine("\nDigite o telefone");
                        cliente.Telefone = Console.ReadLine();

                        if (ClienteDAO.CadastrarCliente(cliente))
                        {
                            Console.WriteLine("Cliente Cadastrado!");
                        }
                        else
                        {
                            Console.WriteLine("Cliente não Cadastrada!");
                        }

                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("-- Listar Clientes --");
                        foreach (Cliente pessoaCadastrada in ClienteDAO.GetClientes())
                        {
                            Console.WriteLine("CODIGO-CLIENTE:" + pessoaCadastrada.Cod_Cliente);
                            Console.WriteLine("Nome:" + pessoaCadastrada.Nome);
                            Console.WriteLine("Razão Social: " + pessoaCadastrada.RazaoSocial);
                            Console.WriteLine("Cpf/Cnpj: " + pessoaCadastrada.CpforCnpj);
                            Console.WriteLine("Telefone: " + pessoaCadastrada.Telefone);

                            Console.WriteLine("-----------------------------------");
                        }

                        break;
                    case "3":
                        fornecedor = new Fornecedor();
                        Console.Clear();

                        Console.WriteLine("-- Cadastrar Fornecedor--");

                        Console.WriteLine("\nDigite o Codigo do fornecedor");
                        fornecedor.Cod_Fornecedor = Console.ReadLine();

                        Console.WriteLine("\nDigite o nome");
                        fornecedor.Nome = Console.ReadLine();

                        Console.WriteLine("\nDigite o CPF/CNPJ");
                        fornecedor.CpforCnpj = Console.ReadLine();

                        Console.WriteLine("\nDigite o razao Social");
                        fornecedor.RazaoSocial = Console.ReadLine();

                        Console.WriteLine("\nDigite o telefone");
                        fornecedor.Telefone = Console.ReadLine();

                        Console.WriteLine("\nDigite o email");
                        fornecedor.Email = Console.ReadLine();

                        if (FornecedorDAO.CadastrarFornecedor(fornecedor))
                        {
                            Console.WriteLine("Fornecedor Cadastrado!");
                        }
                        else
                        {
                            Console.WriteLine("Fornecedor não Cadastrado!");
                        }
                        //produto = new Produto();
                        //Console.Clear();
                        //Console.WriteLine("-- Cadastrar Produto --");
                        //Console.WriteLine("Digite o nome do produto: ");
                        //produto.Nome = Console.ReadLine();

                        //Console.WriteLine("Digite o preço do produto: ");
                        //produto.Preco = Console.ReadLine();


                        //if (ProdutoDAO.cadastrarProdutos(produto))
                        //{
                        //    Console.WriteLine("Produto Cadastrado!");
                        //}
                        //else
                        //{
                        //    Console.WriteLine("Erro, tente novamente!");
                        //}

                        break;
                    //case "4":
                    //    pessoa = new Pessoa();
                    //    Console.Clear();
                    //    Console.WriteLine("-- Listar Pessoa por Chave Primaria--");
                    //    Console.WriteLine("Digite o ID da pessoa: ");
                    //    pessoa.PessoaId = Convert.ToInt32(Console.ReadLine());
                    //    pessoa = PessoaDAO.RetornarPessoasporPK(pessoa);
                    //    if (pessoa != null)
                    //    {
                    //        Console.WriteLine("Nome:" + pessoa.Nome);
                    //        Console.WriteLine("Cpf: " + pessoa.CPF);
                    //        Console.WriteLine("ID: " + pessoa
                    //            .PessoaId);
                    //        Console.WriteLine("-----------------------------------");
                    //    }
                    //    else
                    //    {
                    //        Console.WriteLine("Não existe nego com esse CPF");
                    //    }


                    //    break;
                    //case "5":
                    //    pessoa = new Pessoa();
                    //    Console.Clear();
                    //    Console.WriteLine("-- Listar Pessoa por Parte do Nome--");
                    //    Console.WriteLine("Digite o que deseja procurar da pessoa: ");
                    //    pessoa.Nome = Console.ReadLine();
                    //    foreach (Pessoa pessoaCadastrada in PessoaDAO.RetornarPessoasporPartedoNome(pessoa))
                    //    {
                    //        Console.WriteLine("Nome:" + pessoaCadastrada.Nome);
                    //        Console.WriteLine("Cpf: " + pessoaCadastrada.CPF);
                    //        Console.WriteLine("ID: " + pessoaCadastrada.PessoaId);
                    //        Console.WriteLine("-----------------------------------");
                    //    }
                    //    break;
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
