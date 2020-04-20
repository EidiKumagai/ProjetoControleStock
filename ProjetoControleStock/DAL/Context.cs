using ProjetoControleStock.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoControleStock.DAL
{
    class Context : DbContext
    {
 
        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
