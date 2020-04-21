namespace ProjetoControleStock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Nome = c.String(unicode: false),
                        Preco = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Produtoes");
        }
    }
}
