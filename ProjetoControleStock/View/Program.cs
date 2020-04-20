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
            Pessoa pessoa = new Pessoa();
            string Op;
            do
            {
                Console.Clear();
                Console.WriteLine("-- BANCO DE DADOS --");
                Console.WriteLine("\n0 - Sair");
                Console.WriteLine("1 - Cadastrar Pessoa");
                Console.WriteLine("2 - Listar Pessoa");
                Console.WriteLine("3 - Buscar Pessoa por CPF");
                Console.WriteLine("4 - Buscar Pessoa por Chave Primaria");
                Console.WriteLine("5 - Buscar Pessoas por Parte do Nome");
                Console.WriteLine("6 - Remover Pessoa");
                Console.WriteLine("7 - Alterar Pessoa");
                Console.WriteLine("Escolha uma Opção");
                Op = Console.ReadLine();

                switch (Op)
                {
                    case "1":
                        pessoa = new Pessoa();

                        Console.Clear();
                        Console.WriteLine("-- Cadastrar Pessoa --");
                        Console.WriteLine("\nNome da Pessoa");
                        pessoa.Nome = Console.ReadLine();
                        Console.WriteLine("CPF");
                        pessoa.CPF = Console.ReadLine();
                        Console.WriteLine("Data de Nascimento");
                        DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                        pessoa.DatadeNascimento = date;

                        Console.WriteLine("Sexo");
                        pessoa.Sexo = Console.ReadLine();
                        Console.WriteLine("Telefone");
                        pessoa.Telefone = Console.ReadLine();

                        if (PessoaDAO.CadastrarPessoa(pessoa))
                        {
                            Console.WriteLine("Pessoa Cadastrada!");
                        }
                        else
                        {
                            Console.WriteLine("Pessoa não Cadastrada!");
                        }


                        break;
                    //case "2":
                    //    pessoa = new Pessoa();
                    //    Console.Clear();
                    //    Console.WriteLine("-- Listar Pessoas --");
                    //    foreach (Pessoa pessoaCadastrada in PessoaDAO.RetornarPessoas())
                    //    {
                    //        Console.WriteLine("Nome:" + pessoaCadastrada.Nome);
                    //        Console.WriteLine("Cpf: " + pessoaCadastrada.CPF);
                    //        Console.WriteLine("ID: " + pessoaCadastrada.PessoaId);
                    //        Console.WriteLine("-----------------------------------");
                    //    }

                    //    break;
                    //case "3":
                    //    pessoa = new Pessoa();
                    //    Console.Clear();
                    //    Console.WriteLine("-- Listar Pessoas por CPF --");
                    //    Console.WriteLine("Digite o CPF da pessoa: ");
                    //    pessoa.CPF = Console.ReadLine();
                    //    pessoa = PessoaDAO.RetornarPessoasporCPF(pessoa);
                    //    if (pessoa != null)
                    //    {
                    //        Console.WriteLine("Nome:" + pessoa.Nome);
                    //        Console.WriteLine("Cpf: " + pessoa.CPF);
                    //        Console.WriteLine("-----------------------------------");
                    //    }
                    //    else
                    //    {
                    //        Console.WriteLine("Não existe nego com esse CPF");
                    //    }

                    //    break;
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

                    default:
                        Console.WriteLine("Escolha uma Opção");
                        break;
                }
                Console.ReadKey();
            } while (!Op.Equals("0"));
        }
    }
}
