namespace ProjetoControleStock.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelPessoa : DbContext
    {
        public ModelPessoa()
            : base("name=ModelPessoa2")
        {
        }

        public virtual DbSet<Pessoa> pessoas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Pessoa>()
                .Property(e => e.CPF)
                .IsUnicode(false);

            modelBuilder.Entity<Pessoa>()
                .Property(e => e.Sexo)
                .IsUnicode(false);

            modelBuilder.Entity<Pessoa>()
                .Property(e => e.Telefone)
                .IsUnicode(false);
        }
    }
}
