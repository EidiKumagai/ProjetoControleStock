using ProjetoControleStock.Model;
using ProjetoControleStock.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoControleStock.View.ViewClientes
{
    class ViewCiente
    {

        public void ViewCadastroCliente(Cliente cliente) {
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
        }

        public void ViewListarClientes() {

            Console.Clear();
            List<Cliente> listadeClientes = new List<Cliente>();
            listadeClientes = ClienteDAO.GetClientes();
            Console.WriteLine("-- Listar Clientes --");

            if (listadeClientes.Count == 0)
            {
                Console.WriteLine("Lista de Clientes vazia !");
            }
            else
            {
                foreach (Cliente pessoaCadastrada in ClienteDAO.GetClientes())
                {
                    Console.WriteLine("CODIGO-CLIENTE:" + pessoaCadastrada.Cod_Cliente);
                    Console.WriteLine("Nome:" + pessoaCadastrada.Nome);
                    Console.WriteLine("Razão Social: " + pessoaCadastrada.RazaoSocial);
                    Console.WriteLine("Cpf/Cnpj: " + pessoaCadastrada.CpforCnpj);
                    Console.WriteLine("Telefone: " + pessoaCadastrada.Telefone);

                    Console.WriteLine("-----------------------------------");
                }

            }
        }
    }
}
