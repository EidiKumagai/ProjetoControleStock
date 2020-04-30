using ProjetoControleStock.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoControleStock.DAL
{
    class EstoqueDAO
    {

        private static Context ctx = new Context();

        public static bool CadastrarEstoque(Estoque estoque)
        {
            try
            {
                ctx.Estoques.Add(estoque);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static List<Estoque> getEstoque() {
            
            return ctx.Estoques.ToList();
            
        }
    }
}
