using ProjetoControleStock.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace ProjetoControleStock.DAL
{
    class PessoaDAO
    {

        private static ModelPessoa ctx1 = new ModelPessoa();


        public static bool CadastrarPessoa(Pessoa pessoa)
        {
            try
            {
                ctx1.pessoas.Add(pessoa);
                ctx1.SaveChanges(); //Salva o que é adicionado no Banco
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public static List<Pessoa> RetornarPessoas()
        {
            return ctx1.pessoas.ToList();
        }

    }
}
