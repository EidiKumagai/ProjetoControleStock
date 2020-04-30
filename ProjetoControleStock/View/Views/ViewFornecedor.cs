using ProjetoControleStock.DAL;
using ProjetoControleStock.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoControleStock.View.ViewFornecedores
{
    class ViewFornecedor
    {
        public void viewCadastrarFornecedor (Fornecedor fornecedor) {
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
        }

        public void ViewListarFornecedores() {

            Console.Clear();
            List<Fornecedor> listadeFornecedores = new List<Fornecedor>();
            listadeFornecedores = FornecedorDAO.GetFornecedores();
            Console.WriteLine("-- Listar Fornecedor --");

            if (listadeFornecedores.Count == 0)
            {
                Console.WriteLine("Lista de Fornecedores vazia!");
            }
            else
            {
                foreach (Fornecedor fornecedorCadastrado in FornecedorDAO.GetFornecedores())
                {
                    Console.WriteLine("CODIGO-FORNECEDOR:" + fornecedorCadastrado.Cod_Fornecedor);
                    Console.WriteLine("Nome:" + fornecedorCadastrado.Nome);
                    Console.WriteLine("Razão Social: " + fornecedorCadastrado.RazaoSocial);
                    Console.WriteLine("Cpf/Cnpj: " + fornecedorCadastrado.CpforCnpj);
                    Console.WriteLine("Telefone: " + fornecedorCadastrado.Telefone);
                    Console.WriteLine("Email: " + fornecedorCadastrado.Email);

                    Console.WriteLine("-----------------------------------");
                }
            }

        }
    }
}
