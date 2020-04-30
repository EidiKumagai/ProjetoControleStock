namespace ProjetoControleStock.DAL
{
    using MySql.Data.Entity;
    using ProjetoControleStock.Model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class Context : DbContext
    {
        // Your context has been configured to use a 'Context' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ProjetoControleStock.DAL.Context' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Context' 
        // connection string in the application configuration file.
        public Context()
            : base("name=Context")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Cliente> Clientes { get; set; }
         public virtual DbSet<Fornecedor> Fornecedores { get; set; }
         public virtual DbSet<Produto> Produtos { get; set; }
         public virtual DbSet<Entrada> Entradas{ get; set; }
         public virtual DbSet<Saida> Saidas{ get; set; }
         public virtual DbSet<Estoque> Estoques{ get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}