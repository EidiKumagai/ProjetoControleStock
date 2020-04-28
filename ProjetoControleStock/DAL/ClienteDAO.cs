using ProjetoControleStock.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoControleStock.DAL
{
    class ClienteDAO
    {
        private static Context ctx = new Context();

        public static bool CadastrarCliente(Cliente cliente) {
            try
            {
                ctx.Clientes.Add(cliente);
                ctx.SaveChanges();
                return true;
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entidade do tipo \"{0}\" no estado \"{1}\" tem os seguintes erros de validação:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Erro: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }

        }


        public static List<Cliente> GetClientes() {
            return ctx.Clientes.ToList();
        }
    }
}
